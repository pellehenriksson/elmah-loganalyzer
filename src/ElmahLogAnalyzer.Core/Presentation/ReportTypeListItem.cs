using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Domain;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public class ReportTypeListItem
	{
		public ReportTypeListItem(ReportTypeEnum reportType)
		{
			ReportType = reportType;
			Displayname = reportType.GetDescription();
		}

		public ReportTypeEnum ReportType { get; private set; }
		
		public string Displayname { get; private set; }

		public override string ToString()
		{
			return Displayname;
		}
	}
}
