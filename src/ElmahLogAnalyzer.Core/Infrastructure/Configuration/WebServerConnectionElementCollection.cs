using System.Configuration;

namespace ElmahLogAnalyzer.Core.Infrastructure.Configuration
{
	public class WebServerConnectionElementCollection : ConfigurationElementCollection
	{
		public WebServerConnectionElement this[int index]
		{
			get
			{
				return BaseGet(index) as WebServerConnectionElement;
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
			return new WebServerConnectionElement();
		}

		protected override object GetElementKey(ConfigurationElement element)
		{
			return ((WebServerConnectionElement)element).Url;
		}
	}
}
