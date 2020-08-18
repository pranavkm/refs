using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Connections
{
	/// <summary>
	/// Defines an interface that represents a listener bound to a specific <see cref="P:Microsoft.AspNetCore.Connections.IConnectionListener.EndPoint" />.
	/// </summary>
	public interface IConnectionListener : IAsyncDisposable
	{
		/// <summary>
		/// The endpoint that was bound. This may differ from the requested endpoint, such as when the caller requested that any free port be selected.
		/// </summary>
		EndPoint EndPoint
		{
			get;
		}

		/// <summary>
		/// Begins an asynchronous operation to accept an incoming connection.
		/// </summary>
		/// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.ValueTask`1" /> that completes when a connection is accepted, yielding the <see cref="T:Microsoft.AspNetCore.Connections.ConnectionContext" /> representing the connection.</returns>
		ValueTask<ConnectionContext> AcceptAsync(CancellationToken cancellationToken = default(CancellationToken));

		/// <summary>
		/// Stops listening for incoming connections.
		/// </summary>
		/// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.ValueTask" /> that represents the un-bind operation.</returns>
		ValueTask UnbindAsync(CancellationToken cancellationToken = default(CancellationToken));
	}
}
