using AcspNet.Attributes;
using AcspNet.Modules;
using AcspNet.Responses;

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
		/// Invokes the controller.
		/// </summary>
		/// <returns></returns>
		public override ControllerResponse Invoke()
		{
			var language = !string.IsNullOrEmpty(Context.Form["Language"]) ? Context.Form["Language"] : Context.Query["lang"];

			if (language != null)
				LanguageManager.SetCookieLanguage(language);

			return new Redirect(RedirectionType.PreviousPage);
		}
	}
}
