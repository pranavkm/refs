using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// Interface implemented by components that receive notification that they have been rendered.
	/// </summary>
	public interface IHandleAfterRender
	{
		/// <summary>
		/// Notifies the component that it has been rendered.
		/// </summary>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous event handling operation.</returns>
		Task OnAfterRenderAsync();
	}
}
