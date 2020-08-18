using Microsoft.AspNetCore.Components.RenderTree;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components.Rendering
{
	/// <summary>
	/// Tracks the rendering state associated with an <see cref="T:Microsoft.AspNetCore.Components.IComponent" /> instance
	/// within the context of a <see cref="T:Microsoft.AspNetCore.Components.RenderTree.Renderer" />. This is an internal implementation
	/// detail of <see cref="T:Microsoft.AspNetCore.Components.RenderTree.Renderer" />.
	/// </summary>
	internal class ComponentState : IDisposable
	{
		public int ComponentId
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public IComponent Component
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public ComponentState ParentComponentState
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public RenderTreeBuilder CurrentRenderTree
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Constructs an instance of <see cref="T:Microsoft.AspNetCore.Components.Rendering.ComponentState" />.
		/// </summary>
		/// <param name="renderer">The <see cref="T:Microsoft.AspNetCore.Components.RenderTree.Renderer" /> with which the new instance should be associated.</param>
		/// <param name="componentId">The externally visible identifier for the <see cref="T:Microsoft.AspNetCore.Components.IComponent" />. The identifier must be unique in the context of the <see cref="T:Microsoft.AspNetCore.Components.RenderTree.Renderer" />.</param>
		/// <param name="component">The <see cref="T:Microsoft.AspNetCore.Components.IComponent" /> whose state is being tracked.</param>
		/// <param name="parentComponentState">The <see cref="T:Microsoft.AspNetCore.Components.Rendering.ComponentState" /> for the parent component, or null if this is a root component.</param>
		public ComponentState(Renderer renderer, int componentId, IComponent component, ComponentState parentComponentState)
		{
			throw null;
		}

		public void RenderIntoBatch(RenderBatchBuilder batchBuilder, RenderFragment renderFragment)
		{
			throw null;
		}

		public bool TryDisposeInBatch(RenderBatchBuilder batchBuilder, [NotNullWhen(false)] out Exception? exception)
		{
			throw null;
		}

		public Task NotifyRenderCompletedAsync()
		{
			throw null;
		}

		public void SetDirectParameters(ParameterView parameters)
		{
			throw null;
		}

		public void NotifyCascadingValueChanged(in ParameterViewLifetime lifetime)
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}

		public Task DisposeInBatchAsync(RenderBatchBuilder batchBuilder)
		{
			throw null;
		}
	}
}
