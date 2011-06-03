using System;
using System.Xml;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Infrastructure.Logging;

namespace ElmahLogAnalyzer.Core.Domain
{
	public class ErrorLogFileParser : IErrorLogFileParser
	{
		private readonly ILog _log;

		private XmlDocument _document;
		private XmlElement _documentRoot;
		private ErrorLog _errorLog;

		public ErrorLogFileParser(ILog log)
		{
			_log = log;
		}
		
		public ErrorLog Parse(string content)
		{
			try
			{
				_document = new XmlDocument();
				_document.LoadXml(content);
				_documentRoot = _document.DocumentElement;

				_errorLog = new ErrorLog();

				ParseAttributes();
				ParseServerVariables();
				ParseFormValues();
				ParseQuerystringValues();
				ParseCookies();

				SetStatusCodeInformation();
				SetServerInformation();

				return _errorLog;
			}
			catch (Exception ex)
			{
				_log.Error(ex);
				return null;
			}
		}

		private void ParseAttributes()
		{
			_errorLog.ErrorId = GetAttributeValue("errorId");
			_errorLog.Host = GetAttributeValue("host");
			_errorLog.Type = GetAttributeValue("type");
			_errorLog.Message = GetAttributeValue("message");
			_errorLog.Source = GetAttributeValue("source");
			_errorLog.Details = GetAttributeValue("detail");

			var time = GetAttributeValue("time");
			_errorLog.Time = Convert.ToDateTime(time);

			_errorLog.StatusCode = GetAttributeValue("statusCode");
		}

		private void SetStatusCodeInformation()
		{
			var statusCodeInformation = HttpStatusCodeInformationLookUp.GetInformation(_errorLog.StatusCode);
			_errorLog.SetStatusCodeInformation(statusCodeInformation);
		}

		private void SetServerInformation()
		{
			var serverInformation = new ServerInformation();
			
			serverInformation.Host = _errorLog.Host;
			serverInformation.Name = _errorLog.ServerVariables.GetValueFromFirstMatch("SERVER_NAME");
			serverInformation.Port = _errorLog.ServerVariables.GetValueFromFirstMatch("SERVER_PORT");
			serverInformation.Software = _errorLog.ServerVariables.GetValueFromFirstMatch("SERVER_SOFTWARE");

			_errorLog.SetServerInformation(serverInformation);
		}

		private void ParseServerVariables()
		{
			ParseSegment(_errorLog.AddServerVariable, "//serverVariables//item");
		}
		
		private void ParseFormValues()
		{
			ParseSegment(_errorLog.AddFormValue, "//form//item");
		}
		
		private void ParseCookies()
		{
			ParseSegment(_errorLog.AddCookie, "//cookies//item");
		}

		private void ParseQuerystringValues()
		{
			ParseSegment(_errorLog.AddQuerystringValue, "//queryString//item");
		}

		private void ParseSegment(Action<string, string> method, string segmentPath)
		{
			var formvalues = _documentRoot.SelectNodes(segmentPath);
			if (formvalues == null || formvalues.Count == 0)
			{
				return;
			}

			foreach (XmlNode node in formvalues)
			{
				var name = node.Attributes["name"].InnerText;
				var value = node.ChildNodes[0].Attributes["string"].InnerText;

				method.Invoke(name, value);
			}
		}
		
		private string GetAttributeValue(string attribute)
		{
			return _documentRoot.GetAttribute(attribute);
		}
	}
}
