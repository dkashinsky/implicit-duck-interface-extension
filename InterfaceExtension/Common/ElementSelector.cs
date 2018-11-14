namespace InterfaceExtension.Common
{
	public class ElementSelector
	{
		public string CSSSelector { get; set; }

		public ElementSelector(string cssSelector)
		{
			CSSSelector = cssSelector;
		}
	}
}
