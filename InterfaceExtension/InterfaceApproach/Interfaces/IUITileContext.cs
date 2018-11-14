using InterfaceExtension.Common;

namespace InterfaceExtension.InterfaceApproach.Interfaces
{
	public interface IUITileContext : IUIContext
	{
		void SetFocus(string tileId);
		void ClickTheTile(string tileId);
		int GetTilesCount();
	}
}
