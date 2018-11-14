using InterfaceExtension.Common;

namespace InterfaceExtension.InterfaceApproach.Interfaces
{
	public interface IUIButtonContext : IUIContext
	{
		void ClickTheButton(string buttonId);
		bool IsButtonEnabled(string buttonId);
		bool IsButtonPresent(string buttonId);
	}
}
