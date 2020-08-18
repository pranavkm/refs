using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// Interface implemented by components that receive notification of state changes.
	/// </summary>
	public interface IHandleEvent
	{
		/// <summary>
		/// Notifies the a state change has been triggered.
		/// </summary>
		/// <param name="item">The <see cref="T:Microsoft.AspNetCore.Components.EventCallbackWorkItem" /> associated with this event.</param>
		/// <param name="arg">The argument associated with this event.</param>
		/// <returns>
		/// A <see cref="T:System.Threading.Tasks.Task" /> that completes once the component has processed the state change.
		/// </returns>
		Task HandleEventAsync(EventCallbackWorkItem item, object? arg);
	}
}
