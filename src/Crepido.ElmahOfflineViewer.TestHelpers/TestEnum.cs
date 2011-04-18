using System.ComponentModel;

namespace Crepido.ElmahOfflineViewer.TestHelpers
{
	public enum TestEnum
	{
		[Description("Hello world")]
		ValueWithDescriptionAttribute,
		ValueWithNoDescriptionAttribute
	}
}
