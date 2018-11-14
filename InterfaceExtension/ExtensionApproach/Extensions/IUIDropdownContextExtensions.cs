using InterfaceExtension.Common;
using System;
using System.Collections.Generic;

namespace InterfaceExtension.ExtensionApproach.Extensions
{
	public static class IUIDropdownContextExtensions
	{
		public static List<string> GetDropdownOptions(this IUIContext context, string fieldId)
		{
			return Convention.InvokeOverridden(context, () =>
			{
				var elementSelector = context.GetElementSelector(ContextElement.Field, fieldId);
				return Browser.GetDropdownOptions(elementSelector);
			}, fieldId);
		}

		public static void ClickDropdownLink(this IUIContext context, string fieldId, string button)
		{
			throw new NotImplementedException();
		}

		public static void SelectDropdownOption(this IUIContext context, string fieldId, string option)
		{
			throw new NotImplementedException();
		}
	}
}
