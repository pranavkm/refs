using Microsoft.AspNetCore.Server.Kestrel.Https;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Microsoft.AspNetCore.Server.Kestrel.Core
{
	/// <summary>
	/// Provides programmatic configuration of Kestrel-specific features.
	/// </summary>
	public class KestrelServerOptions
	{
		internal static readonly Func<string, Encoding> DefaultRequestHeaderEncodingSelector;

		internal List<ListenOptions> CodeBackedListenOptions
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal List<ListenOptions> ConfigurationBackedListenOptions
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal IEnumerable<ListenOptions> ListenOptions
		{
			get
			{
				throw null;
			}
		}

		internal List<ListenOptions> OptionsInUse
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets whether the <c>Server</c> header should be included in each response.
		/// </summary>
		/// <remarks>
		/// Defaults to true.
		/// </remarks>
		public bool AddServerHeader
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
		/// Gets or sets a value that controls whether dynamic compression of response headers is allowed.
		/// For more information about the security considerations of HPack dynamic header compression, visit
		/// https://tools.ietf.org/html/rfc7541#section-7.
		/// </summary>
		/// <remarks>
		/// Defaults to true.
		/// </remarks>
		public bool AllowResponseHeaderCompression
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
		/// Gets or sets a value that controls whether synchronous IO is allowed for the <see cref="P:Microsoft.AspNetCore.Http.HttpContext.Request" /> and <see cref="P:Microsoft.AspNetCore.Http.HttpContext.Response" />
		/// </summary>
		/// <remarks>
		/// Defaults to false.
		/// </remarks>
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
		/// Gets or sets a value that controls whether the string values materialized
		/// will be reused across requests; if they match, or if the strings will always be reallocated.
		/// </summary>
		/// <remarks>
		/// Defaults to false.
		/// </remarks>
		public bool DisableStringReuse
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
		/// Controls whether to return the AltSvcHeader from on an HTTP/2 or lower response for HTTP/3
		/// </summary>
		/// <remarks>
		/// Defaults to false.
		/// </remarks>
		public bool EnableAltSvc
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
		/// Gets or sets a callback that returns the <see cref="T:System.Text.Encoding" /> to decode the value for the specified request header name,
		/// or <see langword="null" /> to use the default <see cref="T:System.Text.UTF8Encoding" />.
		/// </summary>
		public Func<string, Encoding> RequestHeaderEncodingSelector
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
		/// Enables the Listen options callback to resolve and use services registered by the application during startup.
		/// Typically initialized by UseKestrel()"/&gt;.
		/// </summary>
		public IServiceProvider ApplicationServices
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
		/// Provides access to request limit options.
		/// </summary>
		public KestrelServerLimits Limits
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Provides a configuration source where endpoints will be loaded from on server start.
		/// The default is <see langword="null" />.
		/// </summary>
		public KestrelConfigurationLoader ConfigurationLoader
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
		/// The default server certificate for https endpoints. This is applied lazily after HttpsDefaults and user options.
		/// </summary>
		internal X509Certificate2 DefaultCertificate
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
		/// Has the default dev certificate load been attempted?
		/// </summary>
		internal bool IsDevCertLoaded
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
		/// Specifies a configuration Action to run for each newly created endpoint. Calling this again will replace
		/// the prior action.
		/// </summary>
		public void ConfigureEndpointDefaults(Action<ListenOptions> configureOptions)
		{
			throw null;
		}

		internal void ApplyEndpointDefaults(ListenOptions listenOptions)
		{
			throw null;
		}

		/// <summary>
		/// Specifies a configuration Action to run for each newly created https endpoint. Calling this again will replace
		/// the prior action.
		/// </summary>
		public void ConfigureHttpsDefaults(Action<HttpsConnectionAdapterOptions> configureOptions)
		{
			throw null;
		}

		internal void ApplyHttpsDefaults(HttpsConnectionAdapterOptions httpsOptions)
		{
			throw null;
		}

		internal void ApplyDefaultCert(HttpsConnectionAdapterOptions httpsOptions)
		{
			throw null;
		}

		/// <summary>
		/// Creates a configuration loader for setting up Kestrel.
		/// </summary>
		/// <returns>A <see cref="T:Microsoft.AspNetCore.Server.Kestrel.KestrelConfigurationLoader" /> for configuring endpoints.</returns>
		public KestrelConfigurationLoader Configure()
		{
			throw null;
		}

		/// <summary>
		/// Creates a configuration loader for setting up Kestrel that takes an <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" /> as input.
		/// This configuration must be scoped to the configuration section for Kestrel.
		/// Call <see cref="M:Microsoft.AspNetCore.Server.Kestrel.Core.KestrelServerOptions.Configure(Microsoft.Extensions.Configuration.IConfiguration,System.Boolean)" /> to enable dynamic endpoint binding updates.
		/// </summary>
		/// <param name="config">The configuration section for Kestrel.</param>
		/// <returns>A <see cref="T:Microsoft.AspNetCore.Server.Kestrel.KestrelConfigurationLoader" /> for further endpoint configuration.</returns>
		public KestrelConfigurationLoader Configure(IConfiguration config)
		{
			throw null;
		}

		/// <summary>
		/// Creates a configuration loader for setting up Kestrel that takes an <see cref="T:Microsoft.Extensions.Configuration.IConfiguration" /> as input.
		/// This configuration must be scoped to the configuration section for Kestrel.
		/// </summary>
		/// <param name="config">The configuration section for Kestrel.</param>
		/// <param name="reloadOnChange">
		/// If <see langword="true" />, Kestrel will dynamically update endpoint bindings when configuration changes.
		/// This will only reload endpoints defined in the "Endpoints" section of your <paramref name="config" />. Endpoints defined in code will not be reloaded.
		/// </param>
		/// <returns>A <see cref="T:Microsoft.AspNetCore.Server.Kestrel.KestrelConfigurationLoader" /> for further endpoint configuration.</returns>
		public KestrelConfigurationLoader Configure(IConfiguration config, bool reloadOnChange)
		{
			throw null;
		}

		/// <summary>
		/// Bind to given IP address and port.
		/// </summary>
		public void Listen(IPAddress address, int port)
		{
			throw null;
		}

		/// <summary>
		/// Bind to given IP address and port.
		/// The callback configures endpoint-specific settings.
		/// </summary>
		public void Listen(IPAddress address, int port, Action<ListenOptions> configure)
		{
			throw null;
		}

		/// <summary>
		/// Bind to the given IP endpoint.
		/// </summary>
		public void Listen(IPEndPoint endPoint)
		{
			throw null;
		}

		/// <summary>
		/// Bind to the given endpoint.
		/// </summary>
		/// <param name="endPoint"></param>
		public void Listen(EndPoint endPoint)
		{
			throw null;
		}

		/// <summary>
		/// Bind to given IP address and port.
		/// The callback configures endpoint-specific settings.
		/// </summary>
		public void Listen(IPEndPoint endPoint, Action<ListenOptions> configure)
		{
			throw null;
		}

		/// <summary>
		/// Bind to the given endpoint.
		/// The callback configures endpoint-specific settings.
		/// </summary>
		public void Listen(EndPoint endPoint, Action<ListenOptions> configure)
		{
			throw null;
		}

		/// <summary>
		/// Listens on ::1 and 127.0.0.1 with the given port. Requesting a dynamic port by specifying 0 is not supported
		/// for this type of endpoint.
		/// </summary>
		public void ListenLocalhost(int port)
		{
			throw null;
		}

		/// <summary>
		/// Listens on ::1 and 127.0.0.1 with the given port. Requesting a dynamic port by specifying 0 is not supported
		/// for this type of endpoint.
		/// </summary>
		public void ListenLocalhost(int port, Action<ListenOptions> configure)
		{
			throw null;
		}

		/// <summary>
		/// Listens on all IPs using IPv6 [::], or IPv4 0.0.0.0 if IPv6 is not supported.
		/// </summary>
		public void ListenAnyIP(int port)
		{
			throw null;
		}

		/// <summary>
		/// Listens on all IPs using IPv6 [::], or IPv4 0.0.0.0 if IPv6 is not supported.
		/// </summary>
		public void ListenAnyIP(int port, Action<ListenOptions> configure)
		{
			throw null;
		}

		/// <summary>
		/// Bind to given Unix domain socket path.
		/// </summary>
		public void ListenUnixSocket(string socketPath)
		{
			throw null;
		}

		/// <summary>
		/// Bind to given Unix domain socket path.
		/// Specify callback to configure endpoint-specific settings.
		/// </summary>
		public void ListenUnixSocket(string socketPath, Action<ListenOptions> configure)
		{
			throw null;
		}

		/// <summary>
		/// Open a socket file descriptor.
		/// </summary>
		public void ListenHandle(ulong handle)
		{
			throw null;
		}

		/// <summary>
		/// Open a socket file descriptor.
		/// The callback configures endpoint-specific settings.
		/// </summary>
		public void ListenHandle(ulong handle, Action<ListenOptions> configure)
		{
			throw null;
		}

		public KestrelServerOptions()
		{
			throw null;
		}
	}
}
