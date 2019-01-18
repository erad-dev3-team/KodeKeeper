using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KodeKeeper
{
	public partial class dataUpdate : Form
	{
		public c_DBHandler _dbh { get; set; }
		public bool ApproovedUpdate = false;
		string query = "";

		public dataUpdate(dataUpdateObject obj = null)
		{
			InitializeComponent();

			if(obj != null)
			{
				fillNumbers(obj);
			}
		}

		public void fillNumbers(dataUpdateObject obj)
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
		}

		private void cb_ShowQuery_CheckedChanged(object sender, EventArgs e)
		{
			if (cb_ShowQuery.Checked)
			{
				Width = btn_StartUpdate.Left + rtb_Query.Right + 10;
			}
			else
			{
				Width = btn_StartUpdate.Left + btn_Close.Right + 10;
			}

			ApproovedUpdate = cb_ShowQuery.Checked;
		}

		private void btn_StartUpdate_Click(object sender, EventArgs e)
		{
			startUpdate();
		}

		public void startUpdate()
		{
			updater upd = new updater() { _dbh = _dbh };

			query = upd.update();
			if (ApproovedUpdate)
			{
				rtb_Query.Text = query;
			}
			else
			{
				initUpdate();
			}
		}

		public void initUpdate()
		{
			_dbh.updateInsert(query);
		}

		private void btn_StartQuery_Click(object sender, EventArgs e)
		{
			if(rtb_Query.Text != "")
			{
				query = rtb_Query.Text;
				string tq = "BEGIN TRANSACTION;\r\nSAVEPOINT x;\r\n" + query.Replace(";","; ROLLBACK TO x;") + " ROLLBACK; ";
				SQLiteConnection conn = _dbh.Sqlc;
				SQLiteCommand comm = new SQLiteCommand(tq, conn);
				comm.ExecuteNonQuery();
				initUpdate();
			}
			else
			{

			}
		}
	}
}
