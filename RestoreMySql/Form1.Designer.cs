
namespace RestoreMySql
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.cmb_databasename = new System.Windows.Forms.ComboBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.DatabaseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DataFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_restore = new System.Windows.Forms.Button();
			this.btn_select = new System.Windows.Forms.Button();
			this.btn_openfile = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_datafile = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_password = new System.Windows.Forms.TextBox();
			this.txt_username = new System.Windows.Forms.TextBox();
			this.txt_server = new System.Windows.Forms.TextBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(716, 312);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(87, 23);
			this.button4.TabIndex = 38;
			this.button4.Text = "DeleteAll";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(466, 312);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(104, 23);
			this.button3.TabIndex = 37;
			this.button3.Text = "DeleteRow";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// cmb_databasename
			// 
			this.cmb_databasename.FormattingEnabled = true;
			this.cmb_databasename.Location = new System.Drawing.Point(232, 198);
			this.cmb_databasename.Name = "cmb_databasename";
			this.cmb_databasename.Size = new System.Drawing.Size(571, 21);
			this.cmb_databasename.TabIndex = 36;
			this.cmb_databasename.Click += new System.EventHandler(this.cmb_databasename_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatabaseName,
            this.DataFile});
			this.dataGridView1.Location = new System.Drawing.Point(232, 357);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(571, 123);
			this.dataGridView1.TabIndex = 35;
			// 
			// DatabaseName
			// 
			this.DatabaseName.HeaderText = "DatabaseName";
			this.DatabaseName.Name = "DatabaseName";
			this.DatabaseName.Width = 150;
			// 
			// DataFile
			// 
			this.DataFile.HeaderText = "DataFile";
			this.DataFile.Name = "DataFile";
			this.DataFile.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.DataFile.Width = 382;
			// 
			// btn_restore
			// 
			this.btn_restore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn_restore.Location = new System.Drawing.Point(466, 496);
			this.btn_restore.Name = "btn_restore";
			this.btn_restore.Size = new System.Drawing.Size(104, 23);
			this.btn_restore.TabIndex = 34;
			this.btn_restore.Text = "Restore";
			this.btn_restore.UseVisualStyleBackColor = true;
			this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
			// 
			// btn_select
			// 
			this.btn_select.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn_select.Location = new System.Drawing.Point(232, 312);
			this.btn_select.Name = "btn_select";
			this.btn_select.Size = new System.Drawing.Size(87, 23);
			this.btn_select.TabIndex = 33;
			this.btn_select.Text = "Select";
			this.btn_select.UseVisualStyleBackColor = true;
			this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
			// 
			// btn_openfile
			// 
			this.btn_openfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn_openfile.Location = new System.Drawing.Point(811, 261);
			this.btn_openfile.Name = "btn_openfile";
			this.btn_openfile.Size = new System.Drawing.Size(87, 23);
			this.btn_openfile.TabIndex = 32;
			this.btn_openfile.Text = "OpenFile";
			this.btn_openfile.UseVisualStyleBackColor = true;
			this.btn_openfile.Click += new System.EventHandler(this.btn_openfile_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(11, 271);
			this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 13);
			this.label5.TabIndex = 31;
			this.label5.Text = "DataFile:";
			// 
			// txt_datafile
			// 
			this.txt_datafile.Location = new System.Drawing.Point(232, 263);
			this.txt_datafile.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.txt_datafile.Name = "txt_datafile";
			this.txt_datafile.Size = new System.Drawing.Size(571, 20);
			this.txt_datafile.TabIndex = 30;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(11, 198);
			this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(97, 13);
			this.label4.TabIndex = 29;
			this.label4.Text = "DatabaseName:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 138);
			this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 13);
			this.label3.TabIndex = 28;
			this.label3.Text = "Password:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(11, 78);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 27;
			this.label2.Text = "UserName:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 29);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(48, 13);
			this.label1.TabIndex = 26;
			this.label1.Text = "Server:";
			// 
			// txt_password
			// 
			this.txt_password.Location = new System.Drawing.Point(232, 132);
			this.txt_password.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.txt_password.Name = "txt_password";
			this.txt_password.Size = new System.Drawing.Size(571, 20);
			this.txt_password.TabIndex = 25;
			// 
			// txt_username
			// 
			this.txt_username.Location = new System.Drawing.Point(232, 75);
			this.txt_username.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.txt_username.Name = "txt_username";
			this.txt_username.Size = new System.Drawing.Size(571, 20);
			this.txt_username.TabIndex = 24;
			// 
			// txt_server
			// 
			this.txt_server.Location = new System.Drawing.Point(232, 23);
			this.txt_server.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.txt_server.Name = "txt_server";
			this.txt_server.Size = new System.Drawing.Size(571, 20);
			this.txt_server.TabIndex = 23;
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(902, 631);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.cmb_databasename);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btn_restore);
			this.Controls.Add(this.btn_select);
			this.Controls.Add(this.btn_openfile);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txt_datafile);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_password);
			this.Controls.Add(this.txt_username);
			this.Controls.Add(this.txt_server);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RESTORE MYSQL";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.ComboBox cmb_databasename;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn DatabaseName;
		private System.Windows.Forms.DataGridViewTextBoxColumn DataFile;
		private System.Windows.Forms.Button btn_restore;
		private System.Windows.Forms.Button btn_select;
		private System.Windows.Forms.Button btn_openfile;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_datafile;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_password;
		private System.Windows.Forms.TextBox txt_username;
		private System.Windows.Forms.TextBox txt_server;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
	}
}

