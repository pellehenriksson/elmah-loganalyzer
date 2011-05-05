using System;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class YellowScreenOfDeathBuilder
	{
		public YellowScreenOfDeathBuilder(ErrorLog errorlog)
		{
			ErrorLog = errorlog;
		}

		public ErrorLog ErrorLog { get; private set; }
		
		public string GetHtml()
		{
			var template = Templates.YellowScreenOfDeath;

			template = template.Replace("@APPLICATION@", "/");
			template = template.Replace("@MESSAGE@", System.Net.WebUtility.HtmlEncode(ErrorLog.Message));
			template = template.Replace("@TYPE@", System.Net.WebUtility.HtmlEncode(ErrorLog.Type));
			template = template.Replace("@STACK_TRACE@", ConvertLineBreaks(ErrorLog.Details));

			return template;
		}

		private static string ConvertLineBreaks(string text)
		{
			return text.Replace(Environment.NewLine, "</br>");
		}
	}
}
