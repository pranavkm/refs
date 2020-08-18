namespace Microsoft.AspNetCore.Components.Web.Virtualization
{
	internal interface IVirtualizeJsCallbacks
	{
		void OnBeforeSpacerVisible(float spacerSize, float containerSize);

		void OnAfterSpacerVisible(float spacerSize, float containerSize);
	}
}
