using Microsoft.AspNetCore.Connections;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets
{
	public sealed class SocketTransportFactory : IConnectionListenerFactory
	{
		public SocketTransportFactory(IOptions<SocketTransportOptions> options, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		public ValueTask<IConnectionListener> BindAsync(EndPoint endpoint, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
