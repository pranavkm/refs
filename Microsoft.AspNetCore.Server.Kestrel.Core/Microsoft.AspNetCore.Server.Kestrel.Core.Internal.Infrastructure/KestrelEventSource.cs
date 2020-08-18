using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using System.Diagnostics.Tracing;
using System.Net.Security;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
	[EventSource(Name = "Microsoft-AspNetCore-Server-Kestrel")]
	internal sealed class KestrelEventSource : EventSource
	{
		public static readonly KestrelEventSource Log;

		[NonEvent]
		public void ConnectionStart(BaseConnectionContext connection)
		{
			throw null;
		}

		[NonEvent]
		public void ConnectionStop(BaseConnectionContext connection)
		{
			throw null;
		}

		[NonEvent]
		public void RequestStart(HttpProtocol httpProtocol)
		{
			throw null;
		}

		[NonEvent]
		public void RequestStop(HttpProtocol httpProtocol)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Event(5, Level = EventLevel.Informational)]
		public void ConnectionRejected(string connectionId)
		{
			throw null;
		}

		[NonEvent]
		public void ConnectionQueuedStart(BaseConnectionContext connection)
		{
			throw null;
		}

		[NonEvent]
		public void ConnectionQueuedStop(BaseConnectionContext connection)
		{
			throw null;
		}

		[NonEvent]
		public void TlsHandshakeStart(BaseConnectionContext connectionContext, SslServerAuthenticationOptions sslOptions)
		{
			throw null;
		}

		[NonEvent]
		public void TlsHandshakeStop(BaseConnectionContext connectionContext, TlsConnectionFeature feature)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Event(10, Level = EventLevel.Error)]
		public void TlsHandshakeFailed(string connectionId)
		{
			throw null;
		}

		[NonEvent]
		public void RequestQueuedStart(HttpProtocol httpProtocol, string httpVersion)
		{
			throw null;
		}

		[NonEvent]
		public void RequestQueuedStop(HttpProtocol httpProtocol, string httpVersion)
		{
			throw null;
		}

		[NonEvent]
		public void RequestUpgradedStart(HttpProtocol httpProtocol)
		{
			throw null;
		}

		[NonEvent]
		public void RequestUpgradedStop(HttpProtocol httpProtocol)
		{
			throw null;
		}

		protected override void OnEventCommand(EventCommandEventArgs command)
		{
			throw null;
		}
	}
}
