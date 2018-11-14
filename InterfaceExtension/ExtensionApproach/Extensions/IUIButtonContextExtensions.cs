using InterfaceExtension.Common;
using System;

namespace InterfaceExtension.ExtensionApproach.Extensions
{
	public static class IUIButtonContextExtensions
	{
		public static void ClickTheButton(this IUIContext context, string buttonId)
		{
			throw new NotImplementedException();
		}

		public static bool IsButtonEnabled(this IUIContext context, string buttonId)
		{
			throw new NotImplementedException();
		}

		public static bool IsButtonPresent(this IUIContext context, string buttonId)
		{
			return Convention.InvokeOverridden(context, () =>
			{
				var elementSelector = context.GetElementSelector(ContextElement.Button, buttonId);
				return Browser.IsElementPresent(elementSelector);
			}, buttonId);
		}
	}
}
