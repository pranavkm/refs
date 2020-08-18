using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Http.Connections
{
	public class WebSocketOptions
	{
		public TimeSpan CloseTimeout
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
		/// Gets or sets a delegate that will be called when a new WebSocket is established to select the value
		/// for the 'Sec-WebSocket-Protocol' response header. The delegate will be called with a list of the protocols provided
		/// by the client in the 'Sec-WebSocket-Protocol' request header.
		/// </summary>
		/// <remarks>
		/// See RFC 6455 section 1.3 for more details on the WebSocket handshake: https://tools.ietf.org/html/rfc6455#section-1.3
		/// </remarks>
		public Func<IList<string>, string>? SubProtocolSelector
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

		public WebSocketOptions()
		{
			throw null;
		}
	}
}
