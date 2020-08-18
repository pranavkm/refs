using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.Internal;
using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets
{
	internal sealed class SocketConnectionListener : IConnectionListener, IAsyncDisposable
	{
		public EndPoint EndPoint
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal SocketConnectionListener(EndPoint endpoint, SocketTransportOptions options, ISocketsTrace trace)
		{
			throw null;
		}

		internal void Bind()
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CAcceptAsync_003Ed__14))]
		[DebuggerStepThrough]
		public ValueTask<ConnectionContext> AcceptAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		public ValueTask UnbindAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		public ValueTask DisposeAsync()
		{
			throw null;
		}
	}
}
