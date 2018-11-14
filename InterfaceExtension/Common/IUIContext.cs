namespace InterfaceExtension.Common
{
	public interface IUIContext
	{
		ElementSelector GetElementSelector(ContextElement elementType, string elementId);
	}
}
