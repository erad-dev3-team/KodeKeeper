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
	class c_FileDataCollectionManager
	{
		public SQLiteConnection Sqlc { get; set; }
		private c_DBHandler _dbh { get; set; }

		public c_FileDataCollectionManager(c_DBHandler dbh)
		{
			_dbh = dbh;
			Sqlc = _dbh.Sqlc;
		}

		public dataObject getUpdate()
		{
			dataObject dObj = new dataObject();
			
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
				var obj = JObject.Parse(data)["Data to update:"].Children();
				
				foreach (JToken v in obj)
				{
					var o = v.First;
					c_DataUpdateObject d = new c_DataUpdateObject();
					d.Name = o.First().First().ToString();
					foreach (var vv in o.Children())
					{
						d.Add(vv.Path.Split('.').Last(), vv.First().ToString());
					}
					dObj.Add(d);
				}
			}

			return dObj;
		}

		public c_DataUpdateObject checkUpdate()
		{
			c_DataUpdateObject d = new c_DataUpdateObject();
			string username = _dbh.getUserName();

			username = "WolfyD";
			string data = "";

			if(username != null)
			{
				data = createConnection("http://wpss.atoldavid.hu/api/check_update.php", $"username={username}");
			}


			if (data != "")
			{
				var jr = JObject.Parse(data)["Count of outdated data"].Children();
				d.Name = "Updatable Data Count";
				foreach (JToken v in jr)
				{
					d.Add(v.Path.Split('.').Last(), v.First.ToString());
				}
			}

			return d;
		}

		public string createConnection(string url, string data)
		{
			System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
			FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
			string version = fvi.FileVersion;
			
			HttpWebRequest wreq = (HttpWebRequest)WebRequest.Create(url);
			byte[] content		= Encoding.UTF8.GetBytes(data);
			wreq.Method			= "POST";
			wreq.UserAgent		= "WolfPaw KodeKeeper v" + version;
			wreq.ContentType	= "application/x-www-form-urlencoded";
			wreq.ContentLength	= content.Length;
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
