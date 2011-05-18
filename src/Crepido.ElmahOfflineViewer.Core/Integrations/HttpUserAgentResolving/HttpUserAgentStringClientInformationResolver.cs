using System;
using Crepido.ElmahOfflineViewer.Core.Common;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Cache;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Web;

namespace Crepido.ElmahOfflineViewer.Core.Integrations.HttpUserAgentResolving
{
	public class HttpUserAgentStringClientInformationResolver : IClientInformationResolver
	{
		private readonly IWebRequestHelper _webRequestHelper;
		private readonly ICacheHelper _cacheHeper;

		private const string Url = "http://useragentstring.com";

		public HttpUserAgentStringClientInformationResolver(IWebRequestHelper webRequestHelper, ICacheHelper cacheHeper)
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

			var result = _cacheHeper.Get<ClientInformation>(url.AbsoluteUri);

			if (result != null)
			{
				return result;
			}

			var response = _webRequestHelper.Uri(url);
			var values = DictionaryBuilder.BuildFromText(response);
			
			result = new ClientInformation
						{
							Platform = values[UserAgentStringParameters.OsType],
							OperatingSystem = values[UserAgentStringParameters.OsName],
							Browser = values[UserAgentStringParameters.AgentName] + " " + values[UserAgentStringParameters.AgentVersion]
						};

			_cacheHeper.Set(url.AbsoluteUri, result);

			return result;
		}
		
		private static Uri BuildUrl(string httpUserAgent)
		{
			var querystring = Uri.EscapeDataString(httpUserAgent);
			return new Uri(string.Format("{0}?uas={1}&getText=all", Url, querystring));
		}
	}
}
