using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.AspNetCore.Server.Kestrel.Https;
using Microsoft.AspNetCore.Server.Kestrel.Https.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel
{
	public class KestrelConfigurationLoader
	{
		public KestrelServerOptions Options
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public IConfiguration Configuration
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			internal set
			{
				throw null;
			}
		}

		/// <summary>
		/// If <see langword="true" />, Kestrel will dynamically update endpoint bindings when configuration changes.
		/// This will only reload endpoints defined in the "Endpoints" section of your Kestrel configuration. Endpoints defined in code will not be reloaded.
		/// </summary>
		internal bool ReloadOnChange
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal KestrelConfigurationLoader(KestrelServerOptions options, IConfiguration configuration, IHostEnvironment hostEnvironment, bool reloadOnChange, ILogger<KestrelServer> logger, ILogger<HttpsConnectionMiddleware> httpsLogger)
		{
			throw null;
		}

		/// <summary>
		/// Specifies a configuration Action to run when an endpoint with the given name is loaded from configuration.
		/// </summary>
		public KestrelConfigurationLoader Endpoint(string name, Action<EndpointConfiguration> configureOptions)
		{
			throw null;
		}

		/// <summary>
		/// Bind to given IP address and port.
		/// </summary>
		public KestrelConfigurationLoader Endpoint(IPAddress address, int port)
		{
			throw null;
		}

		/// <summary>
		/// Bind to given IP address and port.
		/// </summary>
		public KestrelConfigurationLoader Endpoint(IPAddress address, int port, Action<ListenOptions> configure)
		{
			throw null;
		}

		/// <summary>
		/// Bind to given IP endpoint.
		/// </summary>
		public KestrelConfigurationLoader Endpoint(IPEndPoint endPoint)
		{
			throw null;
		}

		/// <summary>
		/// Bind to given IP address and port.
		/// </summary>
		public KestrelConfigurationLoader Endpoint(IPEndPoint endPoint, Action<ListenOptions> configure)
		{
			throw null;
		}

		/// <summary>
		/// Listens on ::1 and 127.0.0.1 with the given port. Requesting a dynamic port by specifying 0 is not supported
		/// for this type of endpoint.
		/// </summary>
		public KestrelConfigurationLoader LocalhostEndpoint(int port)
		{
			throw null;
		}

		/// <summary>
		/// Listens on ::1 and 127.0.0.1 with the given port. Requesting a dynamic port by specifying 0 is not supported
		/// for this type of endpoint.
		/// </summary>
		public KestrelConfigurationLoader LocalhostEndpoint(int port, Action<ListenOptions> configure)
		{
			throw null;
		}

		/// <summary>
		/// Listens on all IPs using IPv6 [::], or IPv4 0.0.0.0 if IPv6 is not supported.
		/// </summary>
		public KestrelConfigurationLoader AnyIPEndpoint(int port)
		{
			throw null;
		}

		/// <summary>
		/// Listens on all IPs using IPv6 [::], or IPv4 0.0.0.0 if IPv6 is not supported.
		/// </summary>
		public KestrelConfigurationLoader AnyIPEndpoint(int port, Action<ListenOptions> configure)
		{
			throw null;
		}

		/// <summary>
		/// Bind to given Unix domain socket path.
		/// </summary>
		public KestrelConfigurationLoader UnixSocketEndpoint(string socketPath)
		{
			throw null;
		}

		/// <summary>
		/// Bind to given Unix domain socket path.
		/// </summary>
		public KestrelConfigurationLoader UnixSocketEndpoint(string socketPath, Action<ListenOptions> configure)
		{
			throw null;
		}

		/// <summary>
		/// Open a socket file descriptor.
		/// </summary>
		public KestrelConfigurationLoader HandleEndpoint(ulong handle)
		{
			throw null;
		}

		/// <summary>
		/// Open a socket file descriptor.
		/// </summary>
		public KestrelConfigurationLoader HandleEndpoint(ulong handle, Action<ListenOptions> configure)
		{
			throw null;
		}

		internal void ApplyEndpointDefaults(ListenOptions listenOptions)
		{
			throw null;
		}

		internal void ApplyHttpsDefaults(HttpsConnectionAdapterOptions httpsOptions)
		{
			throw null;
		}

		public void Load()
		{
			throw null;
		}

		internal (List<ListenOptions>, List<ListenOptions>) Reload()
		{
			throw null;
		}
	}
}
