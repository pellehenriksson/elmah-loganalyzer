using System.ComponentModel;

namespace ElmahLogAnalyzer.Core.Domain
{
	public enum ErrorLogSourcesEnum
	{
		Files,
		[Description("Microsoft SQL Server")]
		SqlServer,
		[Description("Microsoft SQL Server Compact Edition")]
		SqlCe,
		WebServer
	}
}
