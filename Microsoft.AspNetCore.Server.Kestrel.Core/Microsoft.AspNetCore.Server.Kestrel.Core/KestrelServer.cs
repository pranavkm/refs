using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core
{
	public class KestrelServer : IServer, IDisposable
	{
		public IFeatureCollection Features
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public KestrelServerOptions Options
		{
			get
			{
				throw null;
			}
		}

		public KestrelServer(IOptions<KestrelServerOptions> options, IEnumerable<IConnectionListenerFactory> transportFactories, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		public KestrelServer(IOptions<KestrelServerOptions> options, IEnumerable<IConnectionListenerFactory> transportFactories, IEnumerable<IMultiplexedConnectionListenerFactory> multiplexedFactories, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		internal KestrelServer(IEnumerable<IConnectionListenerFactory> transportFactories, ServiceContext serviceContext)
		{
			throw null;
		}

		internal KestrelServer(IEnumerable<IConnectionListenerFactory> transportFactories, IEnumerable<IMultiplexedConnectionListenerFactory> multiplexedFactories, ServiceContext serviceContext)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CStartAsync_003Ed__29<>))]
		[DebuggerStepThrough]
		public Task StartAsync<TContext>(IHttpApplication<TContext> application, CancellationToken cancellationToken)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CStopAsync_003Ed__30))]
		[DebuggerStepThrough]
		public Task StopAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}
	}
}
