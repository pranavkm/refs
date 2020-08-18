namespace Microsoft.AspNetCore.Components.RenderTree
{
	/// <summary>
	/// Types in the Microsoft.AspNetCore.Components.RenderTree are not recommended for use outside
	/// of the Blazor framework. These types will change in future release.
	/// </summary>
	public readonly struct RenderTreeDiff
	{
		/// <summary>
		/// Gets the ID of the component.
		/// </summary>
		public readonly int ComponentId;

		/// <summary>
		/// Gets the changes to the render tree since a previous state.
		/// </summary>
		public readonly ArrayBuilderSegment<RenderTreeEdit> Edits;

		internal RenderTreeDiff(int componentId, ArrayBuilderSegment<RenderTreeEdit> entries)
		{
			throw null;
		}
	}
}
