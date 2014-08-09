using AcspNet.Attributes;
using AcspNet.LanguageBar.Views;
using AcspNet.Responses;

namespace AcspNet.LanguageBar.Controllers
{
	/// <summary>
	/// Language bar control
	/// </summary>
	[Priority(2)]
	public class LanguageBar : Controller
	{
		/// <summary>
		/// Invokes the executable extension.
		/// </summary>
		public override IControllerResponse Invoke()
		{
			var languagesXml = FileReader.LoadXDocument("Languages.xml");

			return new InlineTpl("LanguageBar", GetView<LanguageBarView>().Get(languagesXml));
		}
	}
}
