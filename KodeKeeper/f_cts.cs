using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WinSCP;

namespace KodeKeeper
{
	public partial class f_cts : Form
	{
		private Protocol _protocol = Protocol.Ftp;
		private string _host = "127.0.0.1";
		private string _username = "username";
		private string _password = "password";
		private string _fingerprint = "";
		private string _keyPath = "";
		private Session session;


		public f_cts()
		{
			InitializeComponent();

			Load += F_cts_Load;
		}

		private void F_cts_Load(object sender, EventArgs e)
		{
			Connect();
		}

		public void Connect()
		{
			// Set up session options
			SessionOptions sessionOptions = new SessionOptions
			{
				Protocol = Protocol.Sftp,
				HostName = "atoldavid.hu",
				UserName = "marci",
				Password = "123qwe",
				SshHostKeyFingerprint = "ssh-ed25519 256 3kKh4vM8Mdmzvbpg/q/25013nk/QpqgQHBdVEJqTBwU="
			};

			sessionOptions.AddRawSettings("PingIntervalSecs", "10");
			sessionOptions.AddRawSettings("TcpNoDelay", "1");

			session = new Session();
			session.Open(sessionOptions);

			if (session.Opened)
			{
				getData();
			}
		}

		public void getData()
		{

			IEnumerable<RemoteFileInfo> v = session.EnumerateRemoteFiles("/var/www/html/ps/", "*", EnumerationOptions.AllDirectories);
			foreach (RemoteFileInfo finfo in v)
			{
				ListViewItem lvi = new ListViewItem();
				lvi.Text = finfo.FullName;
				lvi.SubItems.Add(finfo.Length + "bytes");
				lvi.SubItems.Add(finfo.Owner);
				lvi.SubItems.Add(finfo.Group);
				lvi.SubItems.Add(finfo.FilePermissions.Octal.ToString());
				listView1.Items.Add(lvi);
			}
		}
	}
}
