namespace InterfaceExtension.InterfaceApproach.Interfaces
{
	public interface IUIGridContext : IUIRowContext
	{
		string GetCellValue(string cellId);
		void SetCellValue(string cellId, string value);
		bool IsCellValid(string cellId);
		bool IsCellEnabled(string cellId);
		void SelectCell(string cellId);
		void SetFocus(string cellId);
		void EnterToCell(string value, string cellId);

		bool IsCellPresent(string cellId);
		//string GetHeaderCellValue(GridCell cell);
	}
}
