using Microsoft.AspNetCore.Http;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.WebSockets
{
	public class ExtendedWebSocketAcceptContext : WebSocketAcceptContext
	{
		public override string SubProtocol
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		[Obsolete("Setting this property has no effect. It will be removed in a future version.")]
		public int? ReceiveBufferSize
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public TimeSpan? KeepAliveInterval
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public ExtendedWebSocketAcceptContext()
		{
			throw null;
		}
	}
}
