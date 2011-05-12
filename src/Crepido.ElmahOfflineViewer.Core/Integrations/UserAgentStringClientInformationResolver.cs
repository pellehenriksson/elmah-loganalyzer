using System;
using Crepido.ElmahOfflineViewer.Core.Common;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Cache;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Web;

namespace Crepido.ElmahOfflineViewer.Core.Integrations
{
	public class UserAgentStringClientInformationResolver : IClientInformationResolver
	{
		private readonly IWebRequestHelper _webRequestHelper;
		private readonly ICacheHelper _cacheHeper;

		private const string Url = "http://useragentstring.com";

		public UserAgentStringClientInformationResolver(IWebRequestHelper webRequestHelper, ICacheHelper cacheHeper)
		{
			_webRequestHelper = webRequestHelper;
			_cacheHeper = cacheHeper;
		}

		public ClientInformation Resolve(string httpUserAgent)
		{
			if (httpUserAgent == null)
			{
				throw new ArgumentNullException("httpUserAgent");
			}

			if (!httpUserAgent.HasValue())
			{
				return new ClientInformation();
			}

			var url = BuildUrl(httpUserAgent);

			var result = _cacheHeper.Get<ClientInformation>(url);

			if (result != null)
			{
				return result;
			}

			var response = _webRequestHelper.Request(url);
			var values = DictionaryBuilder.BuildFromText(response);
			
			result = new ClientInformation
			         	{
			         		Platform = values[UserAgentStringParameters.OsType],
			         		OperatingSystem = values[UserAgentStringParameters.OsName],
			         		Browser = values[UserAgentStringParameters.AgentName] + " " + values[UserAgentStringParameters.AgentVersion]
			         	};

			_cacheHeper.Set(url, result);

			return result;
		}
		
		private static string BuildUrl(string httpUserAgent)
		{
			var querystring = System.Net.WebUtility.HtmlEncode(httpUserAgent);
			return string.Format("{0}?uas={1}&getText=all", Url, querystring);
		}
	}
}
