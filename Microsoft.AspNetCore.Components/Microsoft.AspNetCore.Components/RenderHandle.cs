using Microsoft.AspNetCore.Components.RenderTree;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// Allows a component to interact with its renderer.
	/// </summary>
	public readonly struct RenderHandle
	{
		private readonly Renderer _renderer;

		private readonly int _componentId;

		/// <summary>
		/// Gets the <see cref="T:Microsoft.AspNetCore.Components.Dispatcher" /> associated with the component.
		/// </summary>
		public Dispatcher Dispatcher
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets a value that indicates whether the <see cref="T:Microsoft.AspNetCore.Components.RenderHandle" /> has been
		/// initialized and is ready to use.
		/// </summary>
		public bool IsInitialized
		{
			get
			{
				throw null;
			}
		}

		internal RenderHandle(Renderer renderer, int componentId)
		{
			throw null;
		}

		/// <summary>
		/// Notifies the renderer that the component should be rendered.
		/// </summary>
		/// <param name="renderFragment">The content that should be rendered.</param>
		public void Render(RenderFragment renderFragment)
		{
			throw null;
		}
	}
}
