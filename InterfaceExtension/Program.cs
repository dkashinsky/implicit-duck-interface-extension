using InterfaceExtension.Common;
using InterfaceExtension.InterfaceApproach;
using InterfaceExtension.InterfaceApproach.Interfaces;
using System;

namespace InterfaceExtension
{
	class Program
	{
		static void Main(string[] args)
		{
			InterfaceTest();
			Console.ReadLine();
		}

		public static void InterfaceTest()
		{
			Console.WriteLine("Test started...");

			IUIContext context = new InterfacedPage();
			Console.WriteLine("Page loaded");

			//check page controls
			string fieldId = "LastName";
			IUIFieldContext fieldContext = context as IUIFieldContext;
			Console.WriteLine("{0} field is present: {1}", fieldId, fieldContext.IsFieldPresent(fieldId));

			string buttonId = "Save";
			IUIButtonContext buttonContext = context as IUIButtonContext;
			Console.WriteLine("{0} button is present: {1}", buttonId, buttonContext.IsButtonPresent(buttonId));

			Console.WriteLine("Test finished...");
		}
	}
}
