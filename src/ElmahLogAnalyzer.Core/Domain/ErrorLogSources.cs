using System.ComponentModel;

namespace ElmahLogAnalyzer.Core.Domain
{
	public enum ErrorLogSources
	{
		Files,
		[Description("Microsoft SQL Server")]
		SqlServer,
		[Description("Microsoft SQL Server Compact Edition")]
		SqlServerCompact
	}
}
