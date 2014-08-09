using AcspNet.Attributes;

namespace AcspNet.LanguageBar.Controllers
{
	/// <summary>
	/// Language bar language changer
	/// </summary>
	[Post("changeLanguage")]
	[Priority(-9)]
	public class LanguageChanger : Controller
	{
		/// <summary>
		/// Invokes the executable extension.
		/// </summary>
		public override IControllerResponse Invoke()
		{
			var language = !string.IsNullOrEmpty(Context.Form["Language"]) ? Context.Form["Language"] : Context.Query["lang"];

			if (language != null)
				LanguageManager.SetCookieLanguage(language);

			return new Navigate(NavigateType.ToPreviousPage);
		}
	}
}
