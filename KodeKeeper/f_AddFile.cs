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
		string[] _stringTypes = new string[] { "txt", "html", "htm", "lst" };
		string[] _archiveTypes = new string[] { "zip", "rar", "7z", "tar", "tar.gz" };
		List<fileDataObject> _files = new List<fileDataObject>();

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

		public void showDropPoints()
		{
			p_DragDrop_Comment.Dock = DockStyle.Fill;
			p_DragDrop_Comment.Show();

			p_DragDrop_File.Dock = DockStyle.Fill;
			p_DragDrop_File.Show();

			p_DragDrop_MainData.Dock = DockStyle.Fill;
			p_DragDrop_MainData.Show();

			p_DragDrop_AllData.Dock = DockStyle.Fill;
			p_DragDrop_AllData.Show();

			p_DragDrop_Notes.Dock = DockStyle.Fill;
			p_DragDrop_Notes.Show();
		}

		public void hideDropPoints()
		{
			p_DragDrop_Comment.Dock = DockStyle.None;
			p_DragDrop_Comment.Hide();

			p_DragDrop_File.Dock = DockStyle.None;
			p_DragDrop_File.Hide();

			p_DragDrop_MainData.Dock = DockStyle.None;
			p_DragDrop_MainData.Hide();

			p_DragDrop_AllData.Dock = DockStyle.None;
			p_DragDrop_AllData.Hide();

			p_DragDrop_Notes.Dock = DockStyle.None;
			p_DragDrop_Notes.Hide();
		}

		public void parseAllDataToObject(string str)
		{
			//TODO: FIX
			if (str.Contains("--FILE--"))
			{
				string[] strs = parseAllDataToMulti(str);
				foreach(string s in strs)
				{
					parseAllDataToObject(s);
				}
			}

			fileDataObject fdo = new fileDataObject();
			bool toComment = false;
			bool toNotes = false;

			foreach (string s in str.Split('\n'))
			{
				if (!s.StartsWith("#") && s.Length > 0 && s.Contains("="))
				{
					string ln = s.Substring(0, s.IndexOf("="));
					switch (ln)
					{
						case "PROJECT":
							if (int.TryParse(s, out int _i))
							{
								fdo.ProjectId = _i;
							}
							break;
						case "FNAME":
							fdo.FileName = s;
							break;
						case "FPATH":
							fdo.Location = s;
							break;
						case "PARAMS":
							fdo.Parameters = s;
							break;
						case "VERSION":
							fdo.FileVersion = s;
							break;
						case "INUSE":
							fdo.InUse = s == "1" ? true : false;
							break;
						case "PATH":
							fdo.FilePath = s;
							break;
						case "IMAGE":
							fdo.FileImageName = s;
							break;
						case "CSTART":
							toComment = true;
							break;
						case "CEND":
							toComment = false;
							break;
						case "NSTART":
							toNotes = true;
							break;
						case "NEND":
							toNotes = false;
							break;
						case "RIGHTS":
							fdo.Rights = s;
							break;
						case "OWNER":
							fdo.Owner = s;
							break;
						case "GROUP":
							fdo.Group = s;
							break;
						case "CREATED":
							if(DateTime.TryParse(s, out DateTime dtc))
							{
								fdo.Created = dtc;
							}
							break;
						case "MODIFIED":
							if (DateTime.TryParse(s, out DateTime dtm))
							{
								fdo.Modified = dtm;
							}
							break;
					}

					if (toComment)
					{
						fdo.Comment += s + "\r\n";
					}

					if (toNotes)
					{
						fdo.Notes += s + "\r\n";
					}
				}
			}

			_files.Add(fdo);
		}
		
		public string[] parseAllDataToMulti(string str)
		{
			List<string> ret = new List<string>();
			StringBuilder sb = new StringBuilder();
			foreach(String s in str.Split('\n'))
			{
				if(s.Trim() == "--FILE--")
				{
					ret.Add(sb.ToString());
					sb.Clear();
					continue;
				}

				if(s.Trim() != "" && !s.StartsWith("#"))
				{
					sb.Append(s + "\r\n");
				}
			}

			return ret.ToArray();
		}

		public bool attemptDrop(dropTarget target, DragEventArgs e)
		{
			//TODO: poop
			Object send = null;
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				string file = (e.Data.GetData(DataFormats.FileDrop) as string[])[0];
				string ext = file.Substring(file.IndexOf(".") + 1);
				if (_stringTypes.Contains(ext.ToLower()))
				{
					parseAllDataToObject(file);
					if(_files.Count > 0)
					{

					}
				}
			}

			switch (target)
			{
				case dropTarget.allFields:
					return parseAllData();
				case dropTarget.mainFields:
					return parseMainData();
				case dropTarget.fileAttachment:
					return parseFile();
				case dropTarget.notes:
					return parseNotes();
				case dropTarget.comment:
					return parseComment();
				default:return false;
			}
		}

		public void flashDragDrop(dropTarget target)
		{

			switch (target)
			{
				case dropTarget.allFields:
					lbl_AllData.ForeColor			= Color.Red;
					break;
				case dropTarget.mainFields:
					lbl_MainData.ForeColor			= Color.Red;
					break;
				case dropTarget.fileAttachment:
					lbl_FileAttachment.ForeColor	= Color.Red;
					break;
				case dropTarget.notes:
					lbl_NotesData.ForeColor			= Color.Red;
					break;
				case dropTarget.comment:
					lbl_CommentData.ForeColor		= Color.Red;
					break;
			}
		}

		public void unflashDragDrop()
		{
			lbl_AllData.ForeColor			= Color.Black;
			lbl_MainData.ForeColor			= Color.Black;
			lbl_FileAttachment.ForeColor	= Color.Black;
			lbl_NotesData.ForeColor			= Color.Black;
			lbl_CommentData.ForeColor		= Color.Black;
		}

		private void f_AddFile_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Copy | DragDropEffects.Link;
			showDropPoints();
		}

		private void DATA_DragLeave(object sender, EventArgs e)
		{
			if (!Bounds.Contains(Cursor.Position))
			{
				hideDropPoints();
			}
		}

		private void DATA_DragDrop(object sender, DragEventArgs e)
		{
			if (int.TryParse(((Control)sender).Tag.ToString(), out int t))
			{
				attemptDrop((dropTarget)t, e);
				hideDropPoints();
			}
		}
		
		private void p_DragDrop_MainData_DragLeave(object sender, EventArgs e)
		{
			if (int.TryParse(((Control)sender).Tag.ToString(), out int t))
			{ unflashDragDrop(); }
		}

		public void flash(int t)
		{
			flashDragDrop((dropTarget)t);
		}

		private void DATA_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.All | DragDropEffects.Copy;
			if (int.TryParse(((Control)sender).Tag.ToString(), out int t)){flash(t);}
		}

		public bool parseAllData(String fileContents)
		{
			return		parseMainData()
					&&	parseFile()
					&&	parseNotes()
					&&	parseComment()
					&&	parseAdditionalData();
		}

		public bool parseMainData()
		{
			bool ret = false;



			return ret;
		}

		public bool parseFile()
		{
			bool ret = false;



			return ret;
		}

		public bool parseComment()
		{
			bool ret = false;



			return ret;
		}

		public bool parseNotes()
		{
			bool ret = false;



			return ret;
		}

		public bool parseAdditionalData()
		{
			bool ret = false;



			return ret;
		}
	}

	public enum dropTarget
	{
		allFields,
		mainFields,
		fileAttachment,
		notes,
		comment
	}
}
