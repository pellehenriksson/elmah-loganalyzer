using System;
using System.Collections.Generic;

namespace ElmahLogAnalyzer.Core.Domain
{
	public interface ICsvParser
	{
		IEnumerable<KeyValuePair<Uri, DateTime>> Parse(string content);
	}
}