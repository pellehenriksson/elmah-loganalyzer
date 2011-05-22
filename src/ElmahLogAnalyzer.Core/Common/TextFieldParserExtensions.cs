using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;

namespace ElmahLogAnalyzer.Core.Common
{
	internal static class TextFieldParserExtensions
	{
		public static IEnumerable<string[]> Read(this TextFieldParser parser)
		{
			while (!parser.EndOfData)
			{
				yield return parser.ReadFields();
			}
		}
	}
}