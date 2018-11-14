using InterfaceExtension.Common;

namespace InterfaceExtension.InterfaceApproach.Interfaces
{

	public interface IUIValidationContext : IUIContext
	{
		string GetValidationMessage(ContextElement element, string elementId);
	}
}
