using InterfaceExtension.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExtension.Common
{
	public static class Browser
	{
		public static List<string> GetDropdownOptions(ElementSelector selector)
		{
			Highlighter.ConsoleWriteLine($"Common approach to get options list for dropdown ({selector.CSSSelector})...", ConsoleColor.Green);
			return new List<string> { "Option1", "Option2", "Option3" };
		}

		public static bool IsElementPresent(ElementSelector selector)
		{
			Highlighter.ConsoleWriteLine($"Common approach to check if element ({selector.CSSSelector}) is present...", ConsoleColor.Green);
			return selector != null;
		}
	}
}
