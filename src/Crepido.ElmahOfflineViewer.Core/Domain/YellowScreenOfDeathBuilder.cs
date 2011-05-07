using System;
using System.Net;

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
			template = template.Replace("@MESSAGE@", WebUtility.HtmlEncode(ErrorLog.Message));
			template = template.Replace("@TYPE@", WebUtility.HtmlEncode(ErrorLog.Type));
			template = template.Replace("@SOURCE@", WebUtility.HtmlEncode(ErrorLog.Source));
			template = template.Replace("@STACK_TRACE@", ConvertLineBreaks(WebUtility.HtmlEncode(ErrorLog.Details)));

			return template;
		}

		private static string ConvertLineBreaks(string text)
		{
			return text.Replace(Environment.NewLine, "</br>");
		}
	}
}
