using System;

namespace Microsoft.AspNetCore.Server.Kestrel.Core
{
	/// <summary>
	/// Limits only applicable to HTTP/2 connections.
	/// </summary>
	public class Http2Limits
	{
		/// <summary>
		/// Limits the number of concurrent request streams per HTTP/2 connection. Excess streams will be refused.
		/// <para>
		/// Value must be greater than 0, defaults to 100
		/// </para>
		/// </summary>
		public int MaxStreamsPerConnection
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
		/// Limits the size of the header compression tables, in octets, the HPACK encoder and decoder on the server can use.
		/// <para>
		/// Value must be greater than or equal to 0, defaults to 4096
		/// </para>
		/// </summary>
		public int HeaderTableSize
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
		/// Indicates the size of the largest frame payload that is allowed to be received, in octets. The size must be between 2^14 and 2^24-1.
		/// <para>
		/// Value must be between 2^14 and 2^24, defaults to 2^14 (16,384)
		/// </para>
		/// </summary>
		public int MaxFrameSize
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
		/// Indicates the size of the maximum allowed size of a request header field sequence. This limit applies to both name and value sequences in their compressed and uncompressed representations.
		/// <para>
		/// Value must be greater than 0, defaults to 2^14 (16,384)
		/// </para>
		/// </summary>
		public int MaxRequestHeaderFieldSize
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
		/// Indicates how much request body data the server is willing to receive and buffer at a time aggregated across all
		/// requests (streams) per connection. Note requests are also limited by <see cref="P:Microsoft.AspNetCore.Server.Kestrel.Core.Http2Limits.InitialStreamWindowSize" />
		/// <para>
		/// Value must be greater than or equal to 65,535 and less than 2^31, defaults to 128 kb.
		/// </para>
		/// </summary>
		public int InitialConnectionWindowSize
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
		/// Indicates how much request body data the server is willing to receive and buffer at a time per stream.
		/// Note connections are also limited by <see cref="P:Microsoft.AspNetCore.Server.Kestrel.Core.Http2Limits.InitialConnectionWindowSize" />
		/// <para>
		/// Value must be greater than or equal to 65,535 and less than 2^31, defaults to 96 kb.
		/// </para>
		/// </summary>
		public int InitialStreamWindowSize
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
		/// Gets or sets the keep alive ping delay. The server will send a keep alive ping to the client if it
		/// doesn't receive any frames on a connection for this period of time. This property is used together with
		/// <see cref="P:Microsoft.AspNetCore.Server.Kestrel.Core.Http2Limits.KeepAlivePingTimeout" /> to close broken connections.
		/// <para>
		/// Delay value must be greater than or equal to 1 second. Set to <see cref="F:System.TimeSpan.MaxValue" /> to
		/// disable the keep alive ping.
		/// Defaults to <see cref="F:System.TimeSpan.MaxValue" />.
		/// </para>
		/// </summary>
		public TimeSpan KeepAlivePingDelay
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
		/// Gets or sets the keep alive ping timeout. Keep alive pings are sent when a period of inactivity exceeds
		/// the configured <see cref="P:Microsoft.AspNetCore.Server.Kestrel.Core.Http2Limits.KeepAlivePingDelay" /> value. The server will close the connection if it
		/// doesn't receive any frames within the timeout.
		/// <para>
		/// Timeout must be greater than or equal to 1 second. Set to <see cref="F:System.TimeSpan.MaxValue" /> to
		/// disable the keep alive ping timeout.
		/// Defaults to 20 seconds.
		/// </para>
		/// </summary>
		public TimeSpan KeepAlivePingTimeout
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

		public Http2Limits()
		{
			throw null;
		}
	}
}
