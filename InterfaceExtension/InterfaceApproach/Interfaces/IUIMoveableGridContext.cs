namespace InterfaceExtension.InterfaceApproach.Interfaces
{
	public interface IUIMoveableGridContext : IUIGridContext
	{
		void MoveRow(int sourceRowId, int targetRowId);
	}
}
