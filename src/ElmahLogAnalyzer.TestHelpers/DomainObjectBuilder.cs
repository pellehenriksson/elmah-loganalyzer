using System;
using ElmahLogAnalyzer.Core.Constants;
using ElmahLogAnalyzer.Core.Domain;

namespace ElmahLogAnalyzer.TestHelpers
{
	public static class DomainObjectBuilder
	{
		public static ErrorLog CreateFakeErrorLog()
		{
			var errorLog = new ErrorLog();
			errorLog.Time = new DateTime(2011, 6, 4, 11, 6, 0);
			errorLog.Type = "System.InvalidOperationException";
			errorLog.Source = "System.Web.Mvc";
			errorLog.SetStatusCodeInformation(new HttpStatusCodeInformation("500", "Internal error"));

			errorLog.AddServerVariable(HttpServerVariables.Url, "/some/url");

			errorLog.Message =
				"The IControllerFactory 'Sodra.PP.Web.Helpers.UnityMapControllerFactory' did not return a controller for the name 'seh'.";

			errorLog.Details = @"System.InvalidOperationException: The IControllerFactory 'Sodra.PP.Web.Helpers.UnityMapControllerFactory' did not return a controller for the name 'seh'.
   at System.Web.Mvc.MvcHandler.ProcessRequestInit(HttpContextBase httpContext, IController& controller, IControllerFactory& factory)
   at System.Web.Mvc.MvcHandler.BeginProcessRequest(HttpContextBase httpContext, AsyncCallback callback, Object state)
   at System.Web.HttpApplication.CallHandlerExecutionStep.System.Web.HttpApplication.IExecutionStep.Execute()
   at System.Web.HttpApplication.ExecuteStep(IExecutionStep step, Boolean& completedSynchronously)";

			return errorLog;
		}
	}
}
