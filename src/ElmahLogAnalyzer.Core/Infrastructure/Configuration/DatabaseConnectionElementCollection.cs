using System.Configuration;

namespace ElmahLogAnalyzer.Core.Infrastructure.Configuration
{
	public class DatabaseConnectionElementCollection : ConfigurationElementCollection
	{
		public DatabaseConnectionElement this[int index]
		{
			get
			{
				return BaseGet(index) as DatabaseConnectionElement;
			}

			set
			{
				if (BaseGet(index) != null)
				{
					BaseRemoveAt(index);
				}

				BaseAdd(index, value);
			}
		}

		protected override ConfigurationElement CreateNewElement()
		{
			return new DatabaseConnectionElement();
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((DatabaseConnectionElement)element).Name;
		}
	}
}
