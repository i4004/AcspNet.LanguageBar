using System.Linq;
using System.Xml.Linq;
using Simplify.Templates;

namespace AcspNet.LanguageBar.Views
{
	public class LanguageBarView : View
	{
		public ITemplate Get(XDocument languages)
		{
			var data = "";

			var tpl = TemplateFactory.Load("App_Packages/AcspNet.LanguageBar/LanguageBar");

			if (languages != null && languages.Root != null)
				foreach (var item in from r in languages.Root.Elements("item") select r)
					data += string.Format("<option value=\"{0}\"{1}>{2}</option>", (string)item.Attribute("value"),
						Language == (string)item.Attribute("value") ? " selected=\"selected\"" : "",
						(string)item.Attribute("name"));

			tpl.Set("LanguagesList", data);
			return tpl;
		}
	}
}