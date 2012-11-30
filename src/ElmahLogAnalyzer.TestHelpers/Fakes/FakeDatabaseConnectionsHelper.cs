using System;
using System.Collections.Generic;
using System.Linq;
using ElmahLogAnalyzer.Core.Infrastructure.Configuration;

namespace ElmahLogAnalyzer.TestHelpers.Fakes
{
	public class FakeDatabaseConnectionsHelper : IDatabaseConnectionsHelper
	{
		private static readonly List<DatabaseConnectionElement> List = new List<DatabaseConnectionElement>
		{
			new DatabaseConnectionElement
				{
					Type = "SqlServer", 
					Name = "Development",
					Server = @".\sqlexpress",
					Database = "dev_db",
					Schema = "custom",
					Username = "user",
					Password = "password"
				},
			new DatabaseConnectionElement
				{
					Type = "SqlServerCompact", 
					Name = "Development Compact",
					File = "somefile.sdf"
				},
            new DatabaseConnectionElement
			{
				Type = "SqlServer", 
				Name = "IntegratedSecurity",
				Server = @".\sqlexpress",
				Database = "dev_db",
			}
		};

		public DatabaseConnectionElementCollection GetConnections()
		{
			throw new NotImplementedException();
		}

		public List<string> GetNames(string type)
		{
			return List.Where(x => x.Type.Equals(type, StringComparison.InvariantCultureIgnoreCase)).Select(x => x.Name).ToList();
		}

		public DatabaseConnectionElement FindConnection(string name)
		{
			return List.Single(x => x.Name == name);
		}
	}
}
