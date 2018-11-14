using InterfaceExtension.Common;
using InterfaceExtension.InterfaceApproach.Interfaces;
using InterfaceExtension.Utils;
using System;
using System.Collections.Generic;

namespace InterfaceExtension.InterfaceApproach
{
	/// <summary>
	/// although page implements only few interface methods it still requires all interface methods to be present
	/// </summary>
	public partial class InterfacedPage : IUIContext, IUIFieldContext, IUIButtonContext, IUIDropdownContext// , etc..
	{
		void IUIDropdownContext.ClickDropdownLink(string fieldId, string button)
		{
			throw new NotImplementedException();
		}

		void IUIButtonContext.ClickTheButton(string buttonId)
		{
			throw new NotImplementedException();
		}

		List<string> IUIDropdownContext.GetDropdownOptions(string fieldId)
		{
			//all ui contexts that implement this interface without specific steps will need to copy this code across all implementations,
			//or use some base class. As we have a lot of interfaces, this base class can bacome a super container which contains base implementations for
			//all known interfaces in order to support steps execution
			var elementSelector = GetElementSelector(ContextElement.Field, fieldId);
			return Browser.GetDropdownOptions(elementSelector);
		}

		ElementSelector IUIContext.GetElementSelector(ContextElement elementType, string elementId)
		{
			throw new NotImplementedException();
		}

		string IUIFieldContext.GetFieldValue(string fieldId)
		{
			throw new NotImplementedException();
		}

		bool IUIButtonContext.IsButtonEnabled(string buttonId)
		{
			throw new NotImplementedException();
		}

		bool IUIButtonContext.IsButtonPresent(string buttonId)
		{
			//all ui contexts that implement this interface without specific steps will need to copy this code across all implementations,
			//or use some base class. As we have a lot of interfaces, this base class can bacome a super container which contains base implementations for
			//all known interfaces in order to support steps execution
			var elementSelector = GetElementSelector(ContextElement.Button, buttonId);
			return Browser.IsElementPresent(elementSelector);
		}

		bool IUIFieldContext.IsFieldEnabled(string fieldId)
		{
			throw new NotImplementedException();
		}

		bool IUIFieldContext.IsFieldPresent(string fieldId)
		{
			//some specific stuff so interface is reasonable
			if (fieldId == Field.LastName)
			{
				Highlighter.ConsoleWriteLine($"Specific approach to check if element ({fieldId}) is present...", ConsoleColor.Red);
				return false;
			}

			var elementSelector = GetElementSelector(ContextElement.Field, fieldId);
			return Browser.IsElementPresent(elementSelector);
		}

		void IUIDropdownContext.SelectDropdownOption(string fieldId, string option)
		{
			throw new NotImplementedException();
		}

		void IUIFieldContext.SetFieldValue(string fieldId, string value)
		{
			throw new NotImplementedException();
		}
	}
}
