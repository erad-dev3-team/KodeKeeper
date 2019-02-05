using KodeKeeper.Objects;
using ScintillaNET;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KodeKeeper
{
	public partial class f_DatabaseUpdater : Form
	{
		public c_DBHandler _dbh { get; set; }
		public bool ApproovedUpdate = false;
		string _query = "";
		string _date = "";
		int[] _months = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
		ListViewItem _l = null;
		ListViewItem _l2 = null;
		int _updateRowsExpected = 0;

		public f_DatabaseUpdater(c_DataUpdateObject obj = null)
		{
			InitializeComponent();

			if(obj != null)
			{
				fillNumbers(obj);
			}

			Load += DataUpdate_Load;
		}

		private void DataUpdate_Load(object sender, EventArgs e)
		{
			#region Scintilla
			//==Lexer Setup
			rtb_Query.LexerLanguage = "SQL";
			rtb_Query.Lexer = Lexer.Sql;
			
			//Comment
			rtb_Query.Styles[Style.Sql.Comment].ForeColor			= Color.Green;
			rtb_Query.Styles[Style.Sql.Comment].Bold				= true;
			rtb_Query.Styles[Style.Sql.Comment].Weight = 2000;

			//Identifier
			rtb_Query.Styles[Style.Sql.Identifier].ForeColor		= Color.DarkBlue;
			rtb_Query.Styles[Style.Sql.Identifier].FillLine			= true;

			rtb_Query.Styles[Style.Sql.Character].Bold				= true;
			rtb_Query.Styles[Style.Sql.Character].ForeColor			= Color.Red;

			rtb_Query.Styles[Style.Sql.Default].ForeColor			= Color.Black;
			rtb_Query.Styles[Style.Sql.QuotedIdentifier].ForeColor	= Color.Purple;

			rtb_Query.Styles[Style.Default].ForeColor = Color.Black;
			rtb_Query.Styles[Style.Default].Size = 12;
			rtb_Query.Styles[Style.Default].Font = "Consolas";

			rtb_Query.Styles[Style.LineNumber].Visible = true;
			rtb_Query.Styles[Style.LineNumber].Font = "Consolas";
			rtb_Query.Styles[Style.LineNumber].ForeColor = Color.DarkGray;

			rtb_Query.Styles[Style.FoldDisplayText].Bold = true;
			rtb_Query.Styles[Style.FoldDisplayText].Visible = true;
			rtb_Query.Styles[Style.FoldDisplayText].Font = "Consolas";
			rtb_Query.Styles[Style.FoldDisplayText].ForeColor = Color.DarkGray;

			rtb_Query.Styles[Style.Sql.User1].ForeColor = Color.DarkGray;

			rtb_Query.WordChars = "aábcdeéfghiíjklmnoóöőpqrstuúüűvwxyzAÁBCDEÉFGHIÍJKLMNOÓÖŐPQRSTUÚÜŰVWXYZ0123456789_-\\/";
			rtb_Query.IndentationGuides = IndentView.Real;
			rtb_Query.Margins[0].Width = 20;
			rtb_Query.Margins[2].Width = 20;
			rtb_Query.ViewWhitespace = WhitespaceMode.Invisible;
			rtb_Query.AutomaticFold = AutomaticFold.Click;
			rtb_Query.SetFoldFlags(FoldFlags.LineAfterContracted | FoldFlags.LineBeforeExpanded);
			rtb_Query.FoldDisplayTextSetStyle(FoldDisplayText.Boxed | FoldDisplayText.Standard);

			rtb_Query.StyleResetDefault();

			rtb_Query.TextChanged += Rtb_Query_TextChanged;
			#endregion

			_date = DateTime.Now.ToShortDateString().Trim('.') + " 00:00";
			mtb_DateTime.Text = _date;

			cb_SkipFileContants.Checked = true;
			cb_SkipImageData.Checked = true;
		}

		public bool checkLeap(int year)
		{
			bool leap = false;
			if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
			{
				leap = true;
			}

			return leap;
		}

		public int getDays(int month)
		{
			return _months[month - 1];
		}

		public void setDays(int year, int month)
		{
			if (month == 2)
			{
				if (checkLeap(year))
				{
					num_Date_Day.Maximum = 29;
				}
				else
				{
					num_Date_Day.Maximum = 28;
				}
			}
			else
			{
				num_Date_Day.Maximum = getDays(month);
			}
		}

		private void Rtb_Query_TextChanged(object sender, EventArgs e)
		{
			rtb_Query.Update();
			
		}

		public void fillNumbers(c_DataUpdateObject obj)
		{
			int i = 0;
			foreach (DictionaryEntry v in obj.Get())
			{
				ListViewItem lvi = new ListViewItem();
				lvi.Text = $"{i++}".PadLeft(2, '0');
				lvi.SubItems.Add(v.Key.ToString().Substring(v.Key.ToString().IndexOf("_") + 1));
				lvi.SubItems.Add(v.Value.ToString());
				lvi.BackColor = i % 2 == 0 ? Color.WhiteSmoke : Color.LightYellow;
				lv_UpdateNumbers.Items.Add(lvi);
			}

			foreach (ListViewItem lvi in lv_UpdateNumbers.Items)
			{
				if (lvi.SubItems[1].Text.ToLower().Contains("image") && _l is null)
				{
					_l = lvi;
					continue;
				}

				if (lvi.SubItems[1].Text.ToLower().Contains("files") && _l2 is null)
				{
					_l2 = lvi;
					continue;
				}
			}
		}

		public void countUpdates()
		{
			_updateRowsExpected = 0;

			foreach (ListViewItem lvi in lv_UpdateNumbers.Items)
			{
				if (int.TryParse(lvi.SubItems[2].Text, out int ii) && lvi.Font.Style != FontStyle.Strikeout)
				{
					_updateRowsExpected += ii;
				}
			}

			lbl_Info.Text = "Rows to update: " + _updateRowsExpected;
		}

		private void cb_ShowQuery_CheckedChanged(object sender, EventArgs e)
		{
			if (cb_ShowQuery.Checked)
			{
				MinimumSize = new Size(rtb_Query.Left + 500 + 10, MinimumSize.Height);
				Width = rtb_Query.Left + 500 + 10;
				MaximumSize = new Size(0, 0);
				btn_CopyQuery.Visible = btn_SaveQuery.Visible = btn_StartQuery.Visible = true;
				rtb_Query.Width = Width - rtb_Query.Left - 30;
			}
			else
			{
				MinimumSize = new Size(btn_StartUpdate.Left + btn_Close.Right + 10, MinimumSize.Height);
				Width = btn_StartUpdate.Left + btn_Close.Right + 10;
				MaximumSize = MinimumSize;
				btn_CopyQuery.Visible = btn_SaveQuery.Visible = btn_StartQuery.Visible = false;
			}

			ApproovedUpdate = cb_ShowQuery.Checked;
		}

		private void btn_StartUpdate_Click(object sender, EventArgs e)
		{
			startUpdate();
		}

		public void startUpdate()
		{
			c_UpdateQueryGenerator upd = new c_UpdateQueryGenerator() { _dbh = _dbh };

			_query = upd.update();
			if (ApproovedUpdate)
			{
				rtb_Query.Text = _query;
			}
			else
			{
				initUpdate();
			}
		}

		public void initUpdate()
		{
			_dbh.updateInsert(_query);
		}

		public bool testQuery()
		{
			string tq = "SAVEPOINT x;\r\n" + 
						_query.Replace(";", "; \r\nROLLBACK TO x;");
			SQLiteConnection conn = _dbh.Sqlc;
			SQLiteCommand comm = new SQLiteCommand(tq, conn);
			try
			{
				comm.ExecuteNonQuery();
				return true;
			}
			catch(SQLiteException ex)
			{
				MessageBox.Show("Error (" + ex.ErrorCode + "): " + ex.Message);
				return false;
			}
		}

		private void btn_StartQuery_Click(object sender, EventArgs e)
		{
			if(rtb_Query.Text != "")
			{
				_query = rtb_Query.Text;
				if (testQuery())
				{
					initUpdate();
				}
				else
				{
					//TODO: Szólni
				}
			}
			else
			{
				//TODO: Szólni
			}
		}

		
		private void btn_SaveQuery_Click(object sender, EventArgs e)
		{
			if (rtb_Query.Text != "")
			{
				SaveFileDialog sfd = new SaveFileDialog();
				sfd.Filter = "Text File|*.txt|SQL File|*.sql|All Files|*.*";
				sfd.DefaultExt = "txt";
				sfd.Title = "Save query results";
				if (sfd.ShowDialog() == DialogResult.OK)
				{
					File.WriteAllText(sfd.FileName, rtb_Query.Text);
				}
			}
		}

		private void btn_CopyQuery_Click(object sender, EventArgs e)
		{
			if (rtb_Query.Text != "")
			{
				Clipboard.SetText(rtb_Query.Text);
			}
		}

		private void cb_OverwriteUpdateDateTime_CheckedChanged(object sender, EventArgs e)
		{
			mtb_DateTime.Enabled = btn_SelectDateTime.Enabled = cb_OverwriteUpdateDateTime.Checked;
		}

		private void mc_Date_Cal_DateSelected(object sender, DateRangeEventArgs e)
		{
			DateTime dt = mc_Date_Cal.SelectionStart.Date;
			num_Date_Year.Value = dt.Year;
			num_Date_Day.Value = dt.Day;
			cb_Date_Month.SelectedIndex = dt.Month - 1;
		}

		private void btn_Date_Set_Click(object sender, EventArgs e)
		{
			_date = mc_Date_Cal.SelectionStart.Date.ToShortDateString().Trim('.') + " " + mtb_Date_Time.Text;
			mtb_DateTime.Text = _date;
			p_Date.Hide();
		}

		private void btn_Date_Cancel_Click(object sender, EventArgs e)
		{
			p_Date.Hide();
		}

		bool _setdate = true;

		private void btn_SelectDateTime_Click(object sender, EventArgs e)
		{
			_setdate = false;
			p_Date.Show();
			mtb_Date_Time.Text = DateTime.Now.ToShortTimeString();

			mc_Date_Cal.SetDate(DateTime.Now);
			_setdate = true;
		}

		private void mtb_Date_Time_Click(object sender, EventArgs e)
		{
			mtb_Date_Time.SelectAll();
		}

		public void setDateValues()
		{
			if (_setdate)
			{
				setDays((int)num_Date_Year.Value, cb_Date_Month.SelectedIndex + 1);
				mc_Date_Cal.SetDate(new DateTime((int)num_Date_Year.Value, cb_Date_Month.SelectedIndex + 1, (int)num_Date_Day.Value));
			}
		}

		private void num_Date_Year_ValueChanged(object sender, EventArgs e)
		{
			setDateValues();
		}

		private void cb_Date_Month_SelectedIndexChanged(object sender, EventArgs e)
		{
			setDateValues();
		}

		private void num_Date_Day_ValueChanged(object sender, EventArgs e)
		{
			setDateValues();
		}

		private void cb_SkipImageData_CheckedChanged(object sender, EventArgs e)
		{
			if (_l != null)
			{
				if (cb_SkipImageData.Checked)
				{
					_l.Font = new Font(_l.Font, FontStyle.Strikeout);
				}
				else
				{
					_l.Font = new Font(_l.Font, FontStyle.Regular);
				}

				lv_UpdateNumbers.Refresh();

				countUpdates();
			}
		}

		private void cb_SkipFileContants_CheckedChanged(object sender, EventArgs e)
		{
			if (_l2 != null)
			{
				if (cb_SkipFileContants.Checked)
				{
					_l2.BackColor = Color.LightPink;
				}
				else
				{
					_l2.BackColor = (_l2.Index + 1) % 2 == 0 ? Color.WhiteSmoke : Color.LightYellow;
				}
			}
		}
	}

}
