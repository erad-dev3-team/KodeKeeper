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
	public partial class Form1 : Form
	{
		private bool searchHeader_MDown = false;
		private Point searchHeader_Pnt = new Point(0,0);
		private Point searchHeader_Loc = new Point(0,0);


		public Form1()
		{
			InitializeComponent();
		}

		private void p_SearchHeader_MouseDown(object sender, MouseEventArgs e)
		{
			Point p = PointToScreen(new Point(e.X, e.Y));
			searchHeader_Pnt.X = p.X;
			searchHeader_Pnt.Y = p.Y;
			searchHeader_MDown = true;
			
		}

		private void p_SearchHeader_MouseUp(object sender, MouseEventArgs e)
		{
			searchHeader_MDown = false;
		}

		private void p_SearchHeader_MouseMove(object sender, MouseEventArgs e)
		{
			if (searchHeader_MDown)
			{
				Point p = PointToScreen(new Point(e.X, e.Y));
				p_SearchHeader.Left = p.X - searchHeader_Pnt.X;
			}
		}
	}
}
