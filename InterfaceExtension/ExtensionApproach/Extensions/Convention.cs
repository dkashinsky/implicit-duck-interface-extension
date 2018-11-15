using InterfaceExtension.Common;
using System;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace InterfaceExtension.ExtensionApproach.Extensions
{
	public static class Convention
	{
		private static bool VerifyMethodSignature(MethodBase extension, MethodBase instance)
		{
			var extensionParams = extension.GetParameters().Skip(1).Select(param => param.ParameterType).ToArray();
			var instanceParams = instance.GetParameters().Select(param => param.ParameterType).ToArray();

			if (instanceParams.Length != extensionParams.Length)
				return false;

			if (!instanceParams.SequenceEqual(extensionParams))
				return false;

			var extensionInfo = extension as MethodInfo;
			var instanceInfo = instance as MethodInfo;
			if (instanceInfo?.ReturnType != extensionInfo?.ReturnType)
				return false;

			return instance.GetCustomAttribute<OverrideAttribute>() != null;
		}

		/// <remarks>
		/// TODO: need to find a better way to invoke instance method and pass paramethers
		/// </remarks>
		public static void InvokeOverridden(this IUIContext context, Action defaultImplementation, params object[] parameters)
		{
			StackTrace stackTrace = new StackTrace();
			var caller = stackTrace.GetFrame(1).GetMethod();
			var overridden = context.GetType().GetMethod(caller.Name);
			if (overridden != null && VerifyMethodSignature(caller, overridden))
				overridden.Invoke(context, parameters);
			else
				defaultImplementation.Invoke();
				
		}

		/// <remarks>
		/// TODO: need to find a better way to invoke instance method and pass paramethers
		/// </remarks>
		public static T InvokeOverridden<T>(this IUIContext context, Func<T> defaultImplementation, params object[] parameters)
		{
			StackTrace stackTrace = new StackTrace();
			var caller = stackTrace.GetFrame(1).GetMethod();
			var overridden = context.GetType().GetMethod(caller.Name);
			if (overridden != null && VerifyMethodSignature(caller, overridden))
				return (T)overridden.Invoke(context, parameters);
			else
				return defaultImplementation.Invoke();
		}
	}
}
