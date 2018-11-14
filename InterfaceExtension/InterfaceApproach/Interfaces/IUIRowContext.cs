using InterfaceExtension.Common;

namespace InterfaceExtension.InterfaceApproach.Interfaces
{
	public interface IUIRowContext : IUIContext
	{
		void SelectRow(int rowIndex);
		int GetRowsCount();
	}
}
