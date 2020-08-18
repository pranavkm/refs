using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Core
{
	public class KestrelServerLimits
	{
		/// <summary>
		/// Gets or sets the maximum size of the response buffer before write
		/// calls begin to block or return tasks that don't complete until the
		/// buffer size drops below the configured limit.
		/// Defaults to 65,536 bytes (64 KB).
		/// </summary>
		/// <remarks>
		/// When set to null, the size of the response buffer is unlimited.
		/// When set to zero, all write calls will block or return tasks that
		/// don't complete until the entire response buffer is flushed.
		/// </remarks>
		public long? MaxResponseBufferSize
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the maximum size of the request buffer.
		/// Defaults to 1,048,576 bytes (1 MB).
		/// </summary>
		/// <remarks>
		/// When set to null, the size of the request buffer is unlimited.
		/// </remarks>
		public long? MaxRequestBufferSize
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the maximum allowed size for the HTTP request line.
		/// Defaults to 8,192 bytes (8 KB).
		/// </summary>
		/// <remarks>
		/// For HTTP/2 this measures the total size of the required pseudo headers
		/// :method, :scheme, :authority, and :path.
		/// </remarks>
		public int MaxRequestLineSize
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the maximum allowed size for the HTTP request headers.
		/// Defaults to 32,768 bytes (32 KB).
		/// </summary>
		/// <remarks>
		/// </remarks>
		public int MaxRequestHeadersTotalSize
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the maximum allowed number of headers per HTTP request.
		/// Defaults to 100.
		/// </summary>
		/// <remarks>
		/// </remarks>
		public int MaxRequestHeaderCount
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the maximum allowed size of any request body in bytes.
		/// When set to null, the maximum request body size is unlimited.
		/// This limit has no effect on upgraded connections which are always unlimited.
		/// This can be overridden per-request via <see cref="T:Microsoft.AspNetCore.Http.Features.IHttpMaxRequestBodySizeFeature" />.
		/// Defaults to 30,000,000 bytes, which is approximately 28.6MB.
		/// </summary>
		/// <remarks>
		/// </remarks>
		public long? MaxRequestBodySize
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the keep-alive timeout.
		/// Defaults to 2 minutes.
		/// </summary>
		/// <remarks>
		/// </remarks>
		public TimeSpan KeepAliveTimeout
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the maximum amount of time the server will spend receiving request headers.
		/// Defaults to 30 seconds.
		/// </summary>
		/// <remarks>
		/// </remarks>
		public TimeSpan RequestHeadersTimeout
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the maximum number of open connections. When set to null, the number of connections is unlimited.
		/// <para>
		/// Defaults to null.
		/// </para>
		/// </summary>
		/// <remarks>
		/// <para>
		/// When a connection is upgraded to another protocol, such as WebSockets, its connection is counted against the
		/// <see cref="P:Microsoft.AspNetCore.Server.Kestrel.Core.KestrelServerLimits.MaxConcurrentUpgradedConnections" /> limit instead of <see cref="P:Microsoft.AspNetCore.Server.Kestrel.Core.KestrelServerLimits.MaxConcurrentConnections" />.
		/// </para>
		/// </remarks>
		public long? MaxConcurrentConnections
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the maximum number of open, upgraded connections. When set to null, the number of upgraded connections is unlimited.
		/// An upgraded connection is one that has been switched from HTTP to another protocol, such as WebSockets.
		/// <para>
		/// Defaults to null.
		/// </para>
		/// </summary>
		/// <remarks>
		/// <para>
		/// When a connection is upgraded to another protocol, such as WebSockets, its connection is counted against the
		/// <see cref="P:Microsoft.AspNetCore.Server.Kestrel.Core.KestrelServerLimits.MaxConcurrentUpgradedConnections" /> limit instead of <see cref="P:Microsoft.AspNetCore.Server.Kestrel.Core.KestrelServerLimits.MaxConcurrentConnections" />.
		/// </para>
		/// </remarks>
		public long? MaxConcurrentUpgradedConnections
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Limits only applicable to HTTP/2 connections.
		/// </summary>
		public Http2Limits Http2
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Limits only applicable to HTTP/3 connections.
		/// </summary>
		public Http3Limits Http3
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the request body minimum data rate in bytes/second.
		/// Setting this property to null indicates no minimum data rate should be enforced.
		/// This limit has no effect on upgraded connections which are always unlimited.
		/// This can be overridden per-request via <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.Features.IHttpMinRequestBodyDataRateFeature" />.
		/// Defaults to 240 bytes/second with a 5 second grace period.
		/// </summary>
		/// <remarks>
		/// </remarks>
		public MinDataRate MinRequestBodyDataRate
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
		/// Gets or sets the response minimum data rate in bytes/second.
		/// Setting this property to null indicates no minimum data rate should be enforced.
		/// This limit has no effect on upgraded connections which are always unlimited.
		/// This can be overridden per-request via <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.Features.IHttpMinResponseDataRateFeature" />.
		/// <para>
		/// Defaults to 240 bytes/second with a 5 second grace period.
		/// </para>
		/// </summary>
		/// <remarks>
		/// <para>
		/// Contrary to the request body minimum data rate, this rate applies to the response status line and headers as well.
		/// </para>
		/// <para>
		/// This rate is enforced per write operation instead of being averaged over the life of the response. Whenever the server
		/// writes a chunk of data, a timer is set to the maximum of the grace period set in this property or the length of the write in
		/// bytes divided by the data rate (i.e. the maximum amount of time that write should take to complete with the specified data rate).
		/// The connection is aborted if the write has not completed by the time that timer expires.
		/// </para>
		/// </remarks>
		public MinDataRate MinResponseDataRate
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

		public KestrelServerLimits()
		{
			throw null;
		}
	}
}
