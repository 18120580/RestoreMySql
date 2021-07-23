using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestoreMySql
{
	public class MapDataFile
	{
		public string database { get; set; }
		public string filename { get; set; }
		public MapDataFile(string db, string f)
		{
			database = db;
			filename = f;
		}
	}
}
