using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KodeKeeper
{
	public partial class f_AddFile : Form
	{
		List<CheckBox> rightCheckboxes = new List<CheckBox>();

		public f_AddFile()
		{
			InitializeComponent();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void f_AddFile_Load(object sender, EventArgs e)
		{
			rightCheckboxes.Add(cb_Special_1);
			rightCheckboxes.Add(cb_Special_2);
			rightCheckboxes.Add(cb_Special_3);
			rightCheckboxes.Add(cb_Owner_1);
			rightCheckboxes.Add(cb_Owner_2);
			rightCheckboxes.Add(cb_Owner_3);
			rightCheckboxes.Add(cb_Group_1);
			rightCheckboxes.Add(cb_Group_2);
			rightCheckboxes.Add(cb_Group_3);
			rightCheckboxes.Add(cb_Other_1);
			rightCheckboxes.Add(cb_Other_2);
			rightCheckboxes.Add(cb_Other_3);
		}

		private void p_RightSetup_Paint(object sender, PaintEventArgs e)
		{
			

		}

		private void cb_Other_CheckedChanged(object sender, EventArgs e)
		{
			int s = 0;
			int o = 0;
			int g = 0;
			int x = 0;


			foreach (CheckBox c in rightCheckboxes)
			{
				if (c.Checked)
				{
					string t = c.Tag.ToString()[0].ToString();
					int i = Convert.ToInt32(c.Tag.ToString()[1].ToString());
					if (t == "S")
					{
						s += i;
					}
					else if (t == "O")
					{
						o += i;
					}
					else if (t == "G")
					{
						g += i;
					}
					else if (t == "X")
					{
						x += i;
					}
				}
			}

			mtb_Rights.Text = $"{s} {o} {g} {x}";

		}

		private void btn_RightsSetup_Click(object sender, EventArgs e)
		{
			p_RightSetup.Visible = !p_RightSetup.Visible;
			if (p_RightSetup.Visible)
			{
				setRights();
			}
		}

		private void setRights()
		{
			string s = mtb_Rights.Text;
			string s1 = s[0] + "";
			string s2 = s[2] + "";
			string s3 = s[4] + "";
			string s4 = s[6] + "";

			int.TryParse(s1, out int i1);
			int.TryParse(s2, out int i2);
			int.TryParse(s3, out int i3);
			int.TryParse(s4, out int i4);

			int[] ia1 = new int[] { 0, 0, 0 };
			int[] ia2 = new int[] { 0, 0, 0 };
			int[] ia3 = new int[] { 0, 0, 0 };
			int[] ia4 = new int[] { 0, 0, 0 };

			ia1[2] = (i1 / 4) * 1; i1 %= 4;
			ia1[1] = (i1 / 2) * 1; i1 %= 2;
			ia1[0] = (i1 / 1) * 1;

			ia2[2] = (i2 / 4) * 1; i2 %= 4;
			ia2[1] = (i2 / 2) * 1; i2 %= 2;
			ia2[0] = (i2 / 1) * 1;

			ia3[2] = (i3 / 4) * 1; i3 %= 4;
			ia3[1] = (i3 / 2) * 1; i3 %= 2;
			ia3[0] = (i3 / 1) * 1;

			ia4[2] = (i4 / 4) * 1; i4 %= 4;
			ia4[1] = (i4 / 2) * 1; i4 %= 2;
			ia4[0] = (i4 / 1) * 1;

			cb_Special_1.Checked = ia1[0] > 0;
			cb_Special_2.Checked = ia1[1] > 0;
			cb_Special_3.Checked = ia1[2] > 0;

			cb_Owner_1.Checked = ia2[0] > 0;
			cb_Owner_2.Checked = ia2[1] > 0;
			cb_Owner_3.Checked = ia2[2] > 0;

			cb_Group_1.Checked = ia3[0] > 0;
			cb_Group_2.Checked = ia3[1] > 0;
			cb_Group_3.Checked = ia3[2] > 0;

			cb_Other_1.Checked = ia4[0] > 0;
			cb_Other_2.Checked = ia4[1] > 0;
			cb_Other_3.Checked = ia4[2] > 0;
		}

		private void mtb_Rights_Enter(object sender, EventArgs e)
		{
			if (mtb_Rights.Text == "0 0 0 0") { mtb_Rights.Text = ""; }
		}

		private void mtb_Rights_Leave(object sender, EventArgs e)
		{
			if (mtb_Rights.Text.Trim() == "") { mtb_Rights.Text = "0 0 0 0"; }
		}
	}
}
