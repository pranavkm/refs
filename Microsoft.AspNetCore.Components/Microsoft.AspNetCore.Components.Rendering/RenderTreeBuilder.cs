using Microsoft.AspNetCore.Components.RenderTree;
using System;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Components.Rendering
{
	/// <summary>
	/// Provides methods for building a collection of <see cref="T:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame" /> entries.
	/// </summary>
	public sealed class RenderTreeBuilder : IDisposable
	{
		/// <summary>
		/// Appends a frame representing an element, i.e., a container for other frames.
		/// In order for the <see cref="T:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder" /> state to be valid, you must
		/// also call <see cref="M:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder.CloseElement" /> immediately after appending the
		/// new element's child frames.
		/// </summary>
		/// <param name="sequence">An integer that represents the position of the instruction in the source code.</param>
		/// <param name="elementName">A value representing the type of the element.</param>
		public void OpenElement(int sequence, string elementName)
		{
			throw null;
		}

		/// <summary>
		/// Marks a previously appended element frame as closed. Calls to this method
		/// must be balanced with calls to <see cref="M:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder.OpenElement(System.Int32,System.String)" />.
		/// </summary>
		public void CloseElement()
		{
			throw null;
		}

		/// <summary>
		/// Appends a frame representing markup content.
		/// </summary>
		/// <param name="sequence">An integer that represents the position of the instruction in the source code.</param>
		/// <param name="markupContent">Content for the new markup frame.</param>
		public void AddMarkupContent(int sequence, string? markupContent)
		{
			throw null;
		}

		/// <summary>
		/// Appends a frame representing text content.
		/// </summary>
		/// <param name="sequence">An integer that represents the position of the instruction in the source code.</param>
		/// <param name="textContent">Content for the new text frame.</param>
		public void AddContent(int sequence, string? textContent)
		{
			throw null;
		}

		/// <summary>
		/// Appends frames representing an arbitrary fragment of content.
		/// </summary>
		/// <param name="sequence">An integer that represents the position of the instruction in the source code.</param>
		/// <param name="fragment">Content to append.</param>
		public void AddContent(int sequence, RenderFragment? fragment)
		{
			throw null;
		}

		/// <summary>
		/// Appends frames representing an arbitrary fragment of content.
		/// </summary>
		/// <param name="sequence">An integer that represents the position of the instruction in the source code.</param>
		/// <param name="fragment">Content to append.</param>
		/// <param name="value">The value used by <paramref name="fragment" />.</param>
		public void AddContent<TValue>(int sequence, RenderFragment<TValue>? fragment, TValue value)
		{
			throw null;
		}

		/// <summary>
		/// Appends a frame representing markup content.
		/// </summary>
		/// <param name="sequence">An integer that represents the position of the instruction in the source code.</param>
		/// <param name="markupContent">Content for the new markup frame.</param>
		public void AddContent(int sequence, MarkupString markupContent)
		{
			throw null;
		}

		/// <summary>
		/// Appends a frame representing text content.
		/// </summary>
		/// <param name="sequence">An integer that represents the position of the instruction in the source code.</param>
		/// <param name="textContent">Content for the new text frame.</param>
		public void AddContent(int sequence, object? textContent)
		{
			throw null;
		}

		/// <summary>
		/// <para>
		/// Appends a frame representing a bool-valued attribute with value 'true'.
		/// </para>
		/// <para>
		/// The attribute is associated with the most recently added element.
		/// </para>
		/// </summary>
		/// <param name="sequence">An integer that represents the position of the instruction in the source code.</param>
		/// <param name="name">The name of the attribute.</param>
		public void AddAttribute(int sequence, string name)
		{
			throw null;
		}

		/// <summary>
		/// <para>
		/// Appends a frame representing a bool-valued attribute.
		/// </para>
		/// <para>
		/// The attribute is associated with the most recently added element. If the value is <c>false</c> and the
		/// current element is not a component, the frame will be omitted.
		/// </para>
		/// </summary>
		/// <param name="sequence">An integer that represents the position of the instruction in the source code.</param>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="value">The value of the attribute.</param>
		public void AddAttribute(int sequence, string name, bool value)
		{
			throw null;
		}

		/// <summary>
		/// <para>
		/// Appends a frame representing a string-valued attribute.
		/// </para>
		/// <para>
		/// The attribute is associated with the most recently added element. If the value is <c>null</c> and the
		/// current element is not a component, the frame will be omitted.
		/// </para>
		/// </summary>
		/// <param name="sequence">An integer that represents the position of the instruction in the source code.</param>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="value">The value of the attribute.</param>
		public void AddAttribute(int sequence, string name, string? value)
		{
			throw null;
		}

		/// <summary>
		/// <para>
		/// Appends a frame representing a delegate-valued attribute.
		/// </para>
		/// <para>
		/// The attribute is associated with the most recently added element. If the value is <c>null</c> and the
		/// current element is not a component, the frame will be omitted.
		/// </para>
		/// </summary>
		/// <param name="sequence">An integer that represents the position of the instruction in the source code.</param>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="value">The value of the attribute.</param>
		public void AddAttribute(int sequence, string name, MulticastDelegate? value)
		{
			throw null;
		}

		/// <summary>
		/// <para>
		/// Appends a frame representing an <see cref="T:Microsoft.AspNetCore.Components.EventCallback" /> attribute.
		/// </para>
		/// <para>
		/// The attribute is associated with the most recently added element. If the value is <c>null</c> and the
		/// current element is not a component, the frame will be omitted.
		/// </para>
		/// </summary>
		/// <param name="sequence">An integer that represents the position of the instruction in the source code.</param>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="value">The value of the attribute.</param>
		/// <remarks>
		/// This method is provided for infrastructure purposes, and is used to support generated code
		/// that uses <see cref="T:Microsoft.AspNetCore.Components.EventCallbackFactory" />.
		/// </remarks>
		public void AddAttribute(int sequence, string name, EventCallback value)
		{
			throw null;
		}

		/// <summary>
		/// <para>
		/// Appends a frame representing an <see cref="T:Microsoft.AspNetCore.Components.EventCallback" /> attribute.
		/// </para>
		/// <para>
		/// The attribute is associated with the most recently added element. If the value is <c>null</c> and the
		/// current element is not a component, the frame will be omitted.
		/// </para>
		/// </summary>
		/// <param name="sequence">An integer that represents the position of the instruction in the source code.</param>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="value">The value of the attribute.</param>
		/// <remarks>
		/// This method is provided for infrastructure purposes, and is used to support generated code
		/// that uses <see cref="T:Microsoft.AspNetCore.Components.EventCallbackFactory" />.
		/// </remarks>
		public void AddAttribute<TArgument>(int sequence, string name, EventCallback<TArgument> value)
		{
			throw null;
		}

		/// <summary>
		/// Appends a frame representing a string-valued attribute.
		/// The attribute is associated with the most recently added element. If the value is <c>null</c>, or
		/// the <see cref="T:System.Boolean" /> value <c>false</c> and the current element is not a component, the
		/// frame will be omitted.
		/// </summary>
		/// <param name="sequence">An integer that represents the position of the instruction in the source code.</param>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="value">The value of the attribute.</param>
		public void AddAttribute(int sequence, string name, object? value)
		{
			throw null;
		}

		/// <summary>
		/// <para>
		/// Appends a frame representing an attribute.
		/// </para>
		/// <para>
		/// The attribute is associated with the most recently added element.
		/// </para>
		/// </summary>
		/// <param name="sequence">An integer that represents the position of the instruction in the source code.</param>
		/// <param name="frame">A <see cref="T:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame" /> holding the name and value of the attribute.</param>
		public void AddAttribute(int sequence, RenderTreeFrame frame)
		{
			throw null;
		}

		/// <summary>
		/// Adds frames representing multiple attributes with the same sequence number.
		/// </summary>
		/// <param name="sequence">An integer that represents the position of the instruction in the source code.</param>
		/// <param name="attributes">A collection of key-value pairs representing attributes.</param>
		public void AddMultipleAttributes(int sequence, IEnumerable<KeyValuePair<string, object>>? attributes)
		{
			throw null;
		}

		/// <summary>
		/// <para>
		/// Indicates that the preceding attribute represents an event handler
		/// whose execution updates the attribute with name <paramref name="updatesAttributeName" />.
		/// </para>
		/// <para>
		/// This information is used by the rendering system to determine whether
		/// to accept a value update for the other attribute when receiving a
		/// call to the event handler.
		/// </para>
		/// </summary>
		/// <param name="updatesAttributeName">The name of another attribute whose value can be updated when the event handler is executed.</param>
		public void SetUpdatesAttributeName(string updatesAttributeName)
		{
			throw null;
		}

		/// <summary>
		/// Appends a frame representing a child component.
		/// </summary>
		/// <typeparam name="TComponent">The type of the child component.</typeparam>
		/// <param name="sequence">An integer that represents the position of the instruction in the source code.</param>
		public void OpenComponent<TComponent>(int sequence) where TComponent : notnull, IComponent
		{
			throw null;
		}

		/// <summary>
		/// Appends a frame representing a child component.
		/// </summary>
		/// <param name="sequence">An integer that represents the position of the instruction in the source code.</param>
		/// <param name="componentType">The type of the child component.</param>
		public void OpenComponent(int sequence, Type componentType)
		{
			throw null;
		}

		/// <summary>
		/// Assigns the specified key value to the current element or component.
		/// </summary>
		/// <param name="value">The value for the key.</param>
		public void SetKey(object? value)
		{
			throw null;
		}

		/// <summary>
		/// Marks a previously appended component frame as closed. Calls to this method
		/// must be balanced with calls to <see cref="M:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder.OpenComponent``1(System.Int32)" />.
		/// </summary>
		public void CloseComponent()
		{
			throw null;
		}

		/// <summary>
		/// Appends a frame representing an instruction to capture a reference to the parent element.
		/// </summary>
		/// <param name="sequence">An integer that represents the position of the instruction in the source code.</param>
		/// <param name="elementReferenceCaptureAction">An action to be invoked whenever the reference value changes.</param>
		public void AddElementReferenceCapture(int sequence, Action<ElementReference> elementReferenceCaptureAction)
		{
			throw null;
		}

		/// <summary>
		/// Appends a frame representing an instruction to capture a reference to the parent component.
		/// </summary>
		/// <param name="sequence">An integer that represents the position of the instruction in the source code.</param>
		/// <param name="componentReferenceCaptureAction">An action to be invoked whenever the reference value changes.</param>
		public void AddComponentReferenceCapture(int sequence, Action<object> componentReferenceCaptureAction)
		{
			throw null;
		}

		/// <summary>
		/// Appends a frame representing a region of frames.
		/// </summary>
		/// <param name="sequence">An integer that represents the position of the instruction in the source code.</param>
		public void OpenRegion(int sequence)
		{
			throw null;
		}

		/// <summary>
		/// Marks a previously appended region frame as closed. Calls to this method
		/// must be balanced with calls to <see cref="M:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder.OpenRegion(System.Int32)" />.
		/// </summary>
		public void CloseRegion()
		{
			throw null;
		}

		/// <summary>
		/// Clears the builder.
		/// </summary>
		public void Clear()
		{
			throw null;
		}

		internal void InsertAttributeExpensive(int insertAtIndex, int sequence, string attributeName, object? attributeValue)
		{
			throw null;
		}

		/// <summary>
		/// Returns the <see cref="T:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame" /> values that have been appended.
		/// </summary>
		/// <returns>An array range of <see cref="T:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame" /> values.</returns>
		public ArrayRange<RenderTreeFrame> GetFrames()
		{
			throw null;
		}

		internal void AssertTreeIsValid(IComponent component)
		{
			throw null;
		}

		internal void ProcessDuplicateAttributes(int first)
		{
			throw null;
		}

		internal void TrackAttributeName(string name)
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}

		public RenderTreeBuilder()
		{
			throw null;
		}
	}
}
