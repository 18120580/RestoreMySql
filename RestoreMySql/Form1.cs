using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;

namespace RestoreMySql
{
	
	public partial class Form1 : Form
	{
		Logger file = new Logger();
		public Form1()
		{
			InitializeComponent();
			Control.CheckForIllegalCrossThreadCalls = false;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			txt_server.Text = "localhost";
			txt_username.Text = "root";
			txt_password.Text = "123123";
			file.DeleteFile();
		}
		private void SetMax_Allowed_Packet()
		{
			string constring = "server=" + txt_server.Text + ";user=" + txt_username.Text + ";pwd=" + txt_password.Text + ";";
			MySqlConnection con = new MySqlConnection(constring);
			MySqlCommand cmd = new MySqlCommand("set global max_allowed_packet=67108864;", con);
			con.Open();
			cmd.ExecuteNonQuery();
			cmd.Dispose();
			con.Close();
		}
		private List<string> ShowDatabase()
		{
			List<string> list = new List<string>();
			string constring = "server=" + txt_server.Text + ";user=" + txt_username.Text + ";pwd=" + txt_password.Text + ";";
			MySqlConnection con = new MySqlConnection(constring);
			con.Open();
			MySqlCommand cmd = new MySqlCommand("show databases", con);
			MySqlDataAdapter adt = new MySqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			adt.Fill(dt);
			cmd.Dispose();
			adt.Dispose();
			con.Close();
			foreach (DataRow dr in dt.Rows)
			{
				list.Add(Convert.ToString(dr["Database"]));
			}
			dt.Clear();
			return list;
		}
		private List<MapDataFile> DataGridViewToList(DataGridView dtg)
		{
			List<MapDataFile> list = new List<MapDataFile>();
			for (int i = 0; i < dtg.Rows.Count - 1; i++)
			{
				MapDataFile map = new MapDataFile(Convert.ToString(dtg.Rows[i].Cells[0].Value), Convert.ToString(dtg.Rows[i].Cells[1].Value));
				list.Add(map);
			}
			return list;
		}
		private void CreateNewDatabase(string DatabaseName)
		{
			string constring = "server=" + txt_server.Text + ";user=" + txt_username.Text + ";pwd=" + txt_password.Text + ";";
			MySqlConnection con = new MySqlConnection(constring);
			MySqlCommand cmd = new MySqlCommand("CREATE DATABASE `" + DatabaseName+"`", con);
			con.Open();
			cmd.ExecuteNonQuery();
			cmd.Dispose();
			con.Close();
		}
		private void DropDatabase(string DatabaseName)
		{

			string constring = "server=" + txt_server.Text + ";user=" + txt_username.Text + ";pwd=" + txt_password.Text + ";";
			MySqlConnection con = new MySqlConnection(constring);
			MySqlCommand cmd = new MySqlCommand("DROP DATABASE `" + DatabaseName + "`", con);
			con.Open();
			cmd.ExecuteNonQuery();
			cmd.Dispose();
			con.Close();

		}
		private void Restore()
		{
			try
			{
				DialogResult result = MessageBox.Show("your database will be deleted and restored\nDo you want to continue?", "Infomation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
				if (result == DialogResult.Yes)
				{
					List<MapDataFile> list = new List<MapDataFile>();
					list = DataGridViewToList(dataGridView1);
					List<string> Database = ShowDatabase();
					Thread[] t = new Thread[list.Count];
					//set Max_allowed_packet
					SetMax_Allowed_Packet();
					#region delete and create new db
					for (int i = 0; i < list.Count; i++)
					{
						for (int j = 0; j < Database.Count; j++)
						{
							if (Database[j] == list[i].database)
							{
								DropDatabase(Database[j]);
								Database.RemoveAt(j);
							}
						}
						string db = list[i].database;
						string file = list[i].filename;
						CreateNewDatabase(db);
						#endregion
						int x = 232;
						int y = 535 + i *45;
						Label dbname = AddLabel(x - 80, y);
						dbname.Text = db;
						ProgressBar p= ProcessBar(x, y);
						Label percent = AddLabel(x, y - 15);
						t[i] = new Thread(() =>
						{
						string constring = "server=" + txt_server.Text + ";user=" + txt_username.Text + ";pwd=" + txt_password.Text + ";database=" + db + ";";
						constring += "charset=utf8;convertzerodatetime=true;";
						using (MySqlConnection conn = new MySqlConnection(constring))
						{
							using (MySqlCommand cmd = new MySqlCommand())
							{
								using (MySqlBackup mb = new MySqlBackup(cmd))
								{
									cmd.Connection = conn;
									conn.Open();
									mb.ImportProgressChanged += (sende, e) => {
										percent.Text = e.PercentageCompleted.ToString() + "% Complete";
											p.Visible = true;
											p.Maximum = 100;
											p.Value = Convert.ToInt32(e.PercentageCompleted); 
										};
										mb.ImportCompleted += Restore_completed;
										mb.ImportInfo.IntervalForProgressReport = (int)500;
										mb.ImportFromFile(file);
										conn.Close();
									}
								}
							}
						});
						t[i].Start();
					}
					Thread check = new Thread(() =>
					{
						for (int i = 0; i < list.Count; i++)
						{
							btn_restore.Enabled = false;
							while (t[i].IsAlive)
							{
								Thread.Sleep(10);
							}
						}
						btn_restore.Enabled = true;
					});
					check.Start();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
				file.log(ex.Message);
			}
		}
		private ProgressBar ProcessBar(int x, int y)
		{
			ProgressBar p = new ProgressBar();
			p.Location = new Point(x, y);
			p.Size = new Size(571, 10);
			this.Controls.Add(p);
			return p;
		}
		private Label AddLabel(int x, int y)
		{
			Label lb = new Label();
			lb.Location = new Point(x, y);
			this.Controls.Add(lb);
			return lb;
		}

		private void btn_select_Click(object sender, EventArgs e)
		{
			try
			{
				for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
				{
					if (Convert.ToString(dataGridView1.Rows[i].Cells[0].Value) == cmb_databasename.Text | Convert.ToString(dataGridView1.Rows[i].Cells[1].Value) == txt_datafile.Text)
					{
						MessageBox.Show("cannot insert duplicate value!");
						return;
					}
				}
					this.dataGridView1.Rows.Add(cmb_databasename.Text, txt_datafile.Text);
				cmb_databasename.Text = "";
				txt_datafile.Text = "";
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
				file.log(ex.Message);
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				this.dataGridView1.Rows.RemoveAt(this.dataGridView1.CurrentRow.Index);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
				file.log(ex.Message);
			}
		}

		private void btn_openfile_Click(object sender, EventArgs e)
		{
			OpenFileDialog openfile = new OpenFileDialog();
			if (openfile.ShowDialog() == DialogResult.OK)
			{
				txt_datafile.Text = openfile.FileName;
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			try
			{
				dataGridView1.Rows.Clear();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
				file.log(ex.Message);
			}
		}

		private void cmb_databasename_Click(object sender, EventArgs e)
		{
			try
			{
				if (cmb_databasename.Items.Count <= 0)
				{
					List<string> list = ShowDatabase();
					for (int i = 0; i < list.Count; i++)
						cmb_databasename.Items.Add(list[i]);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
				file.log(ex.Message);
			}
		}

		private void btn_restore_Click(object sender, EventArgs e)
		{
			Restore();
		}
		private void Restore_progreesschange(object sende, ImportProgressArgs e)
		{
		}
		private void Restore_completed(object sende, ImportCompleteArgs e)
		{
			//MessageBox.Show("Successfully Restore !");
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			Restore();
		}
	}
}
