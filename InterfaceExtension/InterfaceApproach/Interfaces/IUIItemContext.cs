using InterfaceExtension.Common;

namespace InterfaceExtension.InterfaceApproach.Interfaces
{
	public interface IUIItemContext : IUIContext
	{
		void ClickTheItem(string itemId);
		bool IsItemPresent(string elementId);
	}
}
