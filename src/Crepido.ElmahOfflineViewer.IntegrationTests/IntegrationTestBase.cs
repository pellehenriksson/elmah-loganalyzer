using System;
using System.IO;

namespace Crepido.ElmahOfflineViewer.IntegrationTests
{
	public abstract class IntegrationTestBase
	{
		public string TestFilesDirectory
		{
			get { return Path.Combine(Directory.GetCurrentDirectory(), "_TestFiles"); }
		}

		public string TestCvsFile
		{
			get { return Path.Combine(TestFilesDirectory, "errorlog.csv"); }
		}

		public Uri ExistingUrl
		{
			get { return new Uri("http://www.google.com"); }
		}

		public Uri NonExistantUrl
		{
			get { return new Uri("http://www.bluttanblä.com"); }
		}
	}
}
