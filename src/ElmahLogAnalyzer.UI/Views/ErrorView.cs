using System;
using System.Windows.Forms;

namespace ElmahLogAnalyzer.UI.Views
{
	public partial class ErrorView : UserControl
	{
		private readonly Exception _exception;

		public ErrorView(Exception exception)
		{
			InitializeComponent();
			_exception = exception;

			BuildMessage();
		}

		private void BuildMessage()
		{
			_messageTextBox.Text = _exception.ToString();
			_messageTextBox.DeselectAll();
		}
	}
}
