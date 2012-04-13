using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace ElmahLogAnalyzer.Core.Infrastructure.Configuration
{
	public class DatabaseConnectionsHelper : IDatabaseConnectionsHelper
	{
		private static readonly DatabaseConnectionsSection Section;

		static DatabaseConnectionsHelper()
		{
			Section = (DatabaseConnectionsSection)ConfigurationManager.GetSection("databaseConnections");
		}

		public DatabaseConnectionElementCollection GetConnections()
		{
			return Section.Settings;
		}

		public List<string> GetNames(string type)
		{
			return Section.Settings
							.Cast<DatabaseConnectionElement>()
								.Where(x => x.Type.Equals(type, StringComparison.InvariantCultureIgnoreCase))
								.OrderBy(x => x.Name)
								.Select(x => x.Name)
								.ToList();
		}

		public DatabaseConnectionElement FindConnection(string name)
		{
			return Section.Settings
							.Cast<DatabaseConnectionElement>()
							.FirstOrDefault(x => x.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase));
		}
	}
}
