using System;
using System.Diagnostics;
using System.Threading;
using Crepido.ElmahOfflineViewer.Core.Domain;
using Crepido.ElmahOfflineViewer.Core.Domain.Abstract;
using Crepido.ElmahOfflineViewer.TestHelpers.Fakes;
using NUnit.Framework;

namespace Crepido.ElmahOfflineViewer.UnitTests
{
	[TestFixture]
	public class Sandbox
	{
		[Test, Ignore]
		public void WriteOutUrls()
		{
			var repository = new ErrorLogRepository(new DataSourceService(new ErrorLogFileParser(new FakeLog()), new FakeLog()));
			repository.Initialize(@"C:\Temp\ELMAH");

			foreach (var log in repository.GetAll())
			{
				Console.WriteLine(log.CleanUrl);
				Console.Out.WriteLine(log.Url);
				Console.WriteLine("-----------------------------------------------------------");
			}
		}

		[Test, Ignore]
		public void Try_StopWatch()
		{
			// arrange
			var watch = new Stopwatch();

			// act
			watch.Start();
			Thread.Sleep(1000);
			watch.Stop();

			// assert
			Console.Out.WriteLine(watch.Elapsed.Seconds);
		}

		[Test, Ignore]
		public void View_Presenter_WireUp_Prototype()
		{
		}
		
		private class Presenter
		{
			private IErrorLogRepository _rep;
			private View _view;

			public Presenter(IErrorLogRepository rep)
			{
				_rep = rep;
				_rep.OnInitialized += delegate
				                      	{
											Initialize();
				                      	};
			}

			public void RegisterView(View view)
			{
				_view = view;
			}

			private void Initialize()
			{
			}
		}

		private class View
		{
			public View(Presenter p)
			{
				p.RegisterView(this);
			}
		}
	}
}
