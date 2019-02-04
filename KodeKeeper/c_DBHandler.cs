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
		

		public int coalesce(int type, object value)
		{
			int val = -1;
			if (value == null || value is DBNull || value.ToString() == "")
			{
				val = default(int);
			}
			else
			{
				int.TryParse(value.ToString(), out val);
			}

			return val;
		}

		public string coalesce(string type, object value)
		{
			string val = value.ToString();

			if(value == null || value is DBNull || value.ToString() == "")
			{
				value = "";
			}
			return value.ToString();
		}

		public void updateSshFingerPrint(int id, string fingerprint)
		{
			if (!checkConnection()) { return; }
			_sql.CommandText = $"UPDATE connections SET SshHostKeyFingerprint='{fingerprint}' WHERE id={id}";
			_sql.ExecuteNonQuery();
		}
		
		public List<c_ConnectionObject> getConnections()
		{
			if (!checkConnection()) { return null; }
			List<c_ConnectionObject> conns = new List<c_ConnectionObject>();

			_sql.CommandText = "SELECT * FROM connections";

			SQLiteDataReader reader = _sql.ExecuteReader();

			while (reader.Read())
			{
				c_ConnectionObject c = new c_ConnectionObject();
				
				c.Id						= coalesce(0,	reader.GetValue(reader.GetOrdinal("id")						));
				c.Project_id				= coalesce(0,	reader.GetValue(reader.GetOrdinal("project_id")				));
				c.Log_id					= coalesce(0,	reader.GetValue(reader.GetOrdinal("log_id")					));
				c.Name						= coalesce("",	reader.GetValue(reader.GetOrdinal("name")					));
				c.Host						= coalesce("",	reader.GetValue(reader.GetOrdinal("host_name")				));
				c.Port						= coalesce(0,	reader.GetValue(reader.GetOrdinal("port")					));
				c.Password					= coalesce("",	reader.GetValue(reader.GetOrdinal("password")				));
				c.Username					= coalesce("",	reader.GetValue(reader.GetOrdinal("username")				));
				c.Connection_protocol		= coalesce("",	reader.GetValue(reader.GetOrdinal("connection_protocol")	));
				c.Authentication_method		= coalesce("",	reader.GetValue(reader.GetOrdinal("authentication_method")	));
				c.Username					= coalesce("",	reader.GetValue(reader.GetOrdinal("username")				));
				c.Password					= coalesce("",	reader.GetValue(reader.GetOrdinal("password")				));
				c.Keyfile_path				= coalesce("",	reader.GetValue(reader.GetOrdinal("keyfile_path")			));
				c.Key_pass_phrase			= coalesce("",	reader.GetValue(reader.GetOrdinal("key_pass_phrase")		));
				c.Use_stored_keys			= coalesce("",	reader.GetValue(reader.GetOrdinal("use_stored_keys")		));
				c.SshHostKeyFingerprint		= coalesce("",	reader.GetValue(reader.GetOrdinal("SshHostKeyFingerprint")	));
				c.Home_folder				= coalesce("",	reader.GetValue(reader.GetOrdinal("home_folder")			));
				c.LastConnected				= coalesce("",	reader.GetValue(reader.GetOrdinal("lastConnected")			));
				c.Last_error				= coalesce("",	reader.GetValue(reader.GetOrdinal("last_error")				));
				c.Last_update_finished		= coalesce("",	reader.GetValue(reader.GetOrdinal("last_update_finished")	));
				c.Ping_interval				= coalesce(0,	reader.GetValue(reader.GetOrdinal("ping_interval")			));
				
				conns.Add(c);
			}

			reader.Close();

			return conns;
		}

		public void saveConnection(c_ConnectionObject c)
		{
			if (!checkConnection()) { return; }

			if (c.Id == -1)
			{
				string logid = "";
				byte[] logidbytes = Encoding.UTF8.GetBytes($"{c.Project_id}{c.Name}{c.Host}{c.Username}{c.Password}");
				System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
				byte[] ret = md5.ComputeHash(logidbytes);
				foreach (byte b in ret)
				{
					logid += b.ToString("X2").ToUpper();
				}

				_sql.CommandText = 
$@"
INSERT INTO connections
(
	project_id,
	log_id,
	name,
	host_name,
	username,
	password,
	port,
	connection_protocol,
	authentication_method,
	keyfile_path,
	key_pass_phrase,
	use_stored_keys,
	SshHostKeyFingerprint,
	home_folder,
	proxy_settings,
	ssh_settings,
	tunnel_settings,
	ping_interval
)
VALUES
(
	'{c.Project_id}',
	'{logid}',
	'{c.Name}',
	'{c.Host}',
	'{c.Username}',
	'{c.Password}',
	'{c.Port}',
	'{c.Connection_protocol}',
	'{c.Authentication_method}',
	'{c.Keyfile_path}',
	'{c.Key_pass_phrase}',
	'{c.Use_stored_keys}',
	'{c.SshHostKeyFingerprint}',
	'{c.Home_folder}',
	'{c.Proxy_Settings}',
	'{c.Ssh_Settings}',
	'{c.Tunnel_Settings}',
	'{c.Ping_interval}'
);
";
				_sql.ExecuteNonQuery();

			}
		}

		public string getProjectName(int project_id)
		{
			if (!checkConnection()) { return ""; }
			_sql.CommandText = $"SELECT  name FROM projects WHERE id={project_id}";
			object r = _sql.ExecuteScalar();
			if (!(r is null) && !(r is DBNull) && r.ToString() != "")
			{
				return r.ToString();
			}

			return "";
		}

		public List<object[]> getProjectNames()
		{
			List<object[]> lst = new List<object[]>();

			if (!checkConnection()) { return null; }
			_sql.CommandText = $"SELECT name, projects_uid as id FROM projects";
			SQLiteDataReader r = _sql.ExecuteReader();

			while (r.Read())
			{
				lst.Add(new object[] { r.GetString(r.GetOrdinal("name")), r.GetInt32(r.GetOrdinal("id")) });
			}

			return lst;
		}

		public int getFileTypeId(string fileTypeName)
		{
			if (!checkConnection()) { return -1; }
			_sql.CommandText = $"SELECT  id FROM filetypes WHERE lower(type) LIKE '%{fileTypeName.ToLower()}%'";
			object r = _sql.ExecuteScalar();
			if (!(r is null) && !(r is DBNull) && r.ToString() != "")
			{
				if (int.TryParse(r.ToString(), out int i)) {
					return i;
				}
				else
				{
					return -1;
				}
			}

			return 0;
		}

		public object[] getImageForType(string fileTypeName)
		{
			object[] o = new object[] { "", "", "" };

			if (!checkConnection()) { return null; }
			_sql.CommandText = $"SELECT id, name, image FROM images WHERE lower(for) LIKE '%{fileTypeName.ToLower()}%'";
			SQLiteDataReader r = _sql.ExecuteReader();

			while (r.Read())
			{
				o[0] = r.GetValue(r.GetOrdinal("id"));
				o[1] = r.GetValue(r.GetOrdinal("name"));
				o[2] = r.GetValue(r.GetOrdinal("image"));
			}

			r.Close();

			return o;
		}

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
