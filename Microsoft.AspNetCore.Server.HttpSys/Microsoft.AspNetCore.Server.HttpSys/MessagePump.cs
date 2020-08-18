using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	internal class MessagePump : IServer, IDisposable
	{
		private class ApplicationWrapper<TContext> : IHttpApplication<object>
		{
			public ApplicationWrapper(IHttpApplication<TContext> application)
			{
				throw null;
			}

			public object CreateContext(IFeatureCollection contextFeatures)
			{
				throw null;
			}

			public void DisposeContext(object context, Exception exception)
			{
				throw null;
			}

			public Task ProcessRequestAsync(object context)
			{
				throw null;
			}
		}

		internal HttpSysListener Listener
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal IHttpApplication<object> Application
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

		public IFeatureCollection Features
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal bool Stopping
		{
			get
			{
				throw null;
			}
		}

		public MessagePump(IOptions<HttpSysOptions> options, ILoggerFactory loggerFactory, IAuthenticationSchemeProvider authentication)
		{
			throw null;
		}

		public Task StartAsync<TContext>(IHttpApplication<TContext> application, CancellationToken cancellationToken)
		{
			throw null;
		}

		internal int IncrementOutstandingRequest()
		{
			throw null;
		}

		internal int DecrementOutstandingRequest()
		{
			throw null;
		}

		internal void SetShutdownSignal()
		{
			throw null;
		}

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
