using InterfaceExtension.Common;
using System;
using System.Collections.Generic;

namespace InterfaceExtension.InterfaceApproach
{
	public partial class InterfacedPage : IUIContext
	{
		public static Dictionary<string, string> Fields = new Dictionary<string, string> {
			{ "FirstName", "input[type=text][name=firstName]" },
			{ "LastName", "input[type=text][name=lastName]" }
		};

		public static Dictionary<string, string> Buttons = new Dictionary<string, string> {
			{ "Save", "input[type=button][name=save]" },
			{ "Cancel", "input[type=button][name=cancel]" }
		};

		public static Dictionary<ContextElement, Dictionary<string, string>> Elements = new Dictionary<ContextElement, Dictionary<string, string>>()
		{
			{ ContextElement.Field, Fields },
			{ ContextElement.Button, Buttons }
		};

		public ElementSelector GetElementSelector(ContextElement elementType, string elementId)
		{
			if (Elements.ContainsKey(elementType) && Elements[elementType].ContainsKey(elementId))
				return new ElementSelector(Elements[elementType][elementId]);

			throw new NotSupportedException("Element is not supported by current context");
		}
	}
}
