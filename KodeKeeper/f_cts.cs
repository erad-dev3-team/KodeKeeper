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
			//TODO: Load connections from DB


			//Connect();
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
				SshHostKeyFingerprint = "ssh-ed25519 256 00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00"
			};

			sessionOptions.AddRawSettings("PingIntervalSecs", "10");
			sessionOptions.AddRawSettings("TcpNoDelay", "1");

			session = new Session();
			try
			{
				session.Open(sessionOptions);
			}
			catch(Exception ex)
			{
				if(sessionOptions.SshHostKeyFingerprint == "ssh-ed25519 256 00:00:00:00:00:00:00:00:00:00:00:00:00:00:00:00")
				{
					string key = ex.Message.Substring(ex.Message.IndexOf("!") + 1);
					key = key.Substring(key.IndexOf(":") + 1);
					key = key.Substring(0, key.IndexOf("."));
					if(key.Contains("Host key fingerprint is"))
					{
						key = key.Substring(key.IndexOf("Host key fingerprint is") + "Host key fingerprint is".Length);
					}
					key = key.Trim();
					sessionOptions.SshHostKeyFingerprint = key;
					session.Open(sessionOptions);
				}
			}

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
				//listView1.Items.Add(lvi);
			}
		}

		private void cb_MoreInfo_CheckedChanged(object sender, EventArgs e)
		{
			if (cb_MoreInfo.Checked)
			{
				Height = btn_Logs.Top + btn_Logs.Height + (Height - (gb_ServerSpecs.Height + gb_ServerSpecs.Top)) + 50;
			}
			else
			{
				Height = lbl_ProjectName.Top + lbl_ProjectName.Height + (Height - (gb_ServerSpecs.Height + gb_ServerSpecs.Top)) + 50;
			}
		}

		private void btn_Close_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_Edit_Click(object sender, EventArgs e)
		{
			f_EditServer fe = new f_EditServer();
			///SEND current data
			fe.ShowDialog();
		}

		private void btn_Add_Click(object sender, EventArgs e)
		{
			f_EditServer fe = new f_EditServer();
			fe.ShowDialog();
		}
	}
}
