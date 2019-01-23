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
		public f_EditConnection(bool edit = false, connection conn = null)
		{
			InitializeComponent();

			if(edit && conn != null)
			{
				loadConnectionData(conn);
			}
		}

		private void loadConnectionData(connection conn)
		{

		}
	}
}
