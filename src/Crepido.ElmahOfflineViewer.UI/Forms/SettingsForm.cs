using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Crepido.ElmahOfflineViewer.Core.Common;
using Crepido.ElmahOfflineViewer.Core.Presentation;

namespace Crepido.ElmahOfflineViewer.UI.Forms
{
	public partial class SettingsForm : Form, ISettingsView
	{
		public SettingsForm()
		{
			InitializeComponent();

			AcceptButton = _saveButton;
			CancelButton = _cancelButton;
		}

		public event EventHandler OnLoaded;

		public event EventHandler OnSave;

		public int MaxNumberOfLogs
		{
			get
			{
				var option = (NameValuePair)_numberOfLogsToLoadComboBox.SelectedItem;
				return Convert.ToInt32(option.Value);
			}
		}

		public void LoadMaxNumberOfLogOptions(IEnumerable<NameValuePair> options, string selectedOption)
		{
			_numberOfLogsToLoadComboBox.Items.Clear();

			foreach (var option in options)
			{
				var index = _numberOfLogsToLoadComboBox.Items.Add(option);
				if (option.Value == selectedOption)
				{
					_numberOfLogsToLoadComboBox.SelectedIndex = index;
				}
			}
		}
		
		private void SettingsFormLoad(object sender, EventArgs e)
		{
			if (OnLoaded != null)
			{
				OnLoaded(this, new EventArgs());
			}
		}

		private void SaveButtonClick(object sender, EventArgs e)
		{
			if (OnSave != null)
			{
				OnSave(this, new EventArgs());
			}

			Close();
		}

		private void CancelButtonClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
