using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core
{
	/// <summary>
	/// Describes either an <see cref="P:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions.IPEndPoint" />, Unix domain socket path, or a file descriptor for an already open
	/// socket that Kestrel should bind to or open.
	/// </summary>
	public class ListenOptions : IConnectionBuilder, IMultiplexedConnectionBuilder
	{
		internal static readonly HttpProtocols DefaultHttpProtocols;

		internal readonly List<Func<ConnectionDelegate, ConnectionDelegate>> _middleware;

		internal readonly List<Func<MultiplexedConnectionDelegate, MultiplexedConnectionDelegate>> _multiplexedMiddleware;

		public EndPoint EndPoint
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

		internal EndpointConfig EndpointConfig
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
		/// The <see cref="P:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions.IPEndPoint" /> to bind to.
		/// Only set if the <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" /> <see cref="T:System.Type" /> is <see cref="P:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions.IPEndPoint" />.
		/// </summary>
		public IPEndPoint IPEndPoint
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The absolute path to a Unix domain socket to bind to.
		/// Only set if the <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" /> <see cref="T:System.Type" /> is <see cref="T:System.Net.Sockets.UnixDomainSocketEndPoint" />.
		/// </summary>
		public string SocketPath
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// A file descriptor for the socket to open.
		/// Only set if the <see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions" /> <see cref="T:System.Type" /> is <see cref="T:Microsoft.AspNetCore.Connections.FileHandleEndPoint" />.
		/// </summary>
		public ulong FileHandle
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Enables connection middleware to resolve and use services registered by the application during startup.
		/// Only set if accessed from the callback of a <see cref="P:Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions.KestrelServerOptions" /> Listen* method.
		/// </summary>
		public KestrelServerOptions KestrelServerOptions
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
		/// The protocols enabled on this endpoint.
		/// </summary>
		/// <remarks>Defaults to HTTP/1.x and HTTP/2.</remarks>
		public HttpProtocols Protocols
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

		public IServiceProvider ApplicationServices
		{
			get
			{
				throw null;
			}
		}

		internal string Scheme
		{
			get
			{
				throw null;
			}
		}

		internal bool IsTls
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

		internal ListenOptions(EndPoint endPoint)
		{
			throw null;
		}

		internal ListenOptions(string socketPath)
		{
			throw null;
		}

		internal ListenOptions(ulong fileHandle)
		{
			throw null;
		}

		internal ListenOptions(ulong fileHandle, FileHandleType handleType)
		{
			throw null;
		}

		/// <summary>
		/// Gets the name of this endpoint to display on command-line when the web server starts.
		/// </summary>
		internal virtual string GetDisplayName()
		{
			throw null;
		}

		public override string ToString()
		{
			throw null;
		}

		/// <summary>
		/// Adds a middleware delegate to the connection pipeline.
		/// Configured by the <c>UseHttps()</c> and <see cref="M:Microsoft.AspNetCore.Hosting.ListenOptionsConnectionLoggingExtensions.UseConnectionLogging(Microsoft.AspNetCore.Server.Kestrel.Core.ListenOptions)" />
		/// extension methods.
		/// </summary>
		/// <param name="middleware">The middleware delegate.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Connections.IConnectionBuilder" />.</returns>
		public IConnectionBuilder Use(Func<ConnectionDelegate, ConnectionDelegate> middleware)
		{
			throw null;
		}

		IMultiplexedConnectionBuilder IMultiplexedConnectionBuilder.Use(Func<MultiplexedConnectionDelegate, MultiplexedConnectionDelegate> middleware)
		{
			throw null;
		}

		public ConnectionDelegate Build()
		{
			throw null;
		}

		MultiplexedConnectionDelegate IMultiplexedConnectionBuilder.Build()
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CBindAsync_003Ed__43))]
		[DebuggerStepThrough]
		internal virtual Task BindAsync(AddressBindContext context)
		{
			throw null;
		}
	}
}
