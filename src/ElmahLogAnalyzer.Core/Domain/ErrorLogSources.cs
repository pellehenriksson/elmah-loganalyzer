using System.ComponentModel;

namespace ElmahLogAnalyzer.Core.Domain
{
	public enum ErrorLogSources
	{
		[Description("XML files")]Files,
		[Description("Microsoft SQL Server")]SqlServer,
		[Description("Microsoft SQL Server Compact Edition")]SqlServerCompact
	}
}
