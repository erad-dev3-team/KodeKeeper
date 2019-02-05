using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinSCP;

namespace KodeKeeper.Objects
{
	public class c_ConnectionObject
	{
		public	int		Id						{ get; set; } = -1;
		public	int		Log_id					{ get; set; }
		public	int		Project_id				{ get; set; }
		public	string	Name					{ get; set; }
		public	string	Host					{ get; set; }
		public	string	Username				{ get; set; }
		public	string	Password				{ get; set; }
		public	int		Port					{ get; set; }
		public	string	Connection_protocol		{ get; set; }
		public	string	Authentication_method	{ get; set; }
		public	string	Keyfile_path			{ get; set; }
		public	string	Key_pass_phrase			{ get; set; }
		public	string	Use_stored_keys			{ get; set; }
		public	string	SshHostKeyFingerprint	{ get; set; }
		public	string	Home_folder				{ get; set; }
		public	string	Proxy_Settings			{ get; set; }
		public	string	Ssh_Settings			{ get; set; }
		public	string	Tunnel_Settings			{ get; set; }
		public	int		Ping_interval			{ get; set; }
		public	string	Last_error				{ get; set; }
		public	string	LastConnected			{ get; set; }
		public	string	Last_update_finished	{ get; set; }

		public Protocol protocol()
		{
			switch (Connection_protocol)
			{
				case "ftp":
					return Protocol.Ftp;
				case "sftp":
					return Protocol.Sftp;
				case "s3":
					return Protocol.S3;
				case "scp":
					return Protocol.Scp;
				case "webdav":
					return Protocol.Webdav;
			}

			return 0;
		}
	}

	public class c_DataUpdateObject
	{
		Hashtable values = new Hashtable();
		public string Name { get; set; } = "";

		public bool Add(string name, string value)
		{
			try
			{
				values.Add(name, addValue(value));
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				return false;
			}
		}

		private string addName(string name)
		{
			if (name.Contains("_"))
			{
				return name.Substring(name.IndexOf("_") + 1);
			}
			else { return name; }
		}

		private string addValue(string value)
		{
			if (int.TryParse(value, out int i))
			{
				return i.ToString();
			}
			else
			{
				return value;
			}
		}

		public Hashtable Get()
		{
			return values;
		}

		public string Get(String name)
		{
			return values[name].ToString();
		}
	}

	class dataObject
	{
		List<c_DataUpdateObject> data = new List<c_DataUpdateObject>();

		public void Add(c_DataUpdateObject d)
		{
			data.Add(d);
		}

		public List<c_DataUpdateObject> GetAll()
		{
			return data;
		}

		public c_DataUpdateObject[] get(string Name)
		{
			return data.Where(x => x.Name == Name).Select(x => x).ToArray();
		}

	}

	class c_FileDataObject
	{
		public int Id = -1;                 //Generated Locally
		public int FileUID = -1;                    //Generated on the server and queried after upload
		public int ProjectId = -1;                  //Local
		public string Project = "";                 //Local (by id)
		public string FileName = "";                    //Local
		public string Location = "";                    //Location of file on server
		public string md5ID = "";                   //Generated Locally (Project_id, File_name, File_path, File_type_id)
		public string FilePath = "";                    //Path of file attached
		public int FileTypeId = -1;                 //Local
		public string FileTypeName = "";                    //Local (by id)
		public int FileImageId = -1;                    //Local (by name)
		public string FileImageName = "";                   //Local
		public string FileImage = "";                   //Local
		public string FileVersion = "";                 //Local
		public bool InUse = false;              //Local
		public string Parameters = "";                  //Local
		public string FileContents = "";                    //Local
		public long FileSize = -1;                  //Generated Locally (from file)
		public long UploadedBy = -1;                    //Local (by name)
		public string UploadUserName = "";                  //Local
		public string Notes = "";                   //Local
		public string Rights = "";                  //Local
		public string Owner = "";                   //Local
		public string Group = "";                   //Local
		public DateTime Created = default(DateTime);    //Local
		public DateTime Modified = default(DateTime);   //Local
		public DateTime UploadDateTime = default(DateTime); //Generated Locally
		public string Comment = "";                 //Local
		public List<c_TagObject> Tags = new List<c_TagObject>();        //List of tags

		public c_FileDataObject()
		{

		}
	}

	public class c_LogDataObject
	{
		public string name { get; set; }
		public string module { get; set; }
		public bool error { get; set; }
		public Exception exception { get; set; }
		public string exceptionType { get; set; }
		public string message { get; set; }
		public int severity { get; set; }
		public object otherData { get; set; }

		public string toString(returnType type = returnType.plain)
		{
			switch (type)
			{
				case returnType.plain:
					break;
				case returnType.json:
					break;
				case returnType.xml:
					break;
				case returnType.blocked:
					break;
				case returnType.newlines:
					break;
			}

			return "";
		}


	}

	class c_TagObject
	{
		public int tag_id;
		public string tag_name;
		public int tag_type_id;
		public string tag_type;
	}

	public enum returnType
	{
		plain,
		json,
		xml,
		blocked,
		newlines
	}
}
