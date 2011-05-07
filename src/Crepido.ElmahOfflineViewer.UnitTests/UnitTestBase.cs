using System;
using Crepido.ElmahOfflineViewer.Core.Common;
using Crepido.ElmahOfflineViewer.Core.Domain;

namespace Crepido.ElmahOfflineViewer.UnitTests
{
	public abstract class UnitTestBase
	{
		protected static string FakeLogsDirectory
		{
			get { return @"c:\logs"; }
		}

		protected static ErrorLog CreateFakeErrorLog()
		{
			var errorLog = new ErrorLog();
			errorLog.Type = "System.InvalidOperationException";
			errorLog.Source = "System.Web.Mvc";
			errorLog.Message =
				"The IControllerFactory 'Sodra.PP.Web.Helpers.UnityMapControllerFactory' did not return a controller for the name 'seh'.";

			errorLog.Details = @"System.InvalidOperationException: The IControllerFactory 'Sodra.PP.Web.Helpers.UnityMapControllerFactory' did not return a controller for the name 'seh'.
   at System.Web.Mvc.MvcHandler.ProcessRequestInit(HttpContextBase httpContext, IController& controller, IControllerFactory& factory)
   at System.Web.Mvc.MvcHandler.BeginProcessRequest(HttpContextBase httpContext, AsyncCallback callback, Object state)
   at System.Web.HttpApplication.CallHandlerExecutionStep.System.Web.HttpApplication.IExecutionStep.Execute()
   at System.Web.HttpApplication.ExecuteStep(IExecutionStep step, Boolean& completedSynchronously)";

			return errorLog;
		}
		
		protected static ReportQuery CreateReportQuery()
		{
			return new ReportQuery(ReportTypeEnum.Type, new DateInterval(new DateTime(1975, 5, 14), new DateTime(2011, 4, 8)));
		}
	}
}
