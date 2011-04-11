using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace Crepido.ElmahOfflineViewer.UnitTests._TestFiles
{
	public static class TestFilesHelper
	{
		private const string Namespace = "Crepido.ElmahOfflineViewer.UnitTests._TestFiles";

		public static string GetError1()
		{
			var resourceStream = GetFile("error-2011-03-25073303Z.xml");
			return GetContent(resourceStream, Encoding.UTF8);
		}

		public static string GetError2()
		{
			var resourceStream = GetFile("error-2011-03-25073319Z.xml");
			return GetContent(resourceStream, Encoding.UTF8);
		}

		public static string GetError3()
		{
			var resourceStream = GetFile("error-2011-03-25073422Z.xml");
			return GetContent(resourceStream, Encoding.UTF8);
		}

		public static string GetInvalidErrorFile()
		{
			var resourceStream = GetFile("error-invalidfile.xml");
			return GetContent(resourceStream, Encoding.UTF8);
		}
		
		/// <summary>
		/// Return content from stream
		/// </summary>
		/// <param name="resourceStream">The resource stream</param>
		/// <param name="encoding">The encoding</param>
		/// <returns>The content</returns>
		private static string GetContent(Stream resourceStream, Encoding encoding)
		{
			var content = string.Empty;

			using (TextReader textReader = new StreamReader(resourceStream, encoding))
			{
				content = textReader.ReadToEnd();
			}

			return content;
		}

		/// <summary>
		/// Get file stream from assembly
		/// </summary>
		/// <param name="name">The name of the file</param>
		/// <returns>Stream</returns>
		private static Stream GetFile(string name)
		{
			var thisAssembly = Assembly.GetExecutingAssembly();
			var filename = string.Format("{0}.{1}", Namespace, name);
			var resourceStream = thisAssembly.GetManifestResourceStream(filename);

			if (resourceStream == null)
			{
				throw new Exception(string.Format("The file: {0} was not found in assembly: {1}", filename, thisAssembly.FullName));
			}

			return resourceStream;
		}
	}
}
