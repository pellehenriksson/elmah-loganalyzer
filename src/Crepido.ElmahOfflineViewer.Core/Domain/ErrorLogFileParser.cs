using System;
using System.Xml;
using Crepido.ElmahOfflineViewer.Core.Infrastructure;

namespace Crepido.ElmahOfflineViewer.Core.Domain
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
		}

		private void ParseServerVariables()
		{
			var variables = _documentRoot.SelectNodes("//serverVariables//item");
			if (variables == null || variables.Count == 0)
			{
				return;
			}

			foreach (XmlNode node in variables)
			{
				var name = node.Attributes["name"].InnerText;
				var value = node.ChildNodes[0].Attributes["string"].InnerText;

				_errorLog.AddServerVariable(name, value);
			}
		}

		private void ParseFormValues()
		{
			var formvalues = _documentRoot.SelectNodes("//form//item");
			if (formvalues == null || formvalues.Count == 0)
			{
				return;
			}

			foreach (XmlNode node in formvalues)
			{
				var name = node.Attributes["name"].InnerText;
				var value = node.ChildNodes[0].Attributes["string"].InnerText;

				_errorLog.AddFormValue(name, value);
			}
		}
		
		private void ParseCookies()
		{
			var cookies = _documentRoot.SelectNodes("//cookies//item");
			if (cookies == null || cookies.Count == 0)
			{
				return;
			}

			foreach (XmlNode node in cookies)
			{
				var name = node.Attributes["name"].InnerText;
				var value = node.ChildNodes[0].Attributes["string"].InnerText;

				_errorLog.AddCookie(name, value);
			}
		}

		private void ParseQuerystringValues()
		{
			var cookies = _documentRoot.SelectNodes("//queryString//item");
			if (cookies == null || cookies.Count == 0)
			{
				return;
			}

			foreach (XmlNode node in cookies)
			{
				var name = node.Attributes["name"].InnerText;
				var value = node.ChildNodes[0].Attributes["string"].InnerText;

				_errorLog.AddQuerystringValue(name, value);
			}
		}
		
		private string GetAttributeValue(string attribute)
		{
			return _documentRoot.GetAttribute(attribute);
		}
	}
}
