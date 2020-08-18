using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Connections
{
	/// <summary>
	/// A factory abstraction for creating connections to an endpoint.
	/// </summary>
	public interface IConnectionFactory
	{
		/// <summary>
		/// Creates a new connection to an endpoint.
		/// </summary>
		/// <param name="endpoint">The <see cref="T:System.Net.EndPoint" /> to connect to.</param>
		/// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
		/// <returns>
		/// A <see cref="T:System.Threading.Tasks.ValueTask`1" /> that represents the asynchronous connect, yielding the <see cref="T:Microsoft.AspNetCore.Connections.ConnectionContext" /> for the new connection when completed.
		/// </returns>
		ValueTask<ConnectionContext> ConnectAsync(EndPoint endpoint, CancellationToken cancellationToken = default(CancellationToken));
	}
}
