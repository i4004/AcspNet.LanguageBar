using System.Threading.Tasks;
using AcspNet.Attributes;
using AcspNet.LanguageBar.Views;
using AcspNet.Responses;

namespace AcspNet.LanguageBar.Controllers
{
	/// <summary>
	/// Language bar control
	/// </summary>
	[Priority(-2)]
	public class LanguageBar : AsyncController
	{
		/// <summary>
		/// Invokes the executable extension.
		/// </summary>
		public async override Task<ControllerResponse> Invoke()
		{
			var languagesXml = FileReader.LoadXDocument("Languages.xml");

			return new InlineTpl("LanguageBar", await GetView<LanguageBarView>().Get(languagesXml));
		}
	}
}
