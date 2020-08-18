using Microsoft.AspNetCore.Connections;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets
{
	public class SocketConnectionFactory : IConnectionFactory, IAsyncDisposable
	{
		public SocketConnectionFactory(IOptions<SocketTransportOptions> options, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CConnectAsync_003Ed__4))]
		[DebuggerStepThrough]
		public ValueTask<ConnectionContext> ConnectAsync(EndPoint endpoint, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		public ValueTask DisposeAsync()
		{
			throw null;
		}
	}
}
