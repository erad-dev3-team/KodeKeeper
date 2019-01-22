using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SQLite;
using System.IO;

namespace KodeKeeper
{
	public class c_DBHandler
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

		public bool checkConnection()
		{
			if (Sqlc == null || new int[] { 0, 16 }.Contains((int)Sqlc.State)) { return false; }
			return true;
		}

		public bool updateInsert(string insertdata)
		{
			try
			{
				if (!checkConnection()) { throw new Exception("ERR"); }

				_sql.CommandText = insertdata;
				_sql.ExecuteNonQuery();

				return true;
			}
			catch
			{
				return false;
			}
		}

		public bool checkTableExists(string tableName)
		{
			_sql.CommandText = ("SELECT name FROM sqlite_master WHERE type='table' AND name='" + tableName + "'");
			if (_sql.ExecuteScalar() is null) { return false; }
			else { return true; }
		}
		/*
		//TODO: 20190120 - GetData
		public Dictionary<string, string> getData(string table)
		{
			
			if (checkTableExists(table))
			{
				_sql.CommandText = "SELECT * FROM " + table;
			}
		}
		*/
		public void setFileData()
		{
			//TODO: FileDataInsert
			if (!checkConnection()) { return; }
			_sql.CommandText = $@"INSERT INTO files
(
	
)
VALUES
(
	
)";
		}

		public void getFileData()
		{

		}

		public void setUserName(string username)
		{
			if (!checkConnection()) { return; }
			_sql.CommandText = "INSERT INTO userdata " +
									"(username, last_update_received, last_update_received) " +
								"VALUES " +
									$"('{username}','1900-01-01','1900-01-01')";
			_sql.ExecuteNonQuery();
		}

		public string getUserName()
		{
			if (!checkConnection()) { return null; }
			_sql.CommandText =	"SELECT "	+
								"username "	+
								"FROM "		+
								"userdata "	+
								"LIMIT 1;";

			var name = _sql.ExecuteScalar();
			if(name is null || name is DBNull) { return null; }
			else { return name.ToString(); }
		}

		public void setLastUpdateDataRecieved(DateTime last_update_received)
		{
			if (!checkConnection()) { return; }
			_sql.CommandText = "INSERT INTO " +
								"username (last_update_received) " +
								$"VALUES ('{last_update_received}'); ";
		}

		public DateTime? getLastUpdateDataRecieved()
		{
			if (!checkConnection()) { return null; }
			_sql.CommandText = "SELECT " +
								"last_update_received " +
								"FROM " +
								"userdata " +
								"LIMIT 1;";

			var name = _sql.ExecuteScalar();
			if (name is DBNull) { return null; }
			else
			{
				string d = name.ToString();
				if (DateTime.TryParse(d, out DateTime o))
				{
					return o;
				}
			}

			return null;
		}

		public void setLastUpdateDataSent(DateTime last_update_sent)
		{
			if (!checkConnection()) { return; }
			_sql.CommandText = "INSERT INTO " +
								"username (last_update_sent) " +
								$"VALUES ('{last_update_sent}'); ";
		}

		public DateTime? getLastUpdateDataSent()
		{
			if (!checkConnection()) { return null; }
			_sql.CommandText = "SELECT " +
								"last_update_received " +
								"FROM " +
								"userdata " +
								"LIMIT 1;";

			var name = _sql.ExecuteScalar();
			if (name is DBNull) { return null; }
			else
			{
				string d = name.ToString();
				if (DateTime.TryParse(d, out DateTime o))
				{
					return o;
				}
			}

			return null;
		}


	}
}
