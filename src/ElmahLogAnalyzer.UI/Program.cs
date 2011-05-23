using System;
using System.Windows.Forms;
using ElmahLogAnalyzer.UI.Forms;

namespace ElmahLogAnalyzer.UI
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
