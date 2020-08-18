using System;

namespace Microsoft.AspNetCore.Components.RenderTree
{
	/// <summary>
	/// A special subclass of <see cref="T:Microsoft.AspNetCore.Components.RenderTree.ArrayBuilder`1" /> that contains methods optimized for appending <see cref="T:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame" /> entries.
	/// </summary>
	internal class RenderTreeFrameArrayBuilder : ArrayBuilder<RenderTreeFrame>
	{
		public void AppendElement(int sequence, string elementName)
		{
			throw null;
		}

		public void AppendText(int sequence, string textContent)
		{
			throw null;
		}

		public void AppendMarkup(int sequence, string markupContent)
		{
			throw null;
		}

		public void AppendAttribute(int sequence, string attributeName, object? attributeValue)
		{
			throw null;
		}

		public void AppendComponent(int sequence, Type componentType)
		{
			throw null;
		}

		public void AppendElementReferenceCapture(int sequence, Action<ElementReference> elementReferenceCaptureAction)
		{
			throw null;
		}

		public void AppendComponentReferenceCapture(int sequence, Action<object> componentReferenceCaptureAction, int parentFrameIndexValue)
		{
			throw null;
		}

		public void AppendRegion(int sequence)
		{
			throw null;
		}

		public RenderTreeFrameArrayBuilder()
		{
			throw null;
		}
	}
}
