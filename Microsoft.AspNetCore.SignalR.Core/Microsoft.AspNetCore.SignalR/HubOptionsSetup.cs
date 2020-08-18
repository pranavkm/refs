using Microsoft.AspNetCore.SignalR.Protocol;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.SignalR
{
	public class HubOptionsSetup : IConfigureOptions<HubOptions>
	{
		internal const int DefaultMaximumMessageSize = 32768;

		internal const int DefaultStreamBufferCapacity = 10;

		internal static TimeSpan DefaultHandshakeTimeout
		{
			get
			{
				throw null;
			}
		}

		internal static TimeSpan DefaultKeepAliveInterval
		{
			get
			{
				throw null;
			}
		}

		internal static TimeSpan DefaultClientTimeoutInterval
		{
			get
			{
				throw null;
			}
		}

		public HubOptionsSetup(IEnumerable<IHubProtocol> protocols)
		{
			throw null;
		}

		public void Configure(HubOptions options)
		{
			throw null;
		}
	}
	public class HubOptionsSetup<THub> : IConfigureOptions<HubOptions<THub>> where THub : Hub
	{
		public HubOptionsSetup(IOptions<HubOptions> options)
		{
			throw null;
		}

		public void Configure(HubOptions<THub> options)
		{
			throw null;
		}
	}
}
