﻿using System;
using Crepido.ElmahOfflineViewer.Core.Domain;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests.Domain
{
	[TestFixture]
	public class ElmahUrlHelperTests : UnitTestBase
	{
		[Test]
		public void ResolveCsvDownloadUrl_ReturnUrl()
		{
			// arrange
			var helper = new ElmahUrlHelper();
			var serverUri = new Uri("http://www.test.com/elmah.axd");

			// act
			var result = helper.ResolveCsvDownloadUrl(serverUri);

			// assert
			Assert.That(result.AbsoluteUri, Is.EqualTo("http://www.test.com/elmah.axd/download"));
		}

		[Test]
		public void ResolveCsvDownloadUrl_ServerUriEndsWithSlash_ReturnUrl()
		{
			// arrange
			var helper = new ElmahUrlHelper();
			var serverUri = new Uri("http://www.test.com/elmah.axd/");

			// act
			var result = helper.ResolveCsvDownloadUrl(serverUri);

			// assert
			Assert.That(result.AbsoluteUri, Is.EqualTo("http://www.test.com/elmah.axd/download"));
		}

		[Test]
		public void ResolveElmahRootUrl_UrlIsDefaultRoot_ReturnsUrl()
		{
			// arrange
			var helper = new ElmahUrlHelper();
			var serverUri = new Uri("http://www.test.com/elmah.axd");

			// act
			var result = helper.ResolveElmahRootUrl(serverUri);

			// assert
			Assert.That(result, Is.EqualTo(serverUri));
		}

		[Test]
		public void ResolveElmahRootUrl_UrlIsMissingElmahExtension_ReturnWithAddedElmahExtension()
		{
			// arrange
			var helper = new ElmahUrlHelper();
			var serverUri = new Uri("http://www.test.com");

			// act
			var result = helper.ResolveElmahRootUrl(serverUri);

			// assert
			Assert.That(result.AbsoluteUri, Is.EqualTo("http://www.test.com/elmah.axd"));
		}
	}
}