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
			//Console.WriteLine($"Getting options for dropdown {selector.CSSSelector}:");
			Console.WriteLine("Common approach to get options list for dropdown...");
			return new List<string> { "Option1", "Option2", "Option3" };
		}

		public static bool IsElementPresent(ElementSelector selector)
		{
			Console.WriteLine("Common approach to check if element is present...");
			return selector != null;
		}
	}
}
