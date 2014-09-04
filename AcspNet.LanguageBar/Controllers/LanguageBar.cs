using AcspNet.LanguageBar.Views;
using AcspNet.Responses;

namespace AcspNet.LanguageBar.Controllers
{
	/// <summary>
	/// Language bar control
	/// </summary>
	public class LanguageBar : Controller
	{
		/// <summary>
		/// Invokes the executable extension.
		/// </summary>
		public override ControllerResponse Invoke()
		{
			var languagesXml = FileReader.LoadXDocument("App_Packages/AcspNet.LanguageBar/Languages.xml");

			return new InlineTpl("LanguageBar", GetView<LanguageBarView>().Get(languagesXml));
		}
	}
}
