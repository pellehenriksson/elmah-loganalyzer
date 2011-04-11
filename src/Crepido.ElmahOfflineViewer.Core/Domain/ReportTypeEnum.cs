using System.ComponentModel;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public enum ReportTypeEnum
	{
		[Description("By type of exception")]
		Type,
		[Description("By source")]
		Source,
		[Description("By user")]
		User,
		[Description("By url")]
		Url,
		[Description("By day")]
		Day
	}
}
