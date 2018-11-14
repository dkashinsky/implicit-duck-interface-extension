using InterfaceExtension.Common;
using System.Collections.Generic;

namespace InterfaceExtension.InterfaceApproach.Interfaces
{
	public interface IUIDropdownContext : IUIContext
	{
		List<string> GetDropdownOptions(string fieldId);
		void ClickDropdownLink(string fieldId, string button);
		void SelectDropdownOption(string fieldId, string option);
	}
}
