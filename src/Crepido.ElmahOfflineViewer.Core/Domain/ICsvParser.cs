using System;
using System.Collections.Generic;

namespace Crepido.ElmahOfflineViewer.Core.Domain
{
	public interface ICsvParser
	{
		IEnumerable<KeyValuePair<Uri, DateTime>> Parse(string content);
	}
}