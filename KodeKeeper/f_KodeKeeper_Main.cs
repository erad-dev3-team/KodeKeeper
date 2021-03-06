﻿using KodeKeeper.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KodeKeeper
{
	public partial class f_KodeKeeperMain : Form
	{
		private bool searchHeader_MDown = false;
		private Point searchHeader_Pnt = new Point(0, 0);
		private bool searchResize_MDown = false;
		private Point searchResize_Pnt = new Point(0, 0);
		private c_DBHandler _dbh = new c_DBHandler("KodeKeeper.db");
		private c_FileDataCollectionManager uh;

		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams cp = base.CreateParams;
				cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
				return cp;
			}
		}

		public f_KodeKeeperMain()
		{
			InitializeComponent();
			Load += Form1_Load;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			p_Search.Hide();
			uh = new c_FileDataCollectionManager(_dbh);
		}

		private void p_SearchHeader_MouseDown(object sender, MouseEventArgs e)
		{
			Point p = PointToScreen(new Point(e.X, e.Y));
			searchHeader_Pnt.X = p.X;
			searchHeader_Pnt.Y = p.Y;
			p_SearchHeader.Cursor = Cursors.SizeAll;
			searchHeader_MDown = true;

		}

		private void p_SearchHeader_MouseUp(object sender, MouseEventArgs e)
		{
			p_SearchHeader.Cursor = Cursors.Default;
			searchHeader_MDown = false;
		}

		private void p_SearchHeader_MouseMove(object sender, MouseEventArgs e)
		{
			if (searchHeader_MDown)
			{
				p_Search.Left = Cursor.Position.X - searchHeader_Pnt.X;
				p_Search.Top = Cursor.Position.Y - (searchHeader_Pnt.Y + tsc_Container.TopToolStripPanel.Height + ms_Menu.Height);
			}
		}

		private void lbl_CloseSearch_Click(object sender, EventArgs e)
		{
			hideSearch();
		}

		public void showSearch()
		{
			if (!Bounds.Contains(p_Search.Bounds)) { p_Search.Left = 4; p_Search.Top = 4; }
			if(p_Search.Height < 170) { p_Search.Height = 170; }
			if(p_Search.Width < 215) { p_Search.Width = 230; }
			p_Search.Show();
		}

		public void hideSearch()
		{
			p_Search.Hide();

			if (((p_Search.Bottom < 0 || p_Search.Right < 0) ||
				(p_Search.Top > Height || p_Search.Left > Width)))
			{
				showSearch();
			}
		}

		private void btn_ToolStrip_Search_Click(object sender, EventArgs e)
		{
			if (p_Search.Visible) { hideSearch(); } else { showSearch(); }
		}

		private void btn_Search_MouseEnter(object sender, EventArgs e)
		{
			p_Resize.BackColor = btn_Search.FlatAppearance.MouseOverBackColor;
		}

		private void btn_Search_MouseLeave(object sender, EventArgs e)
		{
			p_Resize.BackColor = btn_Search.BackColor;
		}

		private void p_Resize_MouseDown(object sender, MouseEventArgs e)
		{
			searchResize_MDown = true;
		}

		private void p_Resize_MouseUp(object sender, MouseEventArgs e)
		{
			Point p = PointToClient(new Point(e.X, e.Y));
			searchResize_Pnt.X = p.X;
			searchResize_Pnt.Y = p.Y;
			searchResize_MDown = false;
		}

		private void p_Resize_MouseMove(object sender, MouseEventArgs e)
		{
			if (searchResize_MDown)
			{
				p_Search.Width = Cursor.Position.X - p_Search.Left - Left;
				p_Search.Height = Cursor.Position.Y - (tsc_Container.TopToolStripPanel.Height + ms_Menu.Height + btn_Search.Height) - p_Search.Top - Top;
			}
		}

		private void cb_LimitResults_CheckedChanged(object sender, EventArgs e)
		{
			num_LimitResults.Enabled = cb_LimitResults.Checked;
		}

		private void p_Search_LocationChanged(object sender, EventArgs e)
		{
		}

		private void btn_Search_Click(object sender, EventArgs e)
		{
			//TODO: Search
		}

		private void p_SearchHeader_MouseCaptureChanged(object sender, EventArgs e)
		{
		}

		private void btn_Menu_AddNewFile_Click(object sender, EventArgs e)
		{
			f_AddFile fa = new f_AddFile();
			fa.ShowDialog();
		}

		private void btn_Menu_Data_CheckUpdates_Click(object sender, EventArgs e)
		{
			c_DataUpdateObject v = uh.checkUpdate();
			Hashtable vv = v.Get();
			int i = 0;
			foreach(DictionaryEntry vvv in vv)
			{
				if(int.TryParse(vvv.Value.ToString(),out int ii))
				{
					i += ii;
				}
			}

			if(i > 0)
			{
				openUpdateScreen(v);
			}
			
		}

		private void btn_Menu_Data_OpenUpdateScreen_Click(object sender, EventArgs e)
		{
			openUpdateScreen();
		}

		public void openUpdateScreen(c_DataUpdateObject obj = null)
		{
			f_DatabaseUpdater du = new f_DatabaseUpdater(obj) { _dbh = _dbh };
			du.ShowDialog();
		}

		private void btn_Menu_File_ConnectToServer_Click(object sender, EventArgs e)
		{
			
		}

		private void btn_Menu_Connection_Open_Click(object sender, EventArgs e)
		{
			f_ConnectionInitializer fcts = new f_ConnectionInitializer();
			fcts.Dbh = _dbh;
			fcts.ShowDialog();
		}

		private void btn_Menu_Connections_AddNewConnection_Click(object sender, EventArgs e)
		{
			f_EditConnection ec = new f_EditConnection();
			ec.Dbh = _dbh;
			ec.ShowDialog();
		}

		private void btn_Menu_Projects_AddProject_Click(object sender, EventArgs e)
		{

		}

		private void btn_Menu_Projects_EditProject_Click(object sender, EventArgs e)
		{

		}
	}
}
