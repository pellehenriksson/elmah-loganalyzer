using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Domain;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public class ReportTypeListItem
	{
		public ReportTypeListItem(ReportTypes reportType)
		{
			ReportType = reportType;
			Displayname = reportType.GetDescription();
		}

		public ReportTypes ReportType { get; private set; }
		
		public string Displayname { get; private set; }

		public override string ToString()
		{
			return Displayname;
		}
	}
}
