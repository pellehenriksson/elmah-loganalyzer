using System.Collections.Generic;
using System.Linq;

namespace ElmahLogAnalyzer.Core.Domain
{	
	/// <summary>
	/// http://support.microsoft.com/kb/943891/
	/// http://msdn.microsoft.com/en-us/library/system.net.httpstatuscode.aspx
	/// </summary>
	public static class HttpStatusCodeInformationLookUp
	{
		private static readonly List<HttpStatusCodeInformation> Codes = new List<HttpStatusCodeInformation>();

		static HttpStatusCodeInformationLookUp()
		{
			Initialize();
		}

		public static HttpStatusCodeInformation GetInformation(string code)
		{
			var result = Codes.FirstOrDefault(x => x.Code == code);
			return result ?? new HttpStatusCodeInformation();
		}

		private static void Initialize()
		{
			// 1xx - Informational
			Codes.Add(new HttpStatusCodeInformation("100", "Continue"));
			Codes.Add(new HttpStatusCodeInformation("101", "Switching Protocols"));

			// 2xx - Success
			Codes.Add(new HttpStatusCodeInformation("200", "OK. The client request has succeeded"));
			Codes.Add(new HttpStatusCodeInformation("201", "Created"));
			Codes.Add(new HttpStatusCodeInformation("202", "Accepted"));
			Codes.Add(new HttpStatusCodeInformation("203", "Non-Authoritative Information"));
			Codes.Add(new HttpStatusCodeInformation("204", "No Content"));
			Codes.Add(new HttpStatusCodeInformation("205", "Reset Content"));
			Codes.Add(new HttpStatusCodeInformation("206", "Partial Content"));

			// 3xx - Redirection
			Codes.Add(new HttpStatusCodeInformation("301", "Moved Permanently"));
			Codes.Add(new HttpStatusCodeInformation("302", "Object moved"));
			Codes.Add(new HttpStatusCodeInformation("304", "Not Modified"));
			Codes.Add(new HttpStatusCodeInformation("307", "Temporary Redirect"));

			// 4xx - Client error
			Codes.Add(new HttpStatusCodeInformation("400", "Bad Request"));
			Codes.Add(new HttpStatusCodeInformation("400.1", "Invalid Destination Header"));
			Codes.Add(new HttpStatusCodeInformation("400.2", "Invalid Depth Header"));
			Codes.Add(new HttpStatusCodeInformation("400.3", "Invalid If Header"));
			Codes.Add(new HttpStatusCodeInformation("400.4", "Invalid Overwrite Header"));
			Codes.Add(new HttpStatusCodeInformation("400.5", "Invalid Translate Header"));
			Codes.Add(new HttpStatusCodeInformation("400.6", "Invalid Request Body"));
			Codes.Add(new HttpStatusCodeInformation("400.7", "Invalid Content Length"));
			Codes.Add(new HttpStatusCodeInformation("400.8", "Invalid Timeout"));
			Codes.Add(new HttpStatusCodeInformation("400.9", "Invalid Lock Token"));

			Codes.Add(new HttpStatusCodeInformation("401", "Access denied"));
			Codes.Add(new HttpStatusCodeInformation("401.1", "Logon failed"));
			Codes.Add(new HttpStatusCodeInformation("401.2", "Logon failed due to server configuration"));
			Codes.Add(new HttpStatusCodeInformation("401.3", "Unauthorized due to ACL on resource"));
			Codes.Add(new HttpStatusCodeInformation("401.4", "Authorization failed by filter"));
			Codes.Add(new HttpStatusCodeInformation("401.5", "Authorization failed by ISAPI/CGI application"));
			
			Codes.Add(new HttpStatusCodeInformation("403", "Forbidden"));
			Codes.Add(new HttpStatusCodeInformation("403.1", "Execute access forbidden"));
			Codes.Add(new HttpStatusCodeInformation("403.2", "Read access forbidden"));
			Codes.Add(new HttpStatusCodeInformation("403.3", "Write access forbidden"));
			Codes.Add(new HttpStatusCodeInformation("403.4", "SSL required"));
			Codes.Add(new HttpStatusCodeInformation("403.5", "SSL 128 required"));
			Codes.Add(new HttpStatusCodeInformation("403.6", "IP address rejected"));
			Codes.Add(new HttpStatusCodeInformation("403.7", "Client certificate required"));
			Codes.Add(new HttpStatusCodeInformation("403.8", "Site access denied"));
			Codes.Add(new HttpStatusCodeInformation("403.9", "Forbidden: Too many clients are trying to connect to the Web server"));
			Codes.Add(new HttpStatusCodeInformation("403.10", "Forbidden: Web server is configured to deny Execute access"));
			Codes.Add(new HttpStatusCodeInformation("403.11", "Forbidden: Password has been changed"));
			Codes.Add(new HttpStatusCodeInformation("403.12", "Mapper denied access"));
			Codes.Add(new HttpStatusCodeInformation("403.13", "Client certificate revoked"));
			Codes.Add(new HttpStatusCodeInformation("403.14", "Connection listing denied"));
			Codes.Add(new HttpStatusCodeInformation("403.15", "Forbidden: Client access licenses have exceeded limits on the Web server"));
			Codes.Add(new HttpStatusCodeInformation("403.16", "Client certificate is untrusted or invalid"));
			Codes.Add(new HttpStatusCodeInformation("403.17", "Client certificate has expired or is not yet valid"));
			Codes.Add(new HttpStatusCodeInformation("403.18", "Cannot execute requested URL in the current application pool"));
			Codes.Add(new HttpStatusCodeInformation("403.19", "Cannot execute CGI applications for the client in this application poo"));
			Codes.Add(new HttpStatusCodeInformation("403.20", "Forbidden: Passport logon failed"));
			Codes.Add(new HttpStatusCodeInformation("403.21", "Forbidden: Source access denied"));
			Codes.Add(new HttpStatusCodeInformation("403.22", "Forbidden: Infinite depth is denie"));
			
			Codes.Add(new HttpStatusCodeInformation("404", "Not Found"));
			Codes.Add(new HttpStatusCodeInformation("404.0", "Not found"));
			Codes.Add(new HttpStatusCodeInformation("404.1", "Site Not Found"));
			Codes.Add(new HttpStatusCodeInformation("404.2", "ISAPI or CGI restriction"));
			Codes.Add(new HttpStatusCodeInformation("404.3", "MIME type restriction"));
			Codes.Add(new HttpStatusCodeInformation("404.4", "No handler configured"));
			Codes.Add(new HttpStatusCodeInformation("404.5", "Denied by request filtering configuration"));
			Codes.Add(new HttpStatusCodeInformation("404.6", "Verb denied"));
			Codes.Add(new HttpStatusCodeInformation("404.7", "File extension denied"));
			Codes.Add(new HttpStatusCodeInformation("404.8", "Hidden namespace"));
			Codes.Add(new HttpStatusCodeInformation("404.9", "File attribute hidden"));
			Codes.Add(new HttpStatusCodeInformation("404.10", "Request header too long"));
			Codes.Add(new HttpStatusCodeInformation("404.11", "Request contains double escape sequence"));
			Codes.Add(new HttpStatusCodeInformation("404.12", "Request contains high-bit characters"));
			Codes.Add(new HttpStatusCodeInformation("404.13", "Content length too large"));
			Codes.Add(new HttpStatusCodeInformation("404.14", "Request URL too long"));
			Codes.Add(new HttpStatusCodeInformation("404.15", "Query string too long"));
			Codes.Add(new HttpStatusCodeInformation("404.16", "DAV request sent to the static file handler"));
			Codes.Add(new HttpStatusCodeInformation("404.17", "Dynamic content mapped to the static file handler via a wildcard MIME mapping"));
			Codes.Add(new HttpStatusCodeInformation("404.18", "Querystring sequence denied"));
			Codes.Add(new HttpStatusCodeInformation("404.19", "Denied by filtering rule"));

			Codes.Add(new HttpStatusCodeInformation("405", "Method Not Allowed"));
			Codes.Add(new HttpStatusCodeInformation("406", "Not Acceptable"));
			Codes.Add(new HttpStatusCodeInformation("408", "Request Timeout"));
			Codes.Add(new HttpStatusCodeInformation("412", "Precondition Failed"));
			
			// 5xx - Server error
			Codes.Add(new HttpStatusCodeInformation("500", "Internal Server Error"));
			Codes.Add(new HttpStatusCodeInformation("500.0", "Module or ISAPI error occurred"));
			Codes.Add(new HttpStatusCodeInformation("500.11", "Application is shutting down on the Web server"));
			Codes.Add(new HttpStatusCodeInformation("500.12", "Application is busy restarting on the Web server"));
			Codes.Add(new HttpStatusCodeInformation("500.13", "Web server is too busy"));
			Codes.Add(new HttpStatusCodeInformation("500.15", "Direct requests for Global.asax are not allowed"));
			Codes.Add(new HttpStatusCodeInformation("500.19", "Configuration data is invalid"));
			Codes.Add(new HttpStatusCodeInformation("500.21", "Module not recognized"));
			Codes.Add(new HttpStatusCodeInformation("500.22", "An ASP.NET httpModules configuration does not apply in Managed Pipeline mode"));
			Codes.Add(new HttpStatusCodeInformation("500.23", "An ASP.NET httpHandlers configuration does not apply in Managed Pipeline mode"));
			Codes.Add(new HttpStatusCodeInformation("500.24", "An ASP.NET impersonation configuration does not apply in Managed Pipeline mode"));
			Codes.Add(new HttpStatusCodeInformation("500.50", "A rewrite error occurred during RQ_BEGIN_REQUEST notification handling. A configuration or inbound rule execution error occurred. Here is where the distributed rules configuration is read for both inbound and outbound rules"));
			Codes.Add(new HttpStatusCodeInformation("500.51", "A rewrite error occurred during GL_PRE_BEGIN_REQUEST notification handling. A global configuration or global rule execution error occurred.Here is where the global rules configuration is read"));
			Codes.Add(new HttpStatusCodeInformation("500.52", "A rewrite error occurred during RQ_SEND_RESPONSE notification handling. An outbound rule execution occurred"));
			Codes.Add(new HttpStatusCodeInformation("500.53", "A rewrite error occurred during RQ_RELEASE_REQUEST_STATE notification handling. An outbound rule execution error occurred. The rule is configured to be executed before the output user cache gets updated"));
			Codes.Add(new HttpStatusCodeInformation("500.100", "Internal ASP error"));

			Codes.Add(new HttpStatusCodeInformation("501", "Header values specify a configuration that is not implemented"));
			
			Codes.Add(new HttpStatusCodeInformation("502", "Web server received an invalid response while acting as a gateway or proxy"));
			Codes.Add(new HttpStatusCodeInformation("502.1", "CGI application timeout"));
			Codes.Add(new HttpStatusCodeInformation("502.2", "Bad gateway"));

			Codes.Add(new HttpStatusCodeInformation("503", "Service Unavailable"));
			Codes.Add(new HttpStatusCodeInformation("503.0", "Application pool unavailable"));
			Codes.Add(new HttpStatusCodeInformation("503.2", "Concurrent request limit exceeded"));
		}
	}
}
