using Microsoft.AspNetCore.Components.Rendering;

namespace Microsoft.AspNetCore.Components.Web
{
	/// <summary>
	/// Provides methods for building a collection of <see cref="T:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame" /> entries.
	/// </summary>
	public static class WebRenderTreeBuilderExtensions
	{
		/// <summary>
		/// Appends a frame representing an instruction to prevent the default action
		/// for a specified event.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder" />.</param>
		/// <param name="sequence">An integer that represents the position of the instruction in the source code.</param>
		/// <param name="eventName">The name of the event to be affected.</param>
		/// <param name="value">True if the default action is to be prevented, otherwise false.</param>
		public static void AddEventPreventDefaultAttribute(this RenderTreeBuilder builder, int sequence, string eventName, bool value)
		{
			throw null;
		}

		/// <summary>
		/// Appends a frame representing an instruction to stop the specified event from
		/// propagating beyond the current element.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder" />.</param>
		/// <param name="sequence">An integer that represents the position of the instruction in the source code.</param>
		/// <param name="eventName">The name of the event to be affected.</param>
		/// <param name="value">True if propagation should be stopped here, otherwise false.</param>
		public static void AddEventStopPropagationAttribute(this RenderTreeBuilder builder, int sequence, string eventName, bool value)
		{
			throw null;
		}
	}
}
