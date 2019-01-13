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

		public string createTables()
		{
			if (!checkConnection()) { return "E:ConnectionError"; }

			if (!checkTableExists("projects"))
			{
				_sql.CommandText = "CREATE TABLE " +
										"projects " +
									"(" +
											"id INTEGER PRIMARY KEY AUTOINCREMENT,				" +		//row ID
											"name TEXT,											" +		//Project name
											"number_of_files INTEGER,							" +		//Number of files in the project
											"added TEXT,										" +		//Date the project was added
											"modified TEXT,										" +     //Date the project was modified
											"comment TEXT										" +     //comment
									");" +

									"CREATE INDEX IF NOT EXISTS project_id_index ON projects(id);";
				_sql.ExecuteNonQuery();
			}
			
			if (!checkTableExists("images"))
			{
				_sql.CommandText = "CREATE TABLE " +
										"images " +
									"(" +
										"id INTEGER PRIMARY KEY AUTOINCREMENT,				\r\n" +		//row ID
										"name TEXT,											\r\n" +		//Image file name
										"size INTEGER,										\r\n" +		//Image Size in pixels
										"for TEXT,											\r\n" +		//What the image is used for
										"image TEXT											\r\n" +		//Image data in bytes
										"comment TEXT										\r\n" +     //Comment
									");" +

									"CREATE INDEX IF NOT EXISTS images_id_index ON images(id);" +
									"CREATE INDEX IF NOT EXISTS images_name_index ON images(name);";

				_sql.ExecuteNonQuery();

				_sql.CommandText = auto_add_data.autoAddImages();

				_sql.ExecuteNonQuery();
			}

			if (!checkTableExists("filetypes"))
			{
				_sql.CommandText = "CREATE TABLE " +
										"filetypes " +
									"(" +
										"id INTEGER PRIMARY KEY AUTOINCREMENT,				\r\n" +     //row ID
										"type TEXT,											\r\n" +     //File type
										"description TEXT,									\r\n" +     //File type description
										"mime_type TEXT,									\r\n" +     //Mime type
										"def_image_id INTEGER,								\r\n" +     //Default image index
										"comment TEXT,										\r\n" +     //comment
										"FOREIGN KEY(def_image_id) REFERENCES images(id)	\r\n" +     //
									");" +

									"CREATE INDEX IF NOT EXISTS filetypes_id_index ON filetypes(id);" +
									"CREATE INDEX IF NOT EXISTS filetypes_type_index ON filetypes(type);";

				_sql.ExecuteNonQuery();

				_sql.CommandText = auto_add_data.autoAddFileTypes();

				_sql.ExecuteNonQuery();
			}

			if (!checkTableExists("files"))
			{
				_sql.CommandText = "CREATE TABLE " +
										"files " +
									"(" +
										"id INTEGER PRIMARY KEY AUTOINCREMENT,				\r\n" +		//row ID
										"project_id INTEGER,								\r\n" +		//ID of project under which the file is
										"file_name TEXT,									\r\n" +		//File Name (eg: cr_new.php)
										"location TEXT,										\r\n" +		//File Location (eg: /usr/local/dpdweblabel/cr/)
										"file_type_id INTEGER,								\r\n" +		//ID of filetype
										"file_version INTEGER,								\r\n" +		//Version of file (eg: 2)
										"in_use INTEGER,									\r\n" +		//Bool value, 1 if file is in use 0 otherwise (eg: 1)
										"parameters TEXT,									\r\n" +		//Input parameters for file (eg: parcel_number address_id)
										"file_contents TEXT,								\r\n" +		//Contents of file. B64 encoded
										"file_size INTEGER,									\r\n" +		//File size in bytes (eg: 897)
										"notes TEXT,										\r\n" +		//Notes on the file, what it's for, how it works anything else...
										"rights INTEGER,									\r\n" +		//File Rights (eg: 766)
										"owner TEXT,										\r\n" +		//File Owner (eg: root)
										"\"group\" TEXT,									\r\n" +		//File Group (eg: developers)
										"added TEXT,										\r\n" +		//File added date (eg: 2018-05-11)
										"modified TEXT,										\r\n" +		//File modified date (eg: 2018-07-27)
										"comment TEXT,										\r\n" +		//Any additional comment
										"FOREIGN KEY(project_id) REFERENCES projects(id),	\r\n" +		//Foreign key for project_id
										"FOREIGN KEY(file_type_id) REFERENCES filetypes(id)	\r\n" +		//Foreign key for file_type_id
									");" +

									"CREATE INDEX IF NOT EXISTS files_id_index ON files(id);			\r\n" +
									"CREATE INDEX IF NOT EXISTS files_name_index ON files(file_name);	\r\n" +
									"CREATE INDEX IF NOT EXISTS files_notes_index ON files(notes);		\r\n";
				_sql.ExecuteNonQuery();

			}

			if (!checkTableExists("links"))
			{
				_sql.CommandText = "CREATE TABLE " +
										"links " +
									"(" +
										"id INTEGER PRIMARY KEY AUTOINCREMENT,				\r\n" +     //row ID
										"name INTEGER,										\r\n" +		//
										"file_from INTEGER,									\r\n" +		//
										"file_to INTEGER,									\r\n" +		//
										"is_data_sent INTEGER,								\r\n" +		//
										"data_sent TEXT,									\r\n" +		//
										"is_data_returned INTEGER,							\r\n" +		//
										"data_returned TEXT,								\r\n" +		//
										"comment TEXT,										\r\n" +		//
										"FOREIGN KEY(file_from) REFERENCES files(id),		\r\n" +		//
										"FOREIGN KEY(file_to) REFERENCES files(id)			\r\n" +		//
									");" +

									"CREATE INDEX IF NOT EXISTS links_id_index ON links(id);			\r\n" +
									"CREATE INDEX IF NOT EXISTS links_name_index ON links(name);		\r\n" +
									"CREATE INDEX IF NOT EXISTS links_from_index ON links(file_from);	\r\n" +
									"CREATE INDEX IF NOT EXISTS links_to_index ON links(file_to);		\r\n";
				_sql.ExecuteNonQuery();
			}

			if (!checkTableExists("tags_list"))
			{
				_sql.CommandText = "CREATE TABLE " +
										"tags_list " +
									"(" +
										"id INTEGER PRIMARY KEY AUTOINCREMENT,				\r\n" +     //row ID
										"tag TEXT,											\r\n" +		//
										"description TEXT,									\r\n" +		//
										"comment TEXT										\r\n" +		//
									");" +

									"CREATE INDEX IF NOT EXISTS tags_list_id_index ON tags_list(id);					\r\n" +
									"CREATE INDEX IF NOT EXISTS tags_list_tag_index ON tags_list(tag);					\r\n" +
									"CREATE INDEX IF NOT EXISTS tags_list_description_index ON tags_list(description);	\r\n";
				_sql.ExecuteNonQuery();
			}

			if (!checkTableExists("tags"))
			{
				_sql.CommandText = "CREATE TABLE " +
										"tags " +
									"(" +
										"id INTEGER PRIMARY KEY AUTOINCREMENT,				\r\n" +     //row ID
										"tag_id INTEGER,									\r\n" +		//
										"file_id INTEGER,									\r\n" +		//
										"comment TEXT,										\r\n" +		//
										"FOREIGN KEY(tag_id) REFERENCES tags_list(id),		\r\n" +		//
										"FOREIGN KEY(file_id) REFERENCES files(id)			\r\n" +		//
									");" +

									"CREATE INDEX IF NOT EXISTS tags_id_index ON tags(id);";
				_sql.ExecuteNonQuery();
			}



			return "+";
		}

	}
}
