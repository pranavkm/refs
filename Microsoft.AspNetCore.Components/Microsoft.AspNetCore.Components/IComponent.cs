using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// Represents a UI component.
	/// </summary>
	public interface IComponent
	{
		/// <summary>
		/// Attaches the component to a <see cref="T:Microsoft.AspNetCore.Components.RenderHandle" />.
		/// </summary>
		/// <param name="renderHandle">A <see cref="T:Microsoft.AspNetCore.Components.RenderHandle" /> that allows the component to be rendered.</param>
		void Attach(RenderHandle renderHandle);

		/// <summary>
		/// Sets parameters supplied by the component's parent in the render tree.
		/// </summary>
		/// <param name="parameters">The parameters.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that completes when the component has finished updating and rendering itself.</returns>
		/// <remarks>
		/// The <see cref="M:Microsoft.AspNetCore.Components.IComponent.SetParametersAsync(Microsoft.AspNetCore.Components.ParameterView)" /> method should be passed the entire set of parameter values each
		/// time <see cref="M:Microsoft.AspNetCore.Components.IComponent.SetParametersAsync(Microsoft.AspNetCore.Components.ParameterView)" /> is called. It not required that the caller supply a parameter
		/// value for all parameters that are logically understood by the component.
		/// </remarks>
		Task SetParametersAsync(ParameterView parameters);
	}
}
