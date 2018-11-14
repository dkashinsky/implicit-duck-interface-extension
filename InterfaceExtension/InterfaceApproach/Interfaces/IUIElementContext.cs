using InterfaceExtension.Common;

namespace InterfaceExtension.InterfaceApproach.Interfaces
{
	public interface IUIElementContext : IUIContext
	{
		bool ElementIsInState(ContextElement element, string elementId, string state);
	}
}
