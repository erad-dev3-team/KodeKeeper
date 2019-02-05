using KodeKeeper.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace KodeKeeper
{
	class c_UpdateQueryGenerator
	{
		public c_DBHandler _dbh { get; set; }

		char[] ca = new char[] { ',', ' ' };

		public string update()
		{
			StringBuilder sb = new StringBuilder();
			//TESTING!!!
			c_FileDataCollectionManager uh = new c_FileDataCollectionManager(_dbh);
			dataObject v = uh.getUpdate();
			foreach (c_DataUpdateObject c in v.GetAll())
			{
				Console.WriteLine($"-----{c.Name}-----");
				string columns = "";
				string values = "";
				foreach (DictionaryEntry o in c.Get())
				{
					if (o.Key.ToString() != "DATATYPE")
					{
						columns += $" `{o.Key}`, ";
						values += $" '{o.Value}', ";
					}
				}
				columns = columns.Trim(ca);
				values = values.Trim(ca);
				sb.Append($"INSERT OR REPLACE INTO  {c.Name} ({columns}) VALUES ({values});\r\n");
			}

			return sb.ToString();
		}
	}
}
