using System.ComponentModel;

namespace ElmahLogAnalyzer.TestHelpers
{
	public enum TestEnum
	{
		[Description("Hello world")]
		ValueWithDescriptionAttribute,
		ValueWithNoDescriptionAttribute
	}
}
