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

		public f_Add_Project(bool edit = false, int project_id = -1)
		{
			InitializeComponent();

			if (edit)
			{
				Width = groupBox1.Right + 10;
				tb_ProjectName.Text = Dbh.getProjectName(project_id);
				Text = "Edit Project - " + tb_ProjectName.Text;
				//TODO: Edit existing project
			}
		}
	}
}
