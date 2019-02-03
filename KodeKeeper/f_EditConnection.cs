using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KodeKeeper
{
	public partial class f_EditConnection : Form
	{
		public c_DBHandler Dbh { get; set; }
		private string _proxy_settings = "";
		private string _ssh_settings = "";
		private string _tunnel_settings = "";

		public f_EditConnection(bool edit = false, connection conn = null)
		{
			InitializeComponent();

			if(edit && conn != null)
			{
				loadConnectionData(conn);
			}
			else
			{
				tb_ConnectionName.Text = "New Connection";
				cb_Protocol.SelectedIndex = 0;
				cb_Authentication.SelectedIndex = 0;
			}
		}

		private void loadConnectionData(connection conn)
		{

		}

		private void btn_SaveConnection_Click(object sender, EventArgs e) { save(); }
		
		private void btn_Cancel_Click(object sender, EventArgs e) { close(); }

		public void save()
		{
			connection c = new connection() {
				Name					=	tb_ConnectionName.Text,
				Connection_protocol		=	cb_Protocol.Text,
				Host					=	tb_HostName.Text,
				Password				=	tb_Password.Text,
				Key_pass_phrase			=	tb_Password.Text,
				Keyfile_path			=	tb_KeyFile.Text,
				Use_stored_keys			=	cb_Authentication.SelectedIndex == 2 ? "T" : "F",
				Authentication_method	=	cb_Authentication.Text,
				Home_folder				=	tb_HomeFolder.Text,
				Ping_interval			=	(int)num_PingInterval.Value,
				Username				=	tb_Username.Text,
				Port					=	(int)num_Port.Value,
				Proxy_Settings			=	_proxy_settings,
				Ssh_Settings			=	_ssh_settings,
				Tunnel_Settings			=	_tunnel_settings
			};

			Dbh.saveConnection(c);
			close();
		}

		public void close()
		{
			this.Close();
		}

		private void f_EditConnection_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.S && (e.Modifiers == Keys.LControlKey || e.Modifiers == Keys.RControlKey))
			{
				save();
			}
			else if (e.KeyCode == Keys.Escape)
			{
				close();
			}
		}

		private void num_Port_ValueChanged(object sender, EventArgs e)
		{
			switch (cb_Protocol.SelectedIndex)
			{
				case 0:
					num_Port.Value = 21;
					break;

				case 1:
				case 2:
					num_Port.Value = 22;
					break;

				case 3:
				case 4:
					num_Port.Value = 443;
					break;

			}
		}

		private void cb_Authentication_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cb_Authentication.SelectedIndex == 0)
			{
				tb_KeyFile.Enabled = false;
				btn_BrowseKey.Enabled = false;
				lbl_Pwd.Text = "Password: ";
				tb_Password.Enabled = true;
				btn_ViewPass.Enabled = true;
			}
			else if (cb_Authentication.SelectedIndex == 1)
			{
				tb_KeyFile.Enabled = true;
				btn_BrowseKey.Enabled = true;
				lbl_Pwd.Text = "Key Passphrase: ";
				tb_Password.Enabled = true;
				btn_ViewPass.Enabled = true;
			}
			else
			{
				tb_KeyFile.Enabled = false;
				btn_BrowseKey.Enabled = false;
				lbl_Pwd.Text = "Key Passphrase: ";
				tb_Password.Enabled = false;
				btn_ViewPass.Enabled = false;
			}
		}
	}
}
