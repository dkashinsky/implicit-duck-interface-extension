using InterfaceExtension.Common;

namespace InterfaceExtension.InterfaceApproach.Interfaces
{
	public interface IUIAlertContext : IUIContext
	{
		string GetAlertMessage(string elementId);
	}
}
