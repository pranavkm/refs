namespace Microsoft.AspNetCore.Components
{
	internal interface IEventCallback
	{
		bool HasDelegate
		{
			get;
		}

		object? UnpackForRenderTree();
	}
}
