﻿using InterfaceExtension.Common;
using System;

namespace InterfaceExtension.ExtensionApproach.Extensions
{
	public static class IUIFieldContextExtensions
	{
		public static bool IsFieldPresent(this IUIContext context, string fieldId)
		{
			return Convention.InvokeOverridden(context, () =>
			{
				var elementSelector = context.GetElementSelector(ContextElement.Field, fieldId);
				return Browser.IsElementPresent(elementSelector);
			}, fieldId);
		}

		public static string GetFieldValue(this IUIContext context, string fieldId)
		{
			throw new NotImplementedException();
		}

		public static void SetFieldValue(this IUIContext context, string fieldId, string value)
		{
			throw new NotImplementedException();
		}

		public static bool IsFieldEnabled(this IUIContext context, string fieldId)
		{
			throw new NotImplementedException();
		}
	}
}
