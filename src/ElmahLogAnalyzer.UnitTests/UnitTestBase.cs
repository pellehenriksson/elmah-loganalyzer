using System;
using ElmahLogAnalyzer.Core.Common;
using ElmahLogAnalyzer.Core.Domain;

namespace ElmahLogAnalyzer.UnitTests
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

		protected static string GetCsvContent()
		{
			return @"
Application,Host,Time,Unix Time,Type,Source,User,Status Code,Message,URL
,ALVA,2011-05-18 08:07:18,1305706038.9967,System.Web.HttpException,System.Web,alva\per,404,Path '/Views/' was not found.,http://localhost:51046/elmah.axd/detail?id=246185cb-23ae-492d-b40a-3556a40a3cf0
,ALVA,2011-05-17 13:08:24,1305637704.5790,System.Web.HttpException,System.Web,alva\per,404,Path '/Views/Arbetsrapport/Registrera.aspx' was not found.,http://localhost:51046/elmah.axd/detail?id=22809d08-aa26-49d7-915f-24f433c451ba
,ALVA,2011-05-17 13:02:55,1305637375.6302,System.Web.HttpException,System.Web,alva\per,404,Path '/Views/Arbetsrapport/Registrera.aspx' was not found.,http://localhost:51046/elmah.axd/detail?id=7b689534-21d9-4371-96bb-625dafb8ffb8
,ALVA,2011-05-17 13:00:28,1305637228.7908,System.Web.HttpCompileException,System.Web,alva\per,500,c:\Projects\Crepido\v1.5.0\src\Sodra.PP\Sodra.PP.Web\Views\Arbetsrapport\RegistreraArbetsrapportEntry.ascx(5): error CS1061: 'Sodra.PP.Domain.Core.ViewModels.Arbetsrapport.ArbetsrapportViewModel' does not contain a definition for 'FinnsPaSkapadFaktura' and no extension method 'FinnsPaSkapadFaktura' accepting a first argument of type 'Sodra.PP.Domain.Core.ViewModels.Arbetsrapport.ArbetsrapportViewModel' could be found (are you missing a using directive or an assembly reference?),http://localhost:51046/elmah.axd/detail?id=e671cd53-097d-4dc7-aead-697ee2072303
,ALVA,2011-05-17 12:52:07,1305636727.9726,System.Web.HttpException,System.Web,alva\per,404,Path '/Views/Arbetsrapport/Registrera.aspx' was not found.,http://localhost:51046/elmah.axd/detail?id=61250580-c96f-47b1-93bb-23a9e0e63b86
,ALVA,2011-05-17 12:49:36,1305636576.3828,System.Web.HttpException,System.Web,alva\per,404,Path '/Views/Arbetsrapport/Registrera.aspx' was not found.,http://localhost:51046/elmah.axd/detail?id=4bf4f7ec-5bcf-4b57-bfac-1a7218c7255f
,ALVA,2011-05-17 12:44:14,1305636254.3320,System.Web.HttpException,System.Web,alva\per,404,Path '/Views/Arbetsrapport/Registrera.aspx' was not found.,http://localhost:51046/elmah.axd/detail?id=882d5663-fd2b-4258-b344-88cfbca65513
,ALVA,2011-05-17 12:37:02,1305635822.3120,System.Web.HttpException,System.Web,alva\per,404,Path '/Views/Arbetsrapport/Registrera.aspx' was not found.,http://localhost:51046/elmah.axd/detail?id=60767812-6b29-407c-8efb-0ab3811a5bdf
,ALVA,2011-05-10 08:18:30,1305015510.6571,NHibernate.PropertyNotFoundException,mscorlib,alva\per,0,Could not find a setter for property 'Trakttyp' in class 'Sodra.PP.Domain.Core.ViewModels.Faktura.KontrollFakturaListaViewModel',http://localhost:51046/elmah.axd/detail?id=214f533a-cf8d-4738-a2b2-255b5504f910
,ALVA,2011-05-10 08:12:39,1305015159.2409,System.ArgumentNullException,mscorlib,alva\per,0,""Value cannot be null.
Parameter name: source"",http://localhost:51046/elmah.axd/detail?id=ee1539b7-7e2a-41a6-a970-d018557b447b";
		}
	}
}
