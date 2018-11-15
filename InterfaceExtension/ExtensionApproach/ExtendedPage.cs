using InterfaceExtension.Common;
using InterfaceExtension.ExtensionApproach.Extensions;
using InterfaceExtension.Utils;
using System;

namespace InterfaceExtension.ExtensionApproach
{
	/// <remarks>
	/// as we use extensions - no need to use interfaces. the only drawback is that we use hidden convension.
	/// </remarks>
	public partial class ExtendedPage
	{
		[Override]
		public bool IsFieldPresent(string fieldId)
		{
			if (fieldId == Field.LastName)
			{
				Highlighter.ConsoleWriteLine($"Specific approach to check if element ({fieldId}) is present...", ConsoleColor.Red);
				return false;
			}

			var elementSelector = GetElementSelector(ContextElement.Field, fieldId);
			return Browser.IsElementPresent(elementSelector);
		}
	}
}
