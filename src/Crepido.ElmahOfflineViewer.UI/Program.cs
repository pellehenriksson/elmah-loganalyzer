using System;
using System.Windows.Forms;
using Crepido.ElmahOfflineViewer.UI.Forms;

namespace Crepido.ElmahOfflineViewer.UI
{
	public static class Program
	{
		[STAThread]
		public static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			
			Application.Run(new MainForm());
		}
	}
}
