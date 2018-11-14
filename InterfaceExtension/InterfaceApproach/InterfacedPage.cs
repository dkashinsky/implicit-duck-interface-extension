using InterfaceExtension.Common;
using InterfaceExtension.InterfaceApproach.Interfaces;
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
			var options = new List<string> { "Option1", "Option2", "Option3" };
			return options;
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
			throw new NotImplementedException();
		}

		bool IUIFieldContext.IsFieldEnabled(string fieldId)
		{
			throw new NotImplementedException();
		}

		bool IUIFieldContext.IsFieldPresent(string fieldId)
		{
			throw new NotImplementedException();
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
