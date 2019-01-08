using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SQLite;
using System.IO;

namespace KodeKeeper
{
	class c_DBHandler
	{
		public SQLiteConnection Sqlc = null;
		private SQLiteCommand _sql = null;
		
		public c_DBHandler(string fileName = "db.db")
		{
			Sqlc = new SQLiteConnection($"Data Source={fileName};Version=3;");
			Sqlc.Open();
			c_DBInit di = new c_DBInit(Sqlc, fileName);
			_sql = new SQLiteCommand() { Connection = Sqlc };
			di.init();
		}

		


	}
}
