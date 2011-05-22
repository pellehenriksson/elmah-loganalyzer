namespace ElmahLogAnalyzer.Core.Domain
{
	public class ReportItem
	{
		public ReportItem(string key, int count)
		{
			Key = key;
			Count = count;
		}

		public string Key { get; private set; }
		
		public int Count { get; private set; }
	}
}
