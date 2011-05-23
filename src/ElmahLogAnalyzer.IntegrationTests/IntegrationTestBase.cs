using System;
using System.IO;

namespace ElmahLogAnalyzer.IntegrationTests
{
	public abstract class IntegrationTestBase
	{
		public string TestFilesDirectory
		{
			get { return Path.Combine(Directory.GetCurrentDirectory(), "_TestFiles"); }
		}
		
		public string TestArea
		{
			get { return Path.Combine(Directory.GetCurrentDirectory(), "_TestArea"); }
		}
		
		public string TestCvsFile
		{
			get { return Path.Combine(TestFilesDirectory, "errorlog.csv"); }
		}

		public string ExistingUrl
		{
			get { return "http://www.google.com"; }
		}

		public string NonExistantUrl
		{
			get { return "http://www.bluttanblä.com"; }
		}
	}
}
