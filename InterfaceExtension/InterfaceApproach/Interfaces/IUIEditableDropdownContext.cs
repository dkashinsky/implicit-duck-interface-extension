namespace InterfaceExtension.InterfaceApproach.Interfaces
{
	public interface IUIEditableDropdownContext : IUIDropdownContext
	{
		void ClickEditIcon(string fieldId, string option);
		bool IsEditIconPresent(string fieldId, string option);
	}
}
