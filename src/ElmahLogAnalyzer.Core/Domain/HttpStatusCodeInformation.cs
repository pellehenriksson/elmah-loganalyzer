namespace ElmahLogAnalyzer.Core.Domain
{
	public class HttpStatusCodeInformation
	{
		public HttpStatusCodeInformation()
		{
			Code = string.Empty;
			Description = string.Empty;
		}

		public HttpStatusCodeInformation(string code, string description)
		{
			Code = code;
			Description = description;
		}

		public string Code { get; private set; }

		public string Description { get; private set; }

		public string DisplayName
		{
			get { return string.Format("{0} {1}", Code, Description); }
		}
	}
}