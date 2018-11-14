using InterfaceExtension.Common;

namespace InterfaceExtension.InterfaceApproach.Interfaces
{
	public interface IUIIconContext : IUIContext
	{
		void ClickTheIcon(string iconId);
		bool IsIconPresent(string iconId);
	}
}
