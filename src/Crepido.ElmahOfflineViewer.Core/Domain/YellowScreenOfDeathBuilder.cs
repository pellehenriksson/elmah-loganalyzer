using System;
using System.Net;
using System.Text;

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
			var template = new StringBuilder(Templates.YellowScreenOfDeath);
	
			template.Replace("@APPLICATION@", "/");
			template.Replace("@MESSAGE@", WebUtility.HtmlEncode(ErrorLog.Message));
			template.Replace("@TYPE@", WebUtility.HtmlEncode(ErrorLog.Type));
			template.Replace("@SOURCE@", WebUtility.HtmlEncode(ErrorLog.Source));
			template.Replace("@STACK_TRACE@", ConvertLineBreaks(WebUtility.HtmlEncode(ErrorLog.Details)));

			return template.ToString();
		}

		private static string ConvertLineBreaks(string text)
		{
			return text.Replace(Environment.NewLine, "</br>");
		}
	}
}
