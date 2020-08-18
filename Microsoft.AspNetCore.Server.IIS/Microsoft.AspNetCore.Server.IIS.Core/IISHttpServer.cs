using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.IIS.Core
{
	internal class IISHttpServer : IServer, IDisposable
	{
		private class IISContextFactory<T> : IISContextFactory
		{
			public IISContextFactory(MemoryPool<byte> memoryPool, IHttpApplication<T> application, IISServerOptions options, IISHttpServer server, ILogger logger)
			{
				throw null;
			}

			public IISHttpContext CreateHttpContext(NativeSafeHandle pInProcessHandler)
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

		public bool IsWebSocketAvailable(NativeSafeHandle pInProcessHandler)
		{
			throw null;
		}

		public IISHttpServer(IISNativeApplication nativeApplication, IHostApplicationLifetime applicationLifetime, IAuthenticationSchemeProvider authentication, IOptions<IISServerOptions> options, ILogger<IISHttpServer> logger)
		{
			throw null;
		}

		public Task StartAsync<TContext>(IHttpApplication<TContext> application, CancellationToken cancellationToken)
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
