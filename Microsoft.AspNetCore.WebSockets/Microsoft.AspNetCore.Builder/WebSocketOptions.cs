using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Configuration options for the WebSocketMiddleware
	/// </summary>
	public class WebSocketOptions
	{
		/// <summary>
		/// Gets or sets the frequency at which to send Ping/Pong keep-alive control frames.
		/// The default is two minutes.
		/// </summary>
		public TimeSpan KeepAliveInterval
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

		/// <summary>
		/// Gets or sets the size of the protocol buffer used to receive and parse frames.
		/// The default is 4kb.
		/// </summary>
		[Obsolete("Setting this property has no effect. It will be removed in a future version.")]
		public int ReceiveBufferSize
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

		/// <summary>
		/// Set the Origin header values allowed for WebSocket requests to prevent Cross-Site WebSocket Hijacking.
		/// By default all Origins are allowed.
		/// </summary>
		public IList<string> AllowedOrigins
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public WebSocketOptions()
		{
			throw null;
		}
	}
}
