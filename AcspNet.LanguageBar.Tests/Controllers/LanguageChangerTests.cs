using System.Collections.Generic;
using AcspNet.LanguageBar.Controllers;
using Microsoft.Owin;
using Moq;
using NUnit.Framework;

namespace AcspNet.LanguageBar.Tests.Controllers
{
	[TestFixture]
	public class LanguageChangerTests
	{
		[Test]
		public void Invoke_FormLanguageAvailable_FormLanguageSetAsCookie()
		{
			// Assign

			var c = new Mock<LanguageChanger> { CallBase = true };
			c.SetupGet(x => x.Context.Form)
				.Returns(new FormCollection(new Dictionary<string, string[]> { { "Language", new[] { "ru" } } }));
			c.SetupGet(x => x.Context.Query)
				.Returns(new ReadableStringCollection(new Dictionary<string, string[]> { { "lang", new[] { "en" } } }));
			c.Setup(x => x.LanguageManager.SetCookieLanguage(It.IsAny<string>()));

			// Act
			c.Object.Invoke();

			// Assert
			c.Verify(x => x.LanguageManager.SetCookieLanguage(It.Is<string>(d => d == "ru")));
		}

		[Test]
		public void Invoke_NoFormLanguage_QueryLanguageSetAsCookie()
		{
			// Assign

			var c = new Mock<LanguageChanger> { CallBase = true };
			c.SetupGet(x => x.Context.Form)
				.Returns(new FormCollection(new Dictionary<string, string[]>()));
			c.SetupGet(x => x.Context.Query)
				.Returns(new ReadableStringCollection(new Dictionary<string, string[]> { { "lang", new[] { "en" } } }));
			c.Setup(x => x.LanguageManager.SetCookieLanguage(It.IsAny<string>()));

			// Act
			c.Object.Invoke();

			// Assert
			c.Verify(x => x.LanguageManager.SetCookieLanguage(It.Is<string>(d => d == "en")));
		}

		[Test]
		public void Invoke_NoLanguageInFormAndQuery_NoLanguageSet()
		{
			// Assign

			var c = new Mock<LanguageChanger> { CallBase = true };
			c.SetupGet(x => x.Context.Form)
				.Returns(new FormCollection(new Dictionary<string, string[]>()));
			c.SetupGet(x => x.Context.Query)
				.Returns(new ReadableStringCollection(new Dictionary<string, string[]>()));
			c.Setup(x => x.LanguageManager.SetCookieLanguage(It.IsAny<string>()));

			// Act
			c.Object.Invoke();

			// Assert
			c.Verify(x => x.LanguageManager.SetCookieLanguage(It.IsAny<string>()), Times.Never);
		}
	}
}