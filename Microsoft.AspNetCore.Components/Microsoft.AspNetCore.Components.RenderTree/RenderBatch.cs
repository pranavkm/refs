using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.RenderTree
{
	/// <summary>
	/// Types in the Microsoft.AspNetCore.Components.RenderTree are not recommended for use outside
	/// of the Blazor framework. These types will change in a future release.
	/// </summary>
	public readonly struct RenderBatch
	{
		/// <summary>
		/// Gets the changes to components that were added or updated.
		/// </summary>
		public ArrayRange<RenderTreeDiff> UpdatedComponents
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets render frames that may be referenced by entries in <see cref="P:Microsoft.AspNetCore.Components.RenderTree.RenderBatch.UpdatedComponents" />.
		/// For example, edit entries of type <see cref="F:Microsoft.AspNetCore.Components.RenderTree.RenderTreeEditType.PrependFrame" />
		/// will point to an entry in this array to specify the subtree to be prepended.
		/// </summary>
		public ArrayRange<RenderTreeFrame> ReferenceFrames
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the IDs of the components that were disposed.
		/// </summary>
		public ArrayRange<int> DisposedComponentIDs
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the IDs of the event handlers that were disposed.
		/// </summary>
		public ArrayRange<ulong> DisposedEventHandlerIDs
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal RenderBatch(ArrayRange<RenderTreeDiff> updatedComponents, ArrayRange<RenderTreeFrame> referenceFrames, ArrayRange<int> disposedComponentIDs, ArrayRange<ulong> disposedEventHandlerIDs)
		{
			throw null;
		}
	}
}
