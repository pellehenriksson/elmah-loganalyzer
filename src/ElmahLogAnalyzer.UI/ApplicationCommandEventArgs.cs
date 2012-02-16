using System;

namespace ElmahLogAnalyzer.UI
{
	public class ApplicationCommandEventArgs : EventArgs
	{
		public ApplicationCommandEventArgs(ApplicationCommands command)
		{
			Command = command;
		}

		public ApplicationCommands Command { get; private set; }
	}
}
