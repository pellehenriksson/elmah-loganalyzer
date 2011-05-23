using System;
using ElmahLogAnalyzer.Core.Common;
using NUnit.Framework;

namespace ElmahLogAnalyzer.UnitTests.Common
{
	[TestFixture]
	public class DictionaryBuilderTests : UnitTestBase
	{
		[Test]
		public void BuildFromText_WithDefaultSeparators_BuildsDictionaryFromText()
		{
			// arrange
			const string text = "agent_type=Browser;agent_name=Internet Explorer;agent_version=7.0;os_type=Windows;os_name=Windows XP;os_versionName=;os_versionNumber=;os_producer=;os_producerURL=;linux_distibution=Null;agent_language=;agent_languageTag=;";
			
			// act
			var result = DictionaryBuilder.BuildFromText(text);

			// assert
			Assert.That(result.Count, Is.EqualTo(13));
		}

		[Test]
		public void BuildFromText_TextIsNull_Throws()
		{
			// arrange

			// act
			var result = Assert.Throws<ArgumentNullException>(() => DictionaryBuilder.BuildFromText(null));

			// assert
			Assert.That(result, Is.Not.Null);
			Assert.That(result.ParamName, Is.EqualTo("text"));
		}

		[Test]
		public void BuildFromText_TextIsEmpty_ReturnsEmptyDictionary()
		{
			// arrange

			// act
			var result = DictionaryBuilder.BuildFromText(string.Empty);

			// assert
			Assert.That(result.Count, Is.EqualTo(0));
		}

		[Test]
		public void BuildFromText_ValueIsMissingFromKeyValuePair_ValueIsEmptyString()
		{
			// arrange
			const string text = "key=";

			// act
			var result = DictionaryBuilder.BuildFromText(text);
			
			// assert
			Assert.That(result["key"], Is.EqualTo(string.Empty));
		}

		[Test]
		public void BuildFromText_NoKeyValuePairChar()
		{
			// arrange
			const string text = "key";

			var result = DictionaryBuilder.BuildFromText(text);

			// assert
			Assert.That(result["key"], Is.EqualTo(string.Empty));
		}
	}
}
