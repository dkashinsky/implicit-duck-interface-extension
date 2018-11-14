using InterfaceExtension.Common;
using System;
using System.Collections.Generic;

namespace InterfaceExtension.ExtensionApproach
{
	public partial class ExtendedPage : IUIContext
	{
		public static class Field
		{
			public const string FirstName = "FirstName";
			public const string LastName = "LastName";
			public const string Gender = "Gender";
		}

		public static class Button
		{
			public const string Save = "Save";
			public const string Cancel = "Cancel";
		}

		public static Dictionary<string, string> Fields = new Dictionary<string, string> {
			{ Field.FirstName, "input[type=text][name=firstName]" },
			{ Field.LastName, "input[type=text][name=lastName]" },
			{ Field.Gender, "select[name=gender]" }
		};

		public static Dictionary<string, string> Buttons = new Dictionary<string, string> {
			{ Button.Save, "input[type=button][name=save]" },
			{ Button.Cancel, "input[type=button][name=cancel]" }
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
