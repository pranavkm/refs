using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	public class HttpSysOptions
	{
		internal static readonly int DefaultMaxAccepts;

		/// <summary>
		/// The name of the Http.Sys request queue
		/// </summary>
		public string RequestQueueName
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
		/// Indicates if this server instance is responsible for creating and configuring the request queue,
		/// of if it should attach to an existing queue. The default is to create.
		/// </summary>
		public RequestQueueMode RequestQueueMode
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
		/// Indicates how client certificates should be populated. The default is to allow a certificate without renegotiation.
		/// This does not change the netsh 'clientcertnegotiation' binding option which will need to be enabled for
		/// ClientCertificateMethod.AllowCertificate to resolve a certificate.
		/// </summary>
		public ClientCertificateMethod ClientCertificateMethod
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
		/// The maximum number of concurrent accepts.
		/// </summary>
		public int MaxAccepts
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
		/// Attempts kernel mode caching for responses with eligible headers. The response may not include
		/// Set-Cookie, Vary, or Pragma headers. It must include a Cache-Control header with Public and
		/// either a Shared-Max-Age or Max-Age value, or an Expires header.
		/// </summary>
		public bool EnableResponseCaching
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
		/// The url prefixes to register with Http.Sys. These may be modified at any time prior to disposing
		/// the listener.
		/// When attached to an existing queue the prefixes are only used to compute PathBase for requests.
		/// </summary>
		public UrlPrefixCollection UrlPrefixes
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Http.Sys authentication settings. These may be modified at any time prior to disposing
		/// the listener.
		/// </summary>
		public AuthenticationManager Authentication
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Exposes the Http.Sys timeout configurations.  These may also be configured in the registry.
		/// These may be modified at any time prior to disposing the listener.
		/// These settings do not apply when attaching to an existing queue.
		/// </summary>
		public TimeoutManager Timeouts
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or Sets if response body writes that fail due to client disconnects should throw exceptions or
		/// complete normally. The default is false.
		/// </summary>
		public bool ThrowWriteExceptions
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
		/// Gets or sets the maximum number of concurrent connections to accept, -1 for infinite, or null to
		/// use the machine wide setting from the registry. The default value is null.
		/// This settings does not apply when attaching to an existing queue.
		/// </summary>
		public long? MaxConnections
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
		/// Gets or sets the maximum number of requests that will be queued up in Http.Sys.
		/// This settings does not apply when attaching to an existing queue.
		/// </summary>
		public long RequestQueueLimit
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
		/// </summary>
		/// <remarks>
		/// Defaults to 30,000,000 bytes, which is approximately 28.6MB.
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
		/// Gets or sets a value that controls whether synchronous IO is allowed for the HttpContext.Request.Body and HttpContext.Response.Body.
		/// The default is `false`.
		/// </summary>
		public bool AllowSynchronousIO
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
		/// Gets or sets a value that controls how http.sys reacts when rejecting requests due to throttling conditions - like when the request
		/// queue limit is reached. The default in http.sys is "Basic" which means http.sys is just resetting the TCP connection. IIS uses Limited
		/// as its default behavior which will result in sending back a 503 - Service Unavailable back to the client.
		/// This settings does not apply when attaching to an existing queue.
		/// </summary>
		public Http503VerbosityLevel Http503Verbosity
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

		public HttpSysOptions()
		{
			throw null;
		}

		internal void Apply(UrlGroup urlGroup, RequestQueue requestQueue)
		{
			throw null;
		}
	}
}
