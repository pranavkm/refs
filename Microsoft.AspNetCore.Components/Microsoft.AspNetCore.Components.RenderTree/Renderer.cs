using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components.RenderTree
{
	/// <summary>
	/// Types in the Microsoft.AspNetCore.Components.RenderTree are not recommended for use outside
	/// of the Blazor framework. These types will change in a future release.
	/// </summary>
	public abstract class Renderer : IDisposable
	{
		internal static class Log
		{
			public static void InitializingComponent(ILogger logger, ComponentState componentState, ComponentState parentComponentState)
			{
				throw null;
			}

			public static void RenderingComponent(ILogger logger, ComponentState componentState)
			{
				throw null;
			}

			public static void DisposingComponent(ILogger<Renderer> logger, ComponentState componentState)
			{
				throw null;
			}

			public static void HandlingEvent(ILogger<Renderer> logger, ulong eventHandlerId, EventArgs eventArgs)
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the <see cref="T:Microsoft.AspNetCore.Components.Dispatcher" /> associated with this <see cref="T:Microsoft.AspNetCore.Components.RenderTree.Renderer" />.
		/// </summary>
		public abstract Dispatcher Dispatcher
		{
			get;
		}

		/// <summary>
		/// Gets or sets the <see cref="T:Microsoft.AspNetCore.Components.ElementReferenceContext" /> associated with this <see cref="T:Microsoft.AspNetCore.Components.RenderTree.Renderer" />,
		/// if it exists.
		/// </summary>
		protected internal ElementReferenceContext? ElementReferenceContext
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			protected set
			{
				throw null;
			}
		}

		/// <summary>
		/// Allows the caller to handle exceptions from the SynchronizationContext when one is available.
		/// </summary>
		public event UnhandledExceptionEventHandler UnhandledSynchronizationException
		{
			add
			{
				throw null;
			}
			remove
			{
				throw null;
			}
		}

		/// <summary>
		/// Constructs an instance of <see cref="T:Microsoft.AspNetCore.Components.RenderTree.Renderer" />.
		/// </summary>
		/// <param name="serviceProvider">The <see cref="T:System.IServiceProvider" /> to be used when initializing components.</param>
		/// <param name="loggerFactory">The <see cref="T:Microsoft.Extensions.Logging.ILoggerFactory" />.</param>
		public Renderer(IServiceProvider serviceProvider, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		/// <summary>
		/// Constructs an instance of <see cref="T:Microsoft.AspNetCore.Components.RenderTree.Renderer" />.
		/// </summary>
		/// <param name="serviceProvider">The <see cref="T:System.IServiceProvider" /> to be used when initializing components.</param>
		/// <param name="loggerFactory">The <see cref="T:Microsoft.Extensions.Logging.ILoggerFactory" />.</param>
		/// <param name="componentActivator">The <see cref="T:Microsoft.AspNetCore.Components.IComponentActivator" />.</param>
		public Renderer(IServiceProvider serviceProvider, ILoggerFactory loggerFactory, IComponentActivator componentActivator)
		{
			throw null;
		}

		/// <summary>
		/// Constructs a new component of the specified type.
		/// </summary>
		/// <param name="componentType">The type of the component to instantiate.</param>
		/// <returns>The component instance.</returns>
		protected IComponent InstantiateComponent(Type componentType)
		{
			throw null;
		}

		/// <summary>
		/// Associates the <see cref="T:Microsoft.AspNetCore.Components.IComponent" /> with the <see cref="T:Microsoft.AspNetCore.Components.RenderTree.Renderer" />, assigning
		/// an identifier that is unique within the scope of the <see cref="T:Microsoft.AspNetCore.Components.RenderTree.Renderer" />.
		/// </summary>
		/// <param name="component">The component.</param>
		/// <returns>The component's assigned identifier.</returns>
		protected internal int AssignRootComponentId(IComponent component)
		{
			throw null;
		}

		/// <summary>
		/// Gets the current render tree for a given component.
		/// </summary>
		/// <param name="componentId">The id for the component.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder" /> representing the current render tree.</returns>
		protected ArrayRange<RenderTreeFrame> GetCurrentRenderTreeFrames(int componentId)
		{
			throw null;
		}

		/// <summary>
		/// Performs the first render for a root component, waiting for this component and all
		/// children components to finish rendering in case there is any asynchronous work being
		/// done by any of the components. After this, the root component
		/// makes its own decisions about when to re-render, so there is no need to call
		/// this more than once.
		/// </summary>
		/// <param name="componentId">The ID returned by <see cref="M:Microsoft.AspNetCore.Components.RenderTree.Renderer.AssignRootComponentId(Microsoft.AspNetCore.Components.IComponent)" />.</param>
		/// <remarks>
		/// Rendering a root component is an asynchronous operation. Clients may choose to not await the returned task to
		/// start, but not wait for the entire render to complete.
		/// </remarks>
		protected Task RenderRootComponentAsync(int componentId)
		{
			throw null;
		}

		/// <summary>
		/// Performs the first render for a root component, waiting for this component and all
		/// children components to finish rendering in case there is any asynchronous work being
		/// done by any of the components. After this, the root component
		/// makes its own decisions about when to re-render, so there is no need to call
		/// this more than once.
		/// </summary>
		/// <param name="componentId">The ID returned by <see cref="M:Microsoft.AspNetCore.Components.RenderTree.Renderer.AssignRootComponentId(Microsoft.AspNetCore.Components.IComponent)" />.</param>
		/// <param name="initialParameters">The <see cref="T:Microsoft.AspNetCore.Components.ParameterView" />with the initial parameters to use for rendering.</param>
		/// <remarks>
		/// Rendering a root component is an asynchronous operation. Clients may choose to not await the returned task to
		/// start, but not wait for the entire render to complete.
		/// </remarks>
		[AsyncStateMachine(typeof(_003CRenderRootComponentAsync_003Ed__28))]
		[DebuggerStepThrough]
		protected Task RenderRootComponentAsync(int componentId, ParameterView initialParameters)
		{
			throw null;
		}

		/// <summary>
		/// Allows derived types to handle exceptions during rendering. Defaults to rethrowing the original exception.
		/// </summary>
		/// <param name="exception">The <see cref="T:System.Exception" />.</param>
		protected abstract void HandleException(Exception exception);

		/// <summary>
		/// Updates the visible UI.
		/// </summary>
		/// <param name="renderBatch">The changes to the UI since the previous call.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> to represent the UI update process.</returns>
		protected abstract Task UpdateDisplayAsync(in RenderBatch renderBatch);

		/// <summary>
		/// Notifies the renderer that an event has occurred.
		/// </summary>
		/// <param name="eventHandlerId">The <see cref="P:Microsoft.AspNetCore.Components.RenderTree.RenderTreeFrame.AttributeEventHandlerId" /> value from the original event attribute.</param>
		/// <param name="eventArgs">Arguments to be passed to the event handler.</param>
		/// <param name="fieldInfo">Information that the renderer can use to update the state of the existing render tree to match the UI.</param>
		/// <returns>
		/// A <see cref="T:System.Threading.Tasks.Task" /> which will complete once all asynchronous processing related to the event
		/// has completed.
		/// </returns>
		public virtual Task DispatchEventAsync(ulong eventHandlerId, EventFieldInfo fieldInfo, EventArgs eventArgs)
		{
			throw null;
		}

		internal void InstantiateChildComponentOnFrame(ref RenderTreeFrame frame, int parentComponentId)
		{
			throw null;
		}

		internal void AddToPendingTasks(Task task)
		{
			throw null;
		}

		internal void AssignEventHandlerId(ref RenderTreeFrame frame)
		{
			throw null;
		}

		/// <summary>
		/// Schedules a render for the specified <paramref name="componentId" />. Its display
		/// will be populated using the specified <paramref name="renderFragment" />.
		/// </summary>
		/// <param name="componentId">The ID of the component to render.</param>
		/// <param name="renderFragment">A <see cref="T:Microsoft.AspNetCore.Components.RenderFragment" /> that will supply the updated UI contents.</param>
		internal void AddToRenderQueue(int componentId, RenderFragment renderFragment)
		{
			throw null;
		}

		internal void TrackReplacedEventHandlerId(ulong oldEventHandlerId, ulong newEventHandlerId)
		{
			throw null;
		}

		/// <summary>
		/// Processes pending renders requests from components if there are any.
		/// </summary>
		protected virtual void ProcessPendingRender()
		{
			throw null;
		}

		/// <summary>
		/// Releases all resources currently used by this <see cref="T:Microsoft.AspNetCore.Components.RenderTree.Renderer" /> instance.
		/// </summary>
		/// <param name="disposing"><see langword="true" /> if this method is being invoked by <see cref="M:System.IDisposable.Dispose" />, otherwise <see langword="false" />.</param>
		protected virtual void Dispose(bool disposing)
		{
			throw null;
		}

		/// <summary>
		/// Releases all resources currently used by this <see cref="T:Microsoft.AspNetCore.Components.RenderTree.Renderer" /> instance.
		/// </summary>
		public void Dispose()
		{
			throw null;
		}
	}
}
