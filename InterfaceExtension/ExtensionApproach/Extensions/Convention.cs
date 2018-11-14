using InterfaceExtension.Common;
using System;
using System.Diagnostics;

namespace InterfaceExtension.ExtensionApproach.Extensions
{
	public static class Convention
	{
		/// <remarks>
		/// TODO: need to find a better way to invoke instance method and pass paramethers
		/// </remarks>
		public static void InvokeOverridden(this IUIContext context, Action defaultImplementation, params object[] parameters)
		{
			StackTrace stackTrace = new StackTrace();
			var caller = stackTrace.GetFrame(1).GetMethod();
			var overridden = context.GetType().GetMethod(caller.Name);
			if (overridden == null)
				defaultImplementation.Invoke();
			else
				overridden.Invoke(context, parameters);
		}

		/// <remarks>
		/// TODO: need to find a better way to invoke instance method and pass paramethers
		/// </remarks>
		public static T InvokeOverridden<T>(this IUIContext context, Func<T> defaultImplementation, params object[] parameters)
		{
			StackTrace stackTrace = new StackTrace();
			var caller = stackTrace.GetFrame(1).GetMethod();
			var overridden = context.GetType().GetMethod(caller.Name);
			if (overridden == null)
				return defaultImplementation.Invoke();
			else
				return (T)overridden.Invoke(context, parameters);
		}
	}
}
