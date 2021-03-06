﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Presentation;

namespace ElmahLogAnalyzer.UI.Forms
{
	public partial class SettingsForm : Form, ISettingsView
	{
		public SettingsForm()
		{
			InitializeComponent();

			_defaultLogsDirectoryTextBox.Enabled = false;
			_defaultExportDirectoryTextBox.Enabled = false;		
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

		public DateIntervalSpans DefaultDateInterval
		{
			get
			{
				var option = (NameValuePair)_defaultDateIntervalFilterComboBox.SelectedItem;
				return (DateIntervalSpans)Convert.ToInt32(option.Value);
			}
		}

		public string DefaultLogsDirectory
		{
			get { return _defaultLogsDirectoryTextBox.Text; }
			set { _defaultLogsDirectoryTextBox.Text = value; }
		}

		public bool LoadLogsFromDefaultDirectoryAtStartup
		{
			get { return _loadLogsFromDefaultDirectoryAtStartupCheckBox.Checked; }
			set { _loadLogsFromDefaultDirectoryAtStartupCheckBox.Checked = value; }
		}

		public string DefaultExportDirectory
		{
			get { return _defaultExportDirectoryTextBox.Text; }
			set { _defaultExportDirectoryTextBox.Text = value; }
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

		public void LoadDefaultDateIntervalOptions(IEnumerable<NameValuePair> options, DateIntervalSpans selectedOption)
		{
			_defaultDateIntervalFilterComboBox.Items.Clear();

			foreach (var option in options)
			{
				var index = _defaultDateIntervalFilterComboBox.Items.Add(option);
				if (option.Value == ((int)selectedOption).ToString(CultureInfo.InvariantCulture))
				{
					_defaultDateIntervalFilterComboBox.SelectedIndex = index;
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

			DialogResult = DialogResult.OK;
			Close();
		}

		private void CancelButtonClick(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
		
		private void SelectDefaultLogsDirectoryButtonClick(object sender, EventArgs e)
		{
			if (_folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
			{
				_defaultLogsDirectoryTextBox.Text = _folderBrowserDialog.SelectedPath;
			}
		}

		private void SelectDefaultExportDirectoryButtonClick(object sender, EventArgs e)
		{
			if (_folderBrowserDialog.ShowDialog(this) == DialogResult.OK)
			{
				_defaultExportDirectoryTextBox.Text = _folderBrowserDialog.SelectedPath;
			}
		}
	}
}
