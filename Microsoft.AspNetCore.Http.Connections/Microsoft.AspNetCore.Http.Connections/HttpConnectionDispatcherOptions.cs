using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Http.Connections
{
	/// <summary>
	/// Options used to configure the HTTP connection dispatcher.
	/// </summary>
	public class HttpConnectionDispatcherOptions
	{
		/// <summary>
		/// Gets a collection of <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizeData" /> used during HTTP connection pipeline.
		/// </summary>
		public IList<IAuthorizeData> AuthorizationData
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets a bitmask combining one or more <see cref="T:Microsoft.AspNetCore.Http.Connections.HttpTransportType" /> values that specify what transports the server should use to receive HTTP requests.
		/// </summary>
		public HttpTransportType Transports
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
		/// Gets the <see cref="T:Microsoft.AspNetCore.Http.Connections.WebSocketOptions" /> used by the web sockets transport.
		/// </summary>
		public WebSocketOptions WebSockets
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the <see cref="T:Microsoft.AspNetCore.Http.Connections.LongPollingOptions" /> used by the long polling transport.
		/// </summary>
		public LongPollingOptions LongPolling
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the maximum buffer size of the transport writer.
		/// </summary>
		public long TransportMaxBufferSize
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
		/// Gets or sets the maximum buffer size of the application writer.
		/// </summary>
		public long ApplicationMaxBufferSize
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
		/// Gets or sets the minimum protocol verison supported by the server.
		/// The default value is 0, the lowest possible protocol version.
		/// </summary>
		public int MinimumProtocolVersion
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
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Http.Connections.HttpConnectionDispatcherOptions" /> class.
		/// </summary>
		public HttpConnectionDispatcherOptions()
		{
			throw null;
		}
	}
}
