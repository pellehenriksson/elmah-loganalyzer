using System;
using ElmahLogAnalyzer.Core.Domain;

namespace ElmahLogAnalyzer.Core.Presentation
{
	public interface IConnectToDatabaseView : IConnectToDatabaseConnectionInformation
	{
		ErrorLogSources Source { get; }
	}

	public interface IConnectToDatabaseConnectionInformationView : IConnectToDatabaseConnectionInformation
	{
		event EventHandler<OnValidatingEventArgs> OnInputValidated;

		void ForceInputValidation();
	}

	public class OnValidatingEventArgs : EventArgs
	{
		public OnValidatingEventArgs(bool isValid)
		{
			IsValid = isValid;
		}

		public bool IsValid { get; private set; }
	}
}
