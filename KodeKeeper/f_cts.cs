using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KodeKeeper
{
	public partial class f_cts : Form
	{
		public c_DBHandler Dbh { get; set; }
		connection tag = null;

		public f_cts()
		{
			InitializeComponent();

			Load += F_cts_Load;
		}

		private void F_cts_Load(object sender, EventArgs e)
		{
			//TODO: Load connections from DB
			List<connection> conn = Dbh.getConnections();
			foreach(connection c in conn)
			{
				cb_Servers.Add(c.Name,c);
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
			f_EditConnection fe = new f_EditConnection();
			///SEND current data
			fe.ShowDialog();
		}

		private void btn_Add_Click(object sender, EventArgs e)
		{
			f_EditConnection fe = new f_EditConnection();
			fe.ShowDialog();
		}

		private void cb_Servers_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				Text = "Connect to Server - " + cb_Servers.Text;
				tag = (connection)cb_Servers.getTag();

				if (tag != null)
				{
					if (tag.Host != "" && tag.Username != "" &&
						((tag.Password != "" && tag.Authentication_method == "pwd") ||
						(tag.Key_pass_phrase != "" && tag.Keyfile_path != "" && File.Exists(tag.Keyfile_path) && tag.Authentication_method == "key") ||
						tag.Use_stored_keys == "Y"))
					{
						btn_Connect.Enabled = true;
					}
					else
					{
						btn_Connect.Enabled = false;
					}

					lbl_HostName.Text = tag.Host;
					lbl_ProjectName.Text = Dbh.getProjectName(tag.Project_id);
					lbl_Username.Text = tag.Username;
					lbl_Auth.Text = tag.Authentication_method;
					lbl_HomeDir.Text = tag.Home_folder;
					lbl_Key.Text = tag.Keyfile_path;
					lbl_LastConnected.Text = tag.LastConnected;
					lbl_LastUpdate.Text = tag.Last_update_finished;
					lbl_Password.Text = string.Concat(tag.Password.ToCharArray().Select(x => '•').ToArray());
					lbl_Port.Text = tag.Port + "";
					lbl_Protocol.Text = tag.Connection_protocol;
				}
				else
				{
					btn_Connect.Enabled = false;
				}
			}
			catch
			{
				
			}
		}

		private void btn_Connect_Click(object sender, EventArgs e)
		{
			connection_handler ch = new connection_handler(Dbh,tag);
			int project_id = ch.Connect();
			List<fileDataObject> lst = ch.getData();

			foreach(fileDataObject fo in lst)
			{
				fo.ProjectId = project_id;
				fo.Project = Dbh.getProjectName(fo.ProjectId);
				fo.FileTypeId = Dbh.getFileTypeId(fo.FileTypeName);
				object[] img = Dbh.getImageForType(fo.FileTypeName);
				fo.FileImageId = int.Parse(img[0].ToString());
				fo.FileImageName = img[1].ToString();
				fo.FileImage = img[2].ToString();
			}
			
		}
	}

	public class myComboBox : ComboBox
	{
		myObject SelectedItem = null;
		List<myObject> Items = new List<myObject>();
		public void Add(string str, object Tag)
		{
			base.Items.Add(new myObject { Text = str, Tag = Tag });
			Items.Add(new myObject { Text = str, Tag = Tag });
		}

		public override string ToString()
		{
			return base.Text.ToString();
		}

		protected override void OnDropDown(EventArgs e)
		{
			base.OnDropDown(e);
		}

		protected override void OnSelectionChangeCommitted(EventArgs e)
		{
			base.OnSelectionChangeCommitted(e);
			SelectedItem = Items[SelectedIndex];
		}

		public object getTag()
		{
			return SelectedItem.Tag;
		}
	}

	public class myObject : Object
	{
		public  string Text { get; set; }
		public  Object Tag { get; set; }

		public override string ToString()
		{
			return Text.ToString();
		}
	}
}
