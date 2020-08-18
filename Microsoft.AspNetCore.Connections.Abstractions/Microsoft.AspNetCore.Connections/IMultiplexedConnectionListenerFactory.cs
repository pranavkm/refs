using Microsoft.AspNetCore.Http.Features;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Connections
{
	/// <summary>
	/// Defines an interface that provides the mechanisms for binding to various types of <see cref="T:System.Net.EndPoint" />s.
	/// </summary>
	public interface IMultiplexedConnectionListenerFactory
	{
		/// <summary>
		/// Creates an <see cref="T:Microsoft.AspNetCore.Connections.IMultiplexedConnectionListener" /> bound to the specified <see cref="T:System.Net.EndPoint" />.
		/// </summary>
		/// <param name="endpoint">The <see cref="T:System.Net.EndPoint" /> to bind to.</param>
		/// <param name="features">A feature collection to pass options when binding.</param>
		/// <param name="cancellationToken">The token to monitor for cancellation requests.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.ValueTask`1" /> that completes when the listener has been bound, yielding a <see cref="T:Microsoft.AspNetCore.Connections.IMultiplexedConnectionListener" /> representing the new listener.</returns>
		ValueTask<IMultiplexedConnectionListener> BindAsync(EndPoint endpoint, IFeatureCollection? features = null, CancellationToken cancellationToken = default(CancellationToken));
	}
}
