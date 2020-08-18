using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// Optional base class for components. Alternatively, components may
	/// implement <see cref="T:Microsoft.AspNetCore.Components.IComponent" /> directly.
	/// </summary>
	public abstract class ComponentBase : IComponent, IHandleEvent, IHandleAfterRender
	{
		/// <summary>
		/// Constructs an instance of <see cref="T:Microsoft.AspNetCore.Components.ComponentBase" />.
		/// </summary>
		public ComponentBase()
		{
			throw null;
		}

		/// <summary>
		/// Renders the component to the supplied <see cref="T:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder" />.
		/// </summary>
		/// <param name="builder">A <see cref="T:Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder" /> that will receive the render output.</param>
		protected virtual void BuildRenderTree(RenderTreeBuilder builder)
		{
			throw null;
		}

		/// <summary>
		/// Method invoked when the component is ready to start, having received its
		/// initial parameters from its parent in the render tree.
		/// </summary>
		protected virtual void OnInitialized()
		{
			throw null;
		}

		/// <summary>
		/// Method invoked when the component is ready to start, having received its
		/// initial parameters from its parent in the render tree.
		///
		/// Override this method if you will perform an asynchronous operation and
		/// want the component to refresh when that operation is completed.
		/// </summary>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> representing any asynchronous operation.</returns>
		protected virtual Task OnInitializedAsync()
		{
			throw null;
		}

		/// <summary>
		/// Method invoked when the component has received parameters from its parent in
		/// the render tree, and the incoming values have been assigned to properties.
		/// </summary>
		protected virtual void OnParametersSet()
		{
			throw null;
		}

		/// <summary>
		/// Method invoked when the component has received parameters from its parent in
		/// the render tree, and the incoming values have been assigned to properties.
		/// </summary>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> representing any asynchronous operation.</returns>
		protected virtual Task OnParametersSetAsync()
		{
			throw null;
		}

		/// <summary>
		/// Notifies the component that its state has changed. When applicable, this will
		/// cause the component to be re-rendered.
		/// </summary>
		protected void StateHasChanged()
		{
			throw null;
		}

		/// <summary>
		/// Returns a flag to indicate whether the component should render.
		/// </summary>
		/// <returns></returns>
		protected virtual bool ShouldRender()
		{
			throw null;
		}

		/// <summary>
		/// Method invoked after each time the component has been rendered.
		/// </summary>
		/// <param name="firstRender">
		/// Set to <c>true</c> if this is the first time <see cref="M:Microsoft.AspNetCore.Components.ComponentBase.OnAfterRender(System.Boolean)" /> has been invoked
		/// on this component instance; otherwise <c>false</c>.
		/// </param>
		/// <remarks>
		/// The <see cref="M:Microsoft.AspNetCore.Components.ComponentBase.OnAfterRender(System.Boolean)" /> and <see cref="M:Microsoft.AspNetCore.Components.ComponentBase.OnAfterRenderAsync(System.Boolean)" /> lifecycle methods
		/// are useful for performing interop, or interacting with values received from <c>@ref</c>.
		/// Use the <paramref name="firstRender" /> parameter to ensure that initialization work is only performed
		/// once.
		/// </remarks>
		protected virtual void OnAfterRender(bool firstRender)
		{
			throw null;
		}

		/// <summary>
		/// Method invoked after each time the component has been rendered. Note that the component does
		/// not automatically re-render after the completion of any returned <see cref="T:System.Threading.Tasks.Task" />, because
		/// that would cause an infinite render loop.
		/// </summary>
		/// <param name="firstRender">
		/// Set to <c>true</c> if this is the first time <see cref="M:Microsoft.AspNetCore.Components.ComponentBase.OnAfterRender(System.Boolean)" /> has been invoked
		/// on this component instance; otherwise <c>false</c>.
		/// </param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> representing any asynchronous operation.</returns>
		/// <remarks>
		/// The <see cref="M:Microsoft.AspNetCore.Components.ComponentBase.OnAfterRender(System.Boolean)" /> and <see cref="M:Microsoft.AspNetCore.Components.ComponentBase.OnAfterRenderAsync(System.Boolean)" /> lifecycle methods
		/// are useful for performing interop, or interacting with values received from <c>@ref</c>.
		/// Use the <paramref name="firstRender" /> parameter to ensure that initialization work is only performed
		/// once.
		/// </remarks>
		protected virtual Task OnAfterRenderAsync(bool firstRender)
		{
			throw null;
		}

		/// <summary>
		/// Executes the supplied work item on the associated renderer's
		/// synchronization context.
		/// </summary>
		/// <param name="workItem">The work item to execute.</param>
		protected Task InvokeAsync(Action workItem)
		{
			throw null;
		}

		/// <summary>
		/// Executes the supplied work item on the associated renderer's
		/// synchronization context.
		/// </summary>
		/// <param name="workItem">The work item to execute.</param>
		protected Task InvokeAsync(Func<Task> workItem)
		{
			throw null;
		}

		void IComponent.Attach(RenderHandle renderHandle)
		{
			throw null;
		}

		/// <summary>
		/// Sets parameters supplied by the component's parent in the render tree.
		/// </summary>
		/// <param name="parameters">The parameters.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that completes when the component has finished updating and rendering itself.</returns>
		/// <remarks>
		/// <para>
		/// The <see cref="M:Microsoft.AspNetCore.Components.ComponentBase.SetParametersAsync(Microsoft.AspNetCore.Components.ParameterView)" /> method should be passed the entire set of parameter values each
		/// time <see cref="M:Microsoft.AspNetCore.Components.ComponentBase.SetParametersAsync(Microsoft.AspNetCore.Components.ParameterView)" /> is called. It not required that the caller supply a parameter
		/// value for all parameters that are logically understood by the component.
		/// </para>
		/// <para>
		/// The default implementation of <see cref="M:Microsoft.AspNetCore.Components.ComponentBase.SetParametersAsync(Microsoft.AspNetCore.Components.ParameterView)" /> will set the value of each property
		/// decorated with <see cref="T:Microsoft.AspNetCore.Components.ParameterAttribute" /> or <see cref="T:Microsoft.AspNetCore.Components.CascadingParameterAttribute" /> that has
		/// a corresponding value in the <see cref="T:Microsoft.AspNetCore.Components.ParameterView" />. Parameters that do not have a corresponding value
		/// will be unchanged.
		/// </para>
		/// </remarks>
		public virtual Task SetParametersAsync(ParameterView parameters)
		{
			throw null;
		}

		Task IHandleEvent.HandleEventAsync(EventCallbackWorkItem callback, object? arg)
		{
			throw null;
		}

		Task IHandleAfterRender.OnAfterRenderAsync()
		{
			throw null;
		}
	}
}
