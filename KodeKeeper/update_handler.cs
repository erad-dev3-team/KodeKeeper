using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

// using LightJson;
// using LightJson.Serialization;

using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Serialization;

namespace KodeKeeper
{
	class update_handler
	{
		public SQLiteConnection Sqlc { get; set; }
		private c_DBHandler _dbh { get; set; }

		public update_handler(c_DBHandler dbh)
		{
			_dbh = dbh;
			Sqlc = _dbh.Sqlc;
		}

		public dataUpdateObject getUpdate()
		{
			dataUpdateObject d = new dataUpdateObject();
			string username = _dbh.getUserName();

			username = "WolfyD";
			string data = "";

			if (username != null)
			{
				data = createConnection("http://wpss.atoldavid.hu/api/get_data.php", $"username={username}");
			}

			if (data != "")
			{
				//TODO:::FIX DIS BS
				var obj = JObject.Parse(JObject.Parse(data)["Data to update:"].Children()[1].ToString());
				
				foreach (var v in obj)
				{
					d.Add(v.Key, v.Value.ToString());
				}
			}

			return d;
		}

		public dataUpdateObject checkUpdate()
		{
			dataUpdateObject d = new dataUpdateObject();
			string username = _dbh.getUserName();

			username = "WolfyD";
			string data = "";

			if(username != null)
			{
				data = createConnection("http://wpss.atoldavid.hu/api/check_update.php", $"username={username}");
			}


			if (data != "")
			{
				/*
				var jr = JsonReader.Parse(data);
				foreach(var v in (((JsonObject)jr)["Count of outdated data"]).AsJsonObject)
				{
					
					d.Add(v.Key, v.Value);
				}
				*/
			}

			return d;
		}

		public string createConnection(string url, string data)
		{
			System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
			FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
			string version = fvi.FileVersion;


			HttpWebRequest wreq = (HttpWebRequest)WebRequest.Create(url);
			byte[] content = Encoding.UTF8.GetBytes(data);
			wreq.Method			= "POST";
			wreq.UserAgent		= "WolfPaw KodeKeeper v" + version;
			wreq.ContentType	= "application/x-www-form-urlencoded";
			wreq.ContentLength = content.Length;
			using(Stream s = wreq.GetRequestStream())
			{
				s.Write(content, 0, content.Length);
			}

			HttpWebResponse wresp = (HttpWebResponse)wreq.GetResponse();

			string ret = "";

			using (StreamReader s = new StreamReader(wresp.GetResponseStream()))
			{
				ret += (s.ReadToEnd());
			}

			return ret;
		}
	}
}
