using KodeKeeper.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinSCP;


namespace KodeKeeper
{
	class c_ScpConnectionManager
	{
		public	c_DBHandler	Dbh					{ get; set; }
		public	Protocol	_protocol		=	Protocol.Ftp;
		private	c_LogDataObject		_logData		=	new c_LogDataObject();
		public	string		_host			=	"127.0.0.1";
		public	string		_username		=	"username";
		public	string		_password		=	"password";
		public	string		_fingerprint	=	"";
		public	string		_keyPath		=	"";
		public	Session		_session;
		public	c_ConnectionObject	_connection;

		public c_ScpConnectionManager(c_DBHandler _dbh, c_ConnectionObject _Conn)
		{
			Dbh = _dbh;
			_connection = _Conn;
			if(_connection != null)
			{
				_protocol =		_connection.protocol();
				_host =			_connection.Host;
				_username =		_connection.Username;
				_password =		_connection.Password;
				_fingerprint =	_connection.SshHostKeyFingerprint;
				_keyPath =		_connection.Keyfile_path;
			}
		}

		public int Connect()
		{

			// Set up session options
			SessionOptions sessionOptions = new SessionOptions
			{
				Protocol = _protocol,
				HostName = _host,
				UserName = _username,
				Password = _password,
				SshHostKeyFingerprint = _fingerprint
			};

			if(_keyPath != "" && File.Exists(_keyPath))
			{
				sessionOptions.SshPrivateKeyPath = _keyPath;
				sessionOptions.PrivateKeyPassphrase = _password;
				sessionOptions.Password = null;
			}

			sessionOptions.AddRawSettings("PingIntervalSecs", "10");
			sessionOptions.AddRawSettings("TcpNoDelay", "1");

			_session = new Session();
			try
			{
				_session.Open(sessionOptions);
			}
			catch (Exception ex)
			{
				string key = ex.Message.Substring(ex.Message.IndexOf("!") + 1);
				key = key.Substring(key.IndexOf(":") + 1);
				key = key.Substring(0, key.IndexOf("."));
				if (key.Contains("Host key fingerprint is"))
				{
					key = key.Substring(key.IndexOf("Host key fingerprint is") + "Host key fingerprint is".Length);
				}
				key = key.Trim();

				if (sessionOptions.SshHostKeyFingerprint == "ssh-ed25519 256 00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00")
				{
					sessionOptions.SshHostKeyFingerprint = key;
					Dbh.updateSshFingerPrint(_connection.Id, key);
					_session.Open(sessionOptions);
				}
				else
				{
					var msg = MessageBox.Show("The SSH Host Fingerprint of the device you are connecting to, \r\n" +
											"doesn't match the original Fingerprint saved in the database.\r\n\r\n" +
											"Do you wish to accept the new Fingerprint \r\n" +
											"and update the one stored in the database?",
											"Fingerprint Mismatch",
											MessageBoxButtons.YesNo,
											MessageBoxIcon.Warning);

					if (msg == DialogResult.Yes)
					{
						Dbh.updateSshFingerPrint(_connection.Id, key);
					}
					else
					{
						c_LogManager.add(_connection.Log_id, _connection.Project_id, _logData);
						return -1;
					}

				}
			}

			return _connection.Project_id;
		}

		public List<c_FileDataObject> getData()
		{
			List<c_FileDataObject> files = new List<c_FileDataObject>();
			IEnumerable<RemoteFileInfo> v = _session.EnumerateRemoteFiles("/var/www/html/ps/wpss", "*", EnumerationOptions.AllDirectories);
			int i = 0;
			foreach (RemoteFileInfo finfo in v)
			{
				c_FileDataObject fo = new c_FileDataObject();

				Console.WriteLine(i.ToString().PadLeft(3,'0') + ": " + finfo.Name);

				fo.FileName = finfo.Name;
				fo.FilePath = finfo.FullName.Substring(0, finfo.FullName.LastIndexOf(finfo.FullName.Contains("/") ? "/" : "\\"));
				fo.FileTypeName = (finfo.IsDirectory ? "dir" :  finfo.Name.Substring(finfo.Name.LastIndexOf(".") + 1));
				fo.Modified = finfo.LastWriteTime;
				fo.Group = finfo.Group;
				fo.Owner = finfo.Owner;
				
				fo.Rights = finfo.FilePermissions.Octal.ToString().PadLeft(4, '0');
				fo.FileSize = finfo.Length;
				
				
				if (fo.FileSize < 1024 * 512)
				{
					string temp = Path.GetTempPath();

					if (_session.GetFiles(finfo.FullName, temp + "\\" + fo.FileName).IsSuccess)
					{
						Console.WriteLine("\t→ File saved to: [ " + temp + "\\" + fo.FileName + " ]...");
						fo.FileContents = File.ReadAllText(temp + "\\" + fo.FileName);
						Console.WriteLine("\t\t→ File contents saved to object...");
						try
						{
							File.Delete(temp + "\\" + fo.FileName);
							Console.WriteLine("\t\t\t→ File delted...");
						}
						catch(Exception ex)
						{
							Console.WriteLine("\t\t\t→ File could not be deleted (" + ex.Message + ")");
						}

					}
					else
					{
						Console.WriteLine("\t→ File save unsuccessful: [ " + temp + "\\" + fo.FileName + " ]...");
					}
				}

				files.Add(fo);
				fo = null;
				GC.Collect();
			}

			return files;
		}


	}
}
