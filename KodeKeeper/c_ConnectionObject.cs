using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinSCP;

namespace KodeKeeper
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
}
