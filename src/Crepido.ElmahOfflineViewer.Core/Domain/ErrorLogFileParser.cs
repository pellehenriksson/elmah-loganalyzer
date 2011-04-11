using System;
using System.Xml;
using Crepido.ElmahOfflineViewer.Core.Domain.Abstract;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class ErrorLogFileParser : IErrorLogFileParser
	{
		private XmlDocument _document;
		private XmlElement _documentRoot;
		private ErrorLog _errorLog;

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

				return _errorLog;
			}
			catch (Exception)
			{
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
			if (variables == null)
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
		
		private string GetAttributeValue(string attribute)
		{
			return _documentRoot.GetAttribute(attribute);
		}
	}
}
