using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RestoreMySql
{
	public class Logger
	{
		public string filepath { get; set; } = "RestoreError.text";
		public FileStream file;
		public StreamWriter write;
		public void SetFilePath(string path)
		{
			filepath = path;
		}
		public void DeleteFile()
		{
			if (File.Exists(filepath))
			{
				File.Delete(filepath);
			}
		}
		public void openfile()
		{
			if (!File.Exists(filepath))
			{
				file = new FileStream(filepath, FileMode.Create);
			}
			else
			{
				file = new FileStream(filepath, FileMode.Append);
			}
			write = new StreamWriter(file, Encoding.UTF8);
		}
		public void log(string text)
		{
			string datetime = DateTime.Now.ToString();
			text = "[" + datetime + "]" + text;
			openfile();
			write.WriteLine(text);
			write.Flush();
			file.Close();
		}
	}
}
