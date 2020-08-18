using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Hosting
{
	internal class WebHost : IWebHost, IDisposable, IAsyncDisposable
	{
		internal WebHostOptions Options
		{
			get
			{
				throw null;
			}
		}

		public IServiceProvider Services
		{
			get
			{
				throw null;
			}
		}

		public IFeatureCollection ServerFeatures
		{
			get
			{
				throw null;
			}
		}

		public WebHost(IServiceCollection appServices, IServiceProvider hostingServiceProvider, WebHostOptions options, IConfiguration config, AggregateException hostingStartupErrors)
		{
			throw null;
		}

		public void Initialize()
		{
			throw null;
		}

		public void Start()
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CStartAsync_003Ed__27))]
		[DebuggerStepThrough]
		public virtual Task StartAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CStopAsync_003Ed__32))]
		[DebuggerStepThrough]
		public Task StopAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__34))]
		[DebuggerStepThrough]
		public ValueTask DisposeAsync()
		{
			throw null;
		}
	}
}
