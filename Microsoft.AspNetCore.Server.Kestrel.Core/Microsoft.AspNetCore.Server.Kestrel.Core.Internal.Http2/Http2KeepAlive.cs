using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure;
using System;
using System.Buffers;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2
{
	internal class Http2KeepAlive
	{
		internal static readonly ReadOnlySequence<byte> PingPayload;

		internal KeepAliveState _state;

		public Http2KeepAlive(TimeSpan keepAliveInterval, TimeSpan keepAliveTimeout, ISystemClock systemClock)
		{
			throw null;
		}

		public KeepAliveState ProcessKeepAlive(bool frameReceived)
		{
			throw null;
		}
	}
}
