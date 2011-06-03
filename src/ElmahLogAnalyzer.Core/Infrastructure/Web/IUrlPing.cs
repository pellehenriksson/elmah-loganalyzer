using System;
using ElmahLogAnalyzer.Core.Domain;

namespace ElmahLogAnalyzer.Core.Infrastructure.Web
{
	public interface IUrlPing
	{
		Tuple<bool, string> Ping(NetworkConnection connection);
	}
}