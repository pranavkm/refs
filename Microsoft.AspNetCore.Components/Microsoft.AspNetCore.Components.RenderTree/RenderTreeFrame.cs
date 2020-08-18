using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Runtime.InteropServices;

namespace Microsoft.AspNetCore.Components.RenderTree
{
	/// <summary>
	/// Types in the Microsoft.AspNetCore.Components.RenderTree are not recommended for use outside
	/// of the Blazor framework. These types will change in future release.
	/// </summary>
	[StructLayout(LayoutKind.Explicit, Pack = 4)]
	public struct RenderTreeFrame
	{
		[FieldOffset(0)]
		internal int SequenceField;

		[FieldOffset(4)]
		internal RenderTreeFrameType FrameTypeField;

		[FieldOffset(8)]
		internal int ElementSubtreeLengthField;

		[FieldOffset(16)]
		internal string ElementNameField;

		[FieldOffset(24)]
		internal object ElementKeyField;

		[FieldOffset(16)]
		internal string TextContentField;

		[FieldOffset(8)]
		internal ulong AttributeEventHandlerIdField;

		[FieldOffset(16)]
		internal string AttributeNameField;

		[FieldOffset(24)]
		internal object AttributeValueField;

		[FieldOffset(32)]
		internal string AttributeEventUpdatesAttributeNameField;

		[FieldOffset(8)]
		internal int ComponentSubtreeLengthField;

		[FieldOffset(12)]
		internal int ComponentIdField;

		[FieldOffset(16)]
		internal Type ComponentTypeField;

		[FieldOffset(24)]
		internal ComponentState ComponentStateField;

		[FieldOffset(32)]
		internal object ComponentKeyField;

		[FieldOffset(8)]
		internal int RegionSubtreeLengthField;

		[FieldOffset(16)]
		internal string ElementReferenceCaptureIdField;

		[FieldOffset(24)]
		internal Action<ElementReference> ElementReferenceCaptureActionField;

		[FieldOffset(8)]
		internal int ComponentReferenceCaptureParentFrameIndexField;

		[FieldOffset(16)]
		internal Action<object> ComponentReferenceCaptureActionField;

		[FieldOffset(16)]
		internal string MarkupContentField;

		/// <summary>
		/// Gets the sequence number of the frame. Sequence numbers indicate the relative source
		/// positions of the instructions that inserted the frames. Sequence numbers are only
		/// comparable within the same sequence (typically, the same source method).
		/// </summary>
		public int Sequence
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Describes the type of this frame.
		/// </summary>
		public RenderTreeFrameType FrameType
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// If the <see cref="P:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame.FrameType" /> property equals <see cref="F:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrameType.Element" />
		/// gets the number of frames in the subtree for which this frame is the root.
		/// The value is zero if the frame has not yet been closed.
		/// </summary>
		public int ElementSubtreeLength
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// If the <see cref="P:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame.FrameType" /> property equals <see cref="F:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrameType.Element" />,
		/// gets a name representing the type of the element. Otherwise, the value is undefined.
		/// </summary>
		public string ElementName
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// If the <see cref="P:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame.FrameType" /> property equals <see cref="F:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrameType.Element" />,
		/// gets the element's diffing key, or null if none was specified.
		/// </summary>
		public object ElementKey
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// If the <see cref="P:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame.FrameType" /> property equals <see cref="F:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrameType.Text" />,
		/// gets the content of the text frame. Otherwise, the value is undefined.
		/// </summary>
		public string TextContent
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// If the <see cref="P:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame.FrameType" /> property equals <see cref="F:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrameType.Attribute" />
		/// gets the ID of the corresponding event handler, if any.
		/// </summary>
		public ulong AttributeEventHandlerId
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// If the <see cref="P:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame.FrameType" /> property equals <see cref="F:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrameType.Attribute" />,
		/// gets the attribute name. Otherwise, the value is undefined.
		/// </summary>
		public string AttributeName
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// If the <see cref="P:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame.FrameType" /> property equals <see cref="F:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrameType.Attribute" />,
		/// gets the attribute value. Otherwise, the value is undefined.
		/// </summary>
		public object AttributeValue
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// If the <see cref="P:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame.FrameType" /> property equals <see cref="F:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrameType.Attribute" />,
		/// and the attribute represents an event handler, gets the name of another attribute whose value
		/// can be updated to represent the UI state prior to executing the event handler. This is
		/// primarily used in two-way bindings.
		/// </summary>
		public string AttributeEventUpdatesAttributeName
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// If the <see cref="P:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame.FrameType" /> property equals <see cref="F:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrameType.Component" />
		/// gets the number of frames in the subtree for which this frame is the root.
		/// The value is zero if the frame has not yet been closed.
		/// </summary>
		public int ComponentSubtreeLength
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// If the <see cref="P:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame.FrameType" /> property equals <see cref="F:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrameType.Component" />,
		/// gets the child component instance identifier.
		/// </summary>
		public int ComponentId
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// If the <see cref="P:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame.FrameType" /> property equals <see cref="F:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrameType.Component" />,
		/// gets the type of the child component.
		/// </summary>
		public Type ComponentType
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// If the <see cref="P:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame.FrameType" /> property equals <see cref="F:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrameType.Component" />,
		/// gets the child component state object. Otherwise, the value is undefined.
		/// </summary>
		internal ComponentState ComponentState
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// If the <see cref="P:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame.FrameType" /> property equals <see cref="F:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrameType.Component" />,
		/// gets the component's diffing key, or null if none was specified.
		/// </summary>
		public object ComponentKey
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// If the <see cref="P:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame.FrameType" /> property equals <see cref="F:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrameType.Component" />,
		/// gets the child component instance. Otherwise, the value is undefined.
		/// </summary>
		public IComponent Component
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// If the <see cref="P:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame.FrameType" /> property equals <see cref="F:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrameType.Region" />
		/// gets the number of frames in the subtree for which this frame is the root.
		/// The value is zero if the frame has not yet been closed.
		/// </summary>
		public int RegionSubtreeLength
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// If the <see cref="P:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame.FrameType" /> property equals <see cref="F:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrameType.ElementReferenceCapture" />,
		/// gets the ID of the reference capture. Otherwise, the value is undefined.
		/// </summary>
		public string ElementReferenceCaptureId
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// If the <see cref="P:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame.FrameType" /> property equals <see cref="F:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrameType.ElementReferenceCapture" />,
		/// gets the action that writes the reference to its target. Otherwise, the value is undefined.
		/// </summary>
		public Action<ElementReference> ElementReferenceCaptureAction
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// If the <see cref="P:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame.FrameType" /> property equals <see cref="F:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrameType.ComponentReferenceCapture" />,
		/// gets the index of the parent frame representing the component being captured. Otherwise, the value is undefined.
		/// WARNING: This index can only be used in the context of the frame's original render tree. If the frame is
		///          copied elsewhere, such as to the ReferenceFrames buffer of a RenderTreeDiff, then the index will
		///          not relate to entries in that other buffer.
		///          Currently there's no scenario where this matters, but if there was, we could change all of the subtree
		///          initialization logic in RenderTreeDiffBuilder to walk the frames hierarchically, then it would know
		///          the parent index at the point where it wants to initialize the ComponentReferenceCapture frame.
		/// </summary>
		public int ComponentReferenceCaptureParentFrameIndex
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// If the <see cref="P:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame.FrameType" /> property equals <see cref="F:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrameType.ComponentReferenceCapture" />,
		/// gets the action that writes the reference to its target. Otherwise, the value is undefined.
		/// </summary>
		public Action<object> ComponentReferenceCaptureAction
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// If the <see cref="P:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame.FrameType" /> property equals <see cref="F:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrameType.Markup" />,
		/// gets the content of the markup frame. Otherwise, the value is undefined.
		/// </summary>
		public string MarkupContent
		{
			get
			{
				throw null;
			}
		}

		internal static RenderTreeFrame Element(int sequence, string elementName)
		{
			throw null;
		}

		internal static RenderTreeFrame Text(int sequence, string textContent)
		{
			throw null;
		}

		internal static RenderTreeFrame Markup(int sequence, string markupContent)
		{
			throw null;
		}

		internal static RenderTreeFrame Attribute(int sequence, string name, object value)
		{
			throw null;
		}

		internal static RenderTreeFrame ChildComponent(int sequence, Type componentType)
		{
			throw null;
		}

		internal static RenderTreeFrame PlaceholderChildComponentWithSubtreeLength(int subtreeLength)
		{
			throw null;
		}

		internal static RenderTreeFrame Region(int sequence)
		{
			throw null;
		}

		internal static RenderTreeFrame ElementReferenceCapture(int sequence, Action<ElementReference> elementReferenceCaptureAction)
		{
			throw null;
		}

		internal static RenderTreeFrame ComponentReferenceCapture(int sequence, Action<object> componentReferenceCaptureAction, int parentFrameIndex)
		{
			throw null;
		}

		internal RenderTreeFrame WithElementSubtreeLength(int elementSubtreeLength)
		{
			throw null;
		}

		internal RenderTreeFrame WithComponentSubtreeLength(int componentSubtreeLength)
		{
			throw null;
		}

		internal RenderTreeFrame WithAttributeSequence(int sequence)
		{
			throw null;
		}

		internal RenderTreeFrame WithComponent(ComponentState componentState)
		{
			throw null;
		}

		internal RenderTreeFrame WithAttributeEventHandlerId(ulong eventHandlerId)
		{
			throw null;
		}

		internal RenderTreeFrame WithAttributeValue(object attributeValue)
		{
			throw null;
		}

		internal RenderTreeFrame WithAttributeEventUpdatesAttributeName(string attributeUpdatesAttributeName)
		{
			throw null;
		}

		internal RenderTreeFrame WithRegionSubtreeLength(int regionSubtreeLength)
		{
			throw null;
		}

		internal RenderTreeFrame WithElementReferenceCaptureId(string elementReferenceCaptureId)
		{
			throw null;
		}

		internal RenderTreeFrame WithElementKey(object elementKey)
		{
			throw null;
		}

		internal RenderTreeFrame WithComponentKey(object componentKey)
		{
			throw null;
		}

		/// <inheritdoc />
		public override string ToString()
		{
			throw null;
		}
	}
}
