using System;

namespace InterfaceExtension.ExtensionApproach.Extensions
{
	[AttributeUsage(AttributeTargets.Method)]
	public class OverrideAttribute : Attribute
	{
		//public Type BaseClass { get; set; }
		//public string MethodName { get; set; }

		public OverrideAttribute()
		{
			//TODO: add ability to set base method which should be overridden
		}
	}
}
