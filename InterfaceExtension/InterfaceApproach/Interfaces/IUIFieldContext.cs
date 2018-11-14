using InterfaceExtension.Common;

namespace InterfaceExtension.InterfaceApproach.Interfaces
{
	public interface IUIFieldContext : IUIContext
	{
		string GetFieldValue(string fieldId);
		void SetFieldValue(string fieldId, string value);
		bool IsFieldEnabled(string fieldId);
		bool IsFieldPresent(string fieldId);
	}
}
