using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.VisualBasic.FileIO;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public class CsvParser
	{
		public Dictionary<Uri, DateTime> Parse(string content)
		{
			var bytes = Encoding.ASCII.GetBytes(content);
			var stream = new MemoryStream(bytes);

			var parser = new TextFieldParser(stream) { TextFieldType = FieldType.Delimited };
			parser.SetDelimiters(",");

			var result = new Dictionary<Uri, DateTime>();

			var hasPassedHeaderRow = false;
			while (!parser.EndOfData)
			{
				var currentRow = parser.ReadFields();

				if (hasPassedHeaderRow)
				{
					var date = Convert.ToDateTime(currentRow[2]);
					var detailsUrl = new Uri(currentRow[9]);

					result.Add(detailsUrl, date);
				}

				hasPassedHeaderRow = true;
			}

			stream.Close();
			stream.Dispose();

			return result;
		}
	}
}
