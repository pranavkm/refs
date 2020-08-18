using Microsoft.AspNetCore.Connections;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
	/// <summary>
	/// Defines an interface that represents a listener bound to a specific <see cref="T:System.Net.EndPoint" />.
	/// </summary>
	internal interface IConnectionListener<T> : IConnectionListenerBase, IAsyncDisposable where T : BaseConnectionContext
	{
		/// <summary>
		/// Begins an asynchronous operation to accept an incoming connection.
		/// </summary>
		/// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.ValueTask`1" /> that completes when a connection is accepted, yielding the <see cref="T:Microsoft.AspNetCore.Connections.BaseConnectionContext" /> representing the connection.</returns>
		ValueTask<T> AcceptAsync(CancellationToken cancellationToken = default(CancellationToken));
	}
}
