using InterfaceExtension.Common;
using InterfaceExtension.ExtensionApproach;
using InterfaceExtension.ExtensionApproach.Extensions;
using InterfaceExtension.InterfaceApproach;
using InterfaceExtension.InterfaceApproach.Interfaces;
using System;

namespace InterfaceExtension
{
	class Program
	{
		static void Main(string[] args)
		{
			InterfacedTest();
			Console.ReadLine();

			ExtendedTest();
			Console.ReadLine();
		}

		public static void InterfacedTest()
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

			string dropdownId = "Gender";
			IUIDropdownContext dropdownContext = context as IUIDropdownContext;
			Console.WriteLine("{0} dropdown options: {1}", dropdownId, 
				string.Join(", ", dropdownContext.GetDropdownOptions(dropdownId)));

			Console.WriteLine("Test finished...");
		}

		public static void ExtendedTest()
		{
			Console.WriteLine("Test started...");

			IUIContext context = new ExtendedPage();
			Console.WriteLine("Page loaded");

			//check page controls
			string fieldId = "LastName";
			Console.WriteLine("{0} field is present: {1}", fieldId, context.IsFieldPresent(fieldId));

			string buttonId = "Save";
			Console.WriteLine("{0} button is present: {1}", buttonId, context.IsButtonPresent(buttonId));

			string dropdownId = "Gender";
			Console.WriteLine("{0} dropdown options: {1}", dropdownId,
				string.Join(", ", context.GetDropdownOptions(dropdownId)));

			Console.WriteLine("Test finished...");
		}
	}
}
