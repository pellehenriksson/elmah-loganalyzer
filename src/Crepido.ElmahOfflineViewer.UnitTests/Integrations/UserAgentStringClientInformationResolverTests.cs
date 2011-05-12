using System;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Cache;
using Crepido.ElmahOfflineViewer.Core.Infrastructure.Web;
using Crepido.ElmahOfflineViewer.Core.Integrations;
using Moq;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Integrations
{
	[TestFixture]
	public class UserAgentStringClientInformationResolverTests : UnitTestBase
	{
		private const string HttpUserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.1; .NET CLR 1.1.4322; .NET CLR 2.0.50727; .NET CLR 3.0.04506.30; .NET CLR 3.0.04506.648; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729; .NET4.0C; .NET4.0E)";

		[Test]
		public void Resolve_HttpUserAgentIsNull_Throws()
		{
			// arrange
			var cache = new Mock<ICacheHelper>();
			var webrequest = new Mock<IWebRequestHelper>();

			var resolver = new UserAgentStringClientInformationResolver(webrequest.Object, cache.Object);

			// act
			var result = Assert.Throws<ArgumentNullException>(() => resolver.Resolve(null));

			// assert
			Assert.That(result, Is.Not.Null);
			Assert.That(result.ParamName, Is.EqualTo("httpUserAgent"));
		}

		[Test]
		public void Resolve_HttpUserAgentIsEmpty_ReturnsEmptyClientInformation()
		{
			// arrange
			var cache = new Mock<ICacheHelper>();
			var webrequest = new Mock<IWebRequestHelper>();

			var resolver = new UserAgentStringClientInformationResolver(webrequest.Object, cache.Object);

			// act
			var result = resolver.Resolve(string.Empty);

			// assert
			Assert.That(result, Is.Not.Null);

			cache.Verify(x => x.Get<ClientInformation>(It.IsAny<string>()), Times.Never());
			webrequest.Verify(x => x.Request(It.IsAny<string>()), Times.Never());
			cache.Verify(x => x.Set(It.IsAny<string>(), It.IsAny<ClientInformation>()), Times.Never());
		}

		[Test]
		public void Resolve_FoundInCache_ReturnFromCache()
		{
			// arrange
			var cache = new Mock<ICacheHelper>();
			var webrequest = new Mock<IWebRequestHelper>();
			
			var information = new ClientInformation();
			cache.Setup(x => x.Get<ClientInformation>(It.IsAny<string>())).Returns(information);

			var resolver = new UserAgentStringClientInformationResolver(webrequest.Object, cache.Object);
			
			// act
			var result = resolver.Resolve(HttpUserAgent);

			// assert
			Assert.That(result, Is.EqualTo(information));
			webrequest.Verify(x => x.Request(It.IsAny<string>()), Times.Never());
		}

		[Test]
		public void Resolve_NotInCache_MakeWebRequestAndAddToCache()
		{
			// arrange
			var cache = new Mock<ICacheHelper>();
			var webrequest = new Mock<IWebRequestHelper>();

			cache.Setup(x => x.Get<ClientInformation>(It.IsAny<string>())).Returns((ClientInformation)null);

			const string response = "agent_type=Browser;agent_name=Internet Explorer;agent_version=7.0;os_type=Windows;os_name=Windows XP;os_versionName=;os_versionNumber=;os_producer=;os_producerURL=;linux_distibution=Null;agent_language=;agent_languageTag=;";
			webrequest.Setup(x => x.Request(It.IsAny<string>())).Returns(response);

			var resolver = new UserAgentStringClientInformationResolver(webrequest.Object, cache.Object);

			// act
			var result = resolver.Resolve(HttpUserAgent);
			
			// assert
			Assert.That(result, Is.Not.Null);
			cache.Verify(x => x.Set(It.IsAny<string>(), It.IsAny<ClientInformation>()), Times.Once());
		}
	}
}
