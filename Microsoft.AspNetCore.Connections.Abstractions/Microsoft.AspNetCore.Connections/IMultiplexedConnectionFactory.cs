using Microsoft.AspNetCore.Http.Features;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Connections
{
	/// <summary>
	/// A factory abstraction for creating connections to an endpoint.
	/// </summary>
	public interface IMultiplexedConnectionFactory
	{
		/// <summary>
		/// Creates a new connection to an endpoint.
		/// </summary>
		/// <param name="endpoint">The <see cref="T:System.Net.EndPoint" /> to connect to.</param>
		/// <param name="features">A feature collection to pass options when connecting.</param>
		/// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
		/// <returns>
		/// A <see cref="T:System.Threading.Tasks.ValueTask`1" /> that represents the asynchronous connect, yielding the <see cref="T:Microsoft.AspNetCore.Connections.MultiplexedConnectionContext" /> for the new connection when completed.
		/// </returns>
		ValueTask<MultiplexedConnectionContext> ConnectAsync(EndPoint endpoint, IFeatureCollection? features = null, CancellationToken cancellationToken = default(CancellationToken));
	}
}
