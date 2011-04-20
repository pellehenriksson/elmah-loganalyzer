using System.Windows.Forms;
using Crepido.ElmahOfflineViewer.Core.Common;

namespace Crepido.ElmahOfflineViewer.UI.Views.Partials
{
	public partial class DateIntervalView : UserControl
	{
		public DateIntervalView()
		{
			InitializeComponent();
		}

		public void SetInterval(DateInterval interval)
		{
			startDateTimePicker.Value = interval.StartDate;
			endDateTimePicker.Value = interval.EndDate;
		}
		
		public DateInterval GetInterval()
		{
			return new DateInterval(startDateTimePicker.Value, endDateTimePicker.Value);
		}
	}
}
