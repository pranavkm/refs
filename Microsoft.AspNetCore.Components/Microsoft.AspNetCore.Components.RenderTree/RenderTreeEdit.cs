using System.Runtime.InteropServices;

namespace Microsoft.AspNetCore.Components.RenderTree
{
	/// <summary>
	/// Types in the Microsoft.AspNetCore.Components.RenderTree are not recommended for use outside
	/// of the Blazor framework. These types will change in future release.
	/// </summary>
	[StructLayout(LayoutKind.Explicit)]
	public readonly struct RenderTreeEdit
	{
		/// <summary>
		/// Gets the type of the edit operation.
		/// </summary>
		[FieldOffset(0)]
		public readonly RenderTreeEditType Type;

		/// <summary>
		/// Gets the index of the sibling frame that the edit relates to.
		/// </summary>
		[FieldOffset(4)]
		public readonly int SiblingIndex;

		/// <summary>
		/// Gets the index of related data in an associated render frames array. For example, if the
		/// <see cref="F:Microsoft.AspNetCore.Components.RenderTree.RenderTreeEdit.Type" /> value is <see cref="F:Microsoft.AspNetCore.Components.RenderTree.RenderTreeEditType.PrependFrame" />, gets the
		/// index of the new frame data in an associated render tree.
		/// </summary>
		[FieldOffset(8)]
		public readonly int ReferenceFrameIndex;

		/// <summary>
		/// If the <see cref="F:Microsoft.AspNetCore.Components.RenderTree.RenderTreeEdit.Type" /> value is <see cref="F:Microsoft.AspNetCore.Components.RenderTree.RenderTreeEditType.PermutationListEntry" />,
		/// gets the sibling index to which the frame should be moved.
		/// </summary>
		[FieldOffset(8)]
		public readonly int MoveToSiblingIndex;

		/// <summary>
		/// If the <see cref="F:Microsoft.AspNetCore.Components.RenderTree.RenderTreeEdit.Type" /> value is <see cref="F:Microsoft.AspNetCore.Components.RenderTree.RenderTreeEditType.RemoveAttribute" />,
		/// gets the name of the attribute that is being removed.
		/// </summary>
		[FieldOffset(16)]
		public readonly string RemovedAttributeName;

		internal static RenderTreeEdit RemoveFrame(int siblingIndex)
		{
			throw null;
		}

		internal static RenderTreeEdit PrependFrame(int siblingIndex, int referenceFrameIndex)
		{
			throw null;
		}

		internal static RenderTreeEdit UpdateText(int siblingIndex, int referenceFrameIndex)
		{
			throw null;
		}

		internal static RenderTreeEdit UpdateMarkup(int siblingIndex, int referenceFrameIndex)
		{
			throw null;
		}

		internal static RenderTreeEdit SetAttribute(int siblingIndex, int referenceFrameIndex)
		{
			throw null;
		}

		internal static RenderTreeEdit RemoveAttribute(int siblingIndex, string name)
		{
			throw null;
		}

		internal static RenderTreeEdit StepIn(int siblingIndex)
		{
			throw null;
		}

		internal static RenderTreeEdit StepOut()
		{
			throw null;
		}

		internal static RenderTreeEdit PermutationListEntry(int fromSiblingIndex, int toSiblingIndex)
		{
			throw null;
		}

		internal static RenderTreeEdit PermutationListEnd()
		{
			throw null;
		}
	}
}
