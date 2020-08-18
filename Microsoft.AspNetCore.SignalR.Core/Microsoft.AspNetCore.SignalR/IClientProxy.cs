using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.SignalR
{
	/// <summary>
	/// A proxy abstraction for invoking hub methods.
	/// </summary>
	public interface IClientProxy
	{
		/// <summary>
		/// Invokes a method on the connection(s) represented by the <see cref="T:Microsoft.AspNetCore.SignalR.IClientProxy" /> instance.
		/// Does not wait for a response from the receiver.
		/// </summary>
		/// <param name="method">Name of the method to invoke.</param>
		/// <param name="args">A collection of arguments to pass to the client.</param>
		/// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous invoke.</returns>
		Task SendCoreAsync(string method, object?[]? args, CancellationToken cancellationToken = default(CancellationToken));
	}
}
