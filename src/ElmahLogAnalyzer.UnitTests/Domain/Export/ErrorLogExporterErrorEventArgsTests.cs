using System;
using ElmahLogAnalyzer.Core.Domain.Export;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Domain.Export
{
	[TestFixture]
	public class ErrorLogExporterErrorEventArgsTests : UnitTestBase
	{
		[Test]
		public void Ctor_SetsException()
		{
			// arrange
			var error = new InvalidOperationException();

			// act
			var args = new ErrorLogExporterErrorEventArgs(error);

			// assert
			Assert.That(args.Error, Is.EqualTo(error));
		}
	}
}
