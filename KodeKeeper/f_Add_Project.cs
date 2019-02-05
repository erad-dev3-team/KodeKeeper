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
	public partial class f_Add_Project : Form
	{
		public c_DBHandler Dbh { get; set; }
		private bool _edit = false;

		public f_Add_Project(bool edit = false, int project_id = -1)
		{
			InitializeComponent();

			_edit = edit;

			if (edit)
			{
				LoadProjectData(project_id);
			}
		}

		public void LoadProjectData(int pid)
		{
			Width = groupBox1.Right + 10;
			tb_ProjectName.Text = Dbh.getProjectName(pid);
			Text = "Edit Project - " + tb_ProjectName.Text;
			//TODO: Edit existing project
		}

		private void btn_DeleteProject_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show($"You are about to delete the project [{tb_ProjectName.Text}]\r\nalong with all of the files under it.\r\nAre you sure you wish to continue?\r\n(This action cannot be undone.)", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				//TODO: DeleteProject!!
			}
		}

		private void btn_SaveProject_Click(object sender, EventArgs e)
		{
			if (_edit)
			{

			}
			else
			{

			}
		}
	}
}
