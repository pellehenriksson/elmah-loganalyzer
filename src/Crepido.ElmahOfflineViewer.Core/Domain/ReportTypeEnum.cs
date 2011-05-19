using System.ComponentModel;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public enum ReportTypeEnum
	{
		[Description("Number of errors per type")]
		Type,
		[Description("Number of errors per source")]
		Source,
		[Description("Number of errors per user")]
		User,
		[Description("Number of errors per url")]
		Url,
		[Description("Number of errors per day")]
		Day
	}
}
