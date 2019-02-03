using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SQLite;
using System.IO;

namespace KodeKeeper
{
	class c_DBInit
	{
		private SQLiteConnection _sqlc = null;
		private SQLiteCommand _sql = null;
		string _fileName = "";

		public c_DBInit(SQLiteConnection SQLC, string FileName)
		{
			_sqlc = SQLC;
			_fileName = FileName;
		}

		public void init()
		{
			createDbFile(_fileName);
			_sql = new SQLiteCommand() { Connection = _sqlc };
			createTables();
		}

		public bool checkConnection()
		{
			if (_sqlc == null || new int[] { 0, 16 }.Contains((int)_sqlc.State)) { return false; }
			return true;
		}

		public bool createDbFile(string fn)
		{
			bool ret = false;
			if (!File.Exists(fn))
			{
				try
				{
					File.Create(fn).Close();
					ret = true;
				}
				catch (Exception ex) { Console.Error.WriteLine(ex.Message); }
			}
			else { ret = true; }
			return ret;
		}

		public bool checkTableExists(string tableName)
		{
			_sql.CommandText = ("SELECT name FROM sqlite_master WHERE type='table' AND name='" + tableName + "'");
			if (_sql.ExecuteScalar() is null) { return false; }
			else { return true; }
		}


		//TODO: Foreign key-ket összehangolni az új UID-kkel
		public string createTables()
		{
			if (!checkConnection()) { return "E:ConnectionError"; }

			string fileName = "SQLiteOutput.txt";
			if (!File.Exists(fileName)) { File.Create(fileName).Close(); }

			if (!checkTableExists("projects"))
			{
				_sql.CommandText = "CREATE TABLE " +
										"projects " +
									"(" +
											"id INTEGER PRIMARY KEY AUTOINCREMENT,						\r\n" +     //row ID
											"projects_uid INTEGER UNIQUE,								\r\n" +		//Unique ID
											"name TEXT,													\r\n" +		//Project name
											"number_of_files INTEGER,									\r\n" +		//Number of files in the project
											"added TEXT,												\r\n" +		//Date the project was added
											"modified TEXT,												\r\n" +     //Date the project was modified
											"insert_user_id INTEGER,									\r\n" +		//
											"comment TEXT												\r\n" +     //comment
									");\r\n" +

									"CREATE INDEX IF NOT EXISTS project_id_index	ON projects(id);			\r\n" +
									"CREATE INDEX IF NOT EXISTS project_uid_index	ON projects(projects_uid);	\r\n";

				//File.AppendAllText(fileName, "\r\n\r\n" + _sql.CommandText);
				_sql.ExecuteNonQuery();
			}
			
			if (!checkTableExists("images"))
			{
				_sql.CommandText = "CREATE TABLE " +
										"images " +
									"(" +
										"id INTEGER PRIMARY KEY AUTOINCREMENT,							\r\n" +     //row ID
										"images_uid INTEGER UNIQUE,										\r\n" +     //Unique ID
										"name TEXT,														\r\n" +     //Image file name
										"size INTEGER,													\r\n" +     //Image Size in pixels
										"for TEXT,														\r\n" +     //What the image is used for
										"image TEXT														\r\n" +     //Image data in bytes
										"comment TEXT													\r\n" +     //Comment
									");\r\n" +

									"CREATE INDEX IF NOT EXISTS images_id_index		ON images(id);			\r\n" +
									"CREATE INDEX IF NOT EXISTS images_uid_index	ON images(images_uid);	\r\n" +
									"CREATE INDEX IF NOT EXISTS images_name_index	ON images(name);		\r\n";

				//File.AppendAllText(fileName, "\r\n\r\n" + _sql.CommandText);
				_sql.ExecuteNonQuery();

				_sql.CommandText = auto_add_data.autoAddImages();

				//File.AppendAllText(fileName, "\r\n\r\n" + _sql.CommandText);
				_sql.ExecuteNonQuery();
			}

			if (!checkTableExists("filetypes"))
			{
				_sql.CommandText = "CREATE TABLE " +
										"filetypes " +
									"(" +
										"id INTEGER PRIMARY KEY AUTOINCREMENT,							\r\n" +     //row ID
										"filetypes_uid INTEGER UNIQUE,									\r\n" +     //Unique ID
										"type TEXT,														\r\n" +     //File type
										"description TEXT,												\r\n" +     //File type description
										"mime_type TEXT,												\r\n" +     //Mime type
										"def_image_id INTEGER,											\r\n" +     //Default image index
										"comment TEXT,													\r\n" +     //comment
										"insert_user_id INTEGER DEFAULT 1,								\r\n" +		//
										"modified TEXT,													\r\n" +		//
										"FOREIGN KEY(def_image_id) REFERENCES images(id)				\r\n" +     //
									");\r\n" +

									"CREATE INDEX IF NOT EXISTS filetypes_id_index		ON filetypes(id);				\r\n" +
									"CREATE INDEX IF NOT EXISTS filetypes_uid_index		ON filetypes(filetypes_uid);	\r\n" +
									"CREATE INDEX IF NOT EXISTS filetypes_type_index	ON filetypes(type);				\r\n";

				//File.AppendAllText(fileName, "\r\n\r\n" + _sql.CommandText);
				_sql.ExecuteNonQuery();

				_sql.CommandText = auto_add_data.autoAddFileTypes();

				//File.AppendAllText(fileName, "\r\n\r\n" + _sql.CommandText);
				_sql.ExecuteNonQuery();
			}

			if (!checkTableExists("files"))
			{
				_sql.CommandText = "CREATE TABLE " +
										"files " +
									"(" +
										"id INTEGER PRIMARY KEY AUTOINCREMENT,							\r\n" +     //row ID
										"files_uid INTEGER UNIQUE,										\r\n" +		//Unique ID
										"project_id INTEGER,											\r\n" +		//ID of project under which the file is
										"file_name TEXT,												\r\n" +		//File Name (eg: cr_new.php)
										"location TEXT,													\r\n" +		//File Location (eg: /usr/local/dpdweblabel/cr/)
										"file_type_id INTEGER,											\r\n" +		//ID of filetype
										"md5 TEXT UNIQUE,												\r\n" +     //MD5 generated from (project_id + file_name + location + file_type_id)
										"file_version TEXT,												\r\n" +		//Version of file (eg: 2)
										"in_use INTEGER,												\r\n" +		//Bool value, 1 if file is in use 0 otherwise (eg: 1)
										"parameters TEXT,												\r\n" +		//Input parameters for file (eg: parcel_number address_id)
										"file_contents TEXT,											\r\n" +		//Contents of file. B64 encoded
										"file_size INTEGER,												\r\n" +		//File size in bytes (eg: 897)
										"notes TEXT,													\r\n" +		//Notes on the file, what it's for, how it works anything else...
										"rights INTEGER,												\r\n" +		//File Rights (eg: 766)
										"owner TEXT,													\r\n" +		//File Owner (eg: root)
										"`group` TEXT,													\r\n" +		//File Group (eg: developers)
										"file_added TEXT,												\r\n" +		//File added date (eg: 2018-05-11)
										"file_modified TEXT,											\r\n" +     //File modified date (eg: 2018-07-27)
										"insert_user_id INTEGER,										\r\n" +		//
										"modified TEXT,													\r\n" +		//
										"comment TEXT,													\r\n" +     //Any additional comment
										"FOREIGN KEY(project_id)	REFERENCES projects(projects_uid),	\r\n" +     //Foreign key for project_id
										"FOREIGN KEY(file_type_id)	REFERENCES filetypes(filetypes_uid)	\r\n" +		//Foreign key for file_type_id
									");\r\n" +

									"CREATE INDEX IF NOT EXISTS files_id_index		ON files(id);			\r\n" +
									"CREATE INDEX IF NOT EXISTS files_uid_index		ON files(files_uid);	\r\n" +
									"CREATE INDEX IF NOT EXISTS files_name_index	ON files(file_name);	\r\n" +
									"CREATE INDEX IF NOT EXISTS files_notes_index	ON files(notes);		\r\n";

				//File.AppendAllText(fileName, "\r\n\r\n" + _sql.CommandText);
				_sql.ExecuteNonQuery();

			}

			if (!checkTableExists("links"))
			{
				_sql.CommandText = "CREATE TABLE " +
										"links " +
									"(" +
										"id INTEGER PRIMARY KEY AUTOINCREMENT,								\r\n" +     //row ID
										"links_uid INTEGER UNIQUE,											\r\n" +     //Unique ID
										"name TEXT,															\r\n" +		//
										"file_from INTEGER,													\r\n" +		//
										"file_to INTEGER,													\r\n" +		//
										"is_data_sent INTEGER,												\r\n" +		//
										"data_sent TEXT,													\r\n" +		//
										"is_data_returned INTEGER,											\r\n" +		//
										"data_returned TEXT,												\r\n" +		//
										"insert_user_id INTEGER,											\r\n" +		//
										"method_from TEXT,													\r\n" +		//
										"method_to TEXT,													\r\n" +		//
										"modified TEXT,														\r\n" +		//
										"comment TEXT,														\r\n" +     //
										"FOREIGN KEY(file_from)	REFERENCES files(files_uid),				\r\n" +     //
										"FOREIGN KEY(file_to)	REFERENCES files(files_uid)					\r\n" +		//
									");\r\n" +

									"CREATE INDEX IF NOT EXISTS links_id_index		ON links(id);			\r\n" +
									"CREATE INDEX IF NOT EXISTS links_uid_index		ON links(links_uid);	\r\n" +
									"CREATE INDEX IF NOT EXISTS links_name_index	ON links(name);			\r\n" +
									"CREATE INDEX IF NOT EXISTS links_from_index	ON links(file_from);	\r\n" +
									"CREATE INDEX IF NOT EXISTS links_to_index		ON links(file_to);		\r\n";

				//File.AppendAllText(fileName, "\r\n\r\n" + _sql.CommandText);
				_sql.ExecuteNonQuery();
			}

			if (!checkTableExists("tag_type"))
			{
				_sql.CommandText = "CREATE TABLE " +
										"tag_type " +
									"(" +
										"id INTEGER PRIMARY KEY AUTOINCREMENT,								\r\n" +     //row ID
										"tag_type_uid INTEGER UNIQUE,										\r\n" +     //Unique ID
										"tag_type TEXT,														\r\n" +     //
										"example TEXT,														\r\n" +     //
										"insert_user_id INTEGER,											\r\n" +     //
										"modified TEXT,														\r\n" +     //
										"comment TEXT														\r\n" +     //
									");" +
									"CREATE INDEX IF NOT EXISTS tag_type_uid_index	ON tag_type(tag_type_uid);	\r\n" +
									"CREATE INDEX IF NOT EXISTS tag_type_id_index	ON tag_type(id);			\r\n";

				//File.AppendAllText(fileName, "\r\n\r\n" + _sql.CommandText);
				_sql.ExecuteNonQuery();
			}

			if (!checkTableExists("tags_list"))
			{
				_sql.CommandText = "CREATE TABLE " +
										"tags_list " +
									"(" +
										"id INTEGER PRIMARY KEY AUTOINCREMENT,								\r\n" +     //row ID
										"tags_list_uid INTEGER UNIQUE,										\r\n" +     //Unique ID
										"tag_type_id INTEGER,												\r\n" +     //Unique ID
										"tag TEXT,															\r\n" +		//
										"description TEXT,													\r\n" +     //
										"insert_user_id INTEGER,											\r\n" +		//
										"modified TEXT,														\r\n" +		//
										"comment TEXT,														\r\n" +     //
										"FOREIGN KEY(tag_type_id)	REFERENCES tag_type(tag_type_uid)		\r\n" +     //
									");\r\n" +

									"CREATE INDEX IF NOT EXISTS tags_list_id_index ON tags_list(id);					\r\n" +
									"CREATE INDEX IF NOT EXISTS tags_list_uid_index ON tags_list(tags_list_uid);		\r\n" +
									"CREATE INDEX IF NOT EXISTS tags_list_tag_index ON tags_list(tag);					\r\n" +
									"CREATE INDEX IF NOT EXISTS tags_list_description_index ON tags_list(description);	\r\n";

				//File.AppendAllText(fileName, "\r\n\r\n" + _sql.CommandText);
				_sql.ExecuteNonQuery();
			}

			if (!checkTableExists("tags"))
			{
				_sql.CommandText = "CREATE TABLE " +
										"tags " +
									"(" +
										"id INTEGER PRIMARY KEY AUTOINCREMENT,								\r\n" +     //row ID
										"tags_uid INTEGER UNIQUE,											\r\n" +     //Unique ID
										"tags_list_id INTEGER,												\r\n" +     //Unique ID
										"file_id INTEGER,													\r\n" +     //
										"insert_user_id INTEGER,											\r\n" +     //
										"modified TEXT,														\r\n" +     //
										"comment TEXT,														\r\n" +     //
										"FOREIGN KEY(tags_list_id)	REFERENCES tags_list(tags_list_uid),	\r\n" +     //
										"FOREIGN KEY(file_id)		REFERENCES files(files_uid)				\r\n" +     //
									");\r\n" +

									"CREATE INDEX IF NOT EXISTS tags_id_index	ON tags(id);			\r\n" +
									"CREATE INDEX IF NOT EXISTS tags_uid_index	ON tags(tags_uid);		\r\n";

				//File.AppendAllText(fileName, "\r\n\r\n" + _sql.CommandText);
				_sql.ExecuteNonQuery();
			}

			if (!checkTableExists("userdata"))
			{
				_sql.CommandText = "CREATE TABLE " +
										"userdata " +
									"(" +
										"id INTEGER PRIMARY KEY AUTOINCREMENT,								\r\n" +     //row ID
										"uid INTEGER,														\r\n" +     //Unique ID
										"username TEXT,														\r\n" +     //Username
										"last_server INTEGER,												\r\n" +     //Last server connected to
										"version_number INTEGER,											\r\n" +     //Program version
										"last_update_received TEXT,											\r\n" +     //When did the user last pull an update from the server
										"last_update_sent TEXT												\r\n" +     //When did the user last upload changes he made
									");";

				//File.AppendAllText(fileName, "\r\n\r\n" + _sql.CommandText);
				_sql.ExecuteNonQuery();
			}
			
			if (!checkTableExists("connections"))
			{
				_sql.CommandText = "CREATE TABLE " +
										"connections " +
									"(" +
										"id INTEGER PRIMARY KEY AUTOINCREMENT,								\r\n" +     //row ID
										"project_id INTEGER,												\r\n" +     //Id for project connected to server (projects.id)
										"log_id TEXT,														\r\n" +     //Id for entries in log file (autogenerated)
										"generate_default_tags TEXT,										\r\n" +		//1 for true 0 for false (Generate tags from path, file name and other parameters)
										"name TEXT,															\r\n" +     //Name of connection
										"host_name TEXT,													\r\n" +     //Name of host or IP
										"port INTEGER,														\r\n" +     //PORT number
										"connection_protocol TEXT,											\r\n" +     //Method of connection (FTP/SFTP/SCP/S3/WEBDAV)
										"authentication_method TEXT,										\r\n" +     //Method of authentication (password / key)
										"username TEXT,														\r\n" +     //Username
										"password TEXT,														\r\n" +     //Password
										"keyfile_path TEXT,													\r\n" +     //Path to keyfile
										"key_pass_phrase TEXT,												\r\n" +     //Passphrase for keyfile
										"use_stored_keys TEXT,												\r\n" +     //Use stored keys to attempt to connect to host
										"SshHostKeyFingerprint TEXT DEFAULT										" +
										" 'ssh-ed25519 256 00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00',	" +
																										"	\r\n" +		//SshHostKeyFingerprint
										"home_folder TEXT,													\r\n" +     //Home folder to connect to
										"ssh_settings TEXT,													\r\n" +     //Settings string for SSH
										"tunnel_settings TEXT,												\r\n" +     //Settings string for Tunneling
										"proxy_settings TEXT,												\r\n" +     //Settings string for Proxy
										"lastConnected TEXT,												\r\n" +     //Last connection time
										"last_error TEXT,													\r\n" +     //When did the user last pull an update from the server
										"last_update_finished TEXT,											\r\n" +     //When did the user last upload changes he made
										"ping_interval INTEGER												\r\n" +     //seconds between keepalive pings
									");";

				//File.AppendAllText(fileName, "\r\n\r\n" + _sql.CommandText);
				_sql.ExecuteNonQuery();
			}

			if (!checkTableExists("keys"))
			{
				_sql.CommandText = "CREATE TABLE " +
										"keys " +
									"(" +
										"id INTEGER PRIMARY KEY AUTOINCREMENT,								\r\n" +     //row ID
										"key_name TEXT,														\r\n" +     //
										"key_path TEXT,														\r\n" +     //
										"key_passphrase TEXT,												\r\n" +     //
										"key_active TEXT													\r\n" +     //Y = Yes, N = No
									");";

				//File.AppendAllText(fileName, "\r\n\r\n" + _sql.CommandText);
				_sql.ExecuteNonQuery();
			}



			return "+";
		}

	}
}
