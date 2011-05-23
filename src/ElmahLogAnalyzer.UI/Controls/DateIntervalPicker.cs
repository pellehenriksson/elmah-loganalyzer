using System.Windows.Forms;
using ElmahLogAnalyzer.Core.Common;

namespace ElmahLogAnalyzer.UI.Controls
{
	public partial class DateIntervalPicker : UserControl
	{
		public DateIntervalPicker()
		{
			InitializeComponent();
		}

		public void SetInterval(DateInterval interval)
		{
			_startDateTimePicker.Value = interval.StartDate;
			_endDateTimePicker.Value = interval.EndDate;
		}
		
		public DateInterval GetInterval()
		{
			return new DateInterval(_startDateTimePicker.Value, _endDateTimePicker.Value);
		}
	}
}
