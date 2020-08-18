using Microsoft.AspNetCore.Hosting.Builder;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Hosting
{
	internal class GenericWebHostService : IHostedService
	{
		public GenericWebHostServiceOptions Options
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public IServer Server
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public ILogger Logger
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public ILogger LifetimeLogger
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public DiagnosticListener DiagnosticListener
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public IHttpContextFactory HttpContextFactory
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public IApplicationBuilderFactory ApplicationBuilderFactory
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public IEnumerable<IStartupFilter> StartupFilters
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
		}

		public IWebHostEnvironment HostingEnvironment
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public GenericWebHostService(IOptions<GenericWebHostServiceOptions> options, IServer server, ILoggerFactory loggerFactory, DiagnosticListener diagnosticListener, IHttpContextFactory httpContextFactory, IApplicationBuilderFactory applicationBuilderFactory, IEnumerable<IStartupFilter> startupFilters, IConfiguration configuration, IWebHostEnvironment hostingEnvironment)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CStartAsync_003Ed__31))]
		[DebuggerStepThrough]
		public Task StartAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CStopAsync_003Ed__33))]
		[DebuggerStepThrough]
		public Task StopAsync(CancellationToken cancellationToken)
		{
			throw null;
		}
	}
}
