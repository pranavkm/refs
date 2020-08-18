using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
	/// <summary>
	/// Defines an interface that represents a listener bound to a specific <see cref="P:Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure.IConnectionListenerBase.EndPoint" />.
	/// </summary>
	internal interface IConnectionListenerBase : IAsyncDisposable
	{
		/// <summary>
		/// The endpoint that was bound. This may differ from the requested endpoint, such as when the caller requested that any free port be selected.
		/// </summary>
		EndPoint EndPoint
		{
			get;
		}

		/// <summary>
		/// Stops listening for incoming connections.
		/// </summary>
		/// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.ValueTask" /> that represents the unbind operation.</returns>
		ValueTask UnbindAsync(CancellationToken cancellationToken = default(CancellationToken));
	}
}
