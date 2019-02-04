using System.Windows.Forms;

namespace KodeKeeper
{
	public partial class c_CompositPanel : Panel
	{
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams cp = base.CreateParams;
				cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
				return cp;
			}
		}

		public c_CompositPanel()
		{
			InitializeComponent();
		}
	}
}