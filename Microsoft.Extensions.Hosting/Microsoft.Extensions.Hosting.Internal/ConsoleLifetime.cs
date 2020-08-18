using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Hosting.Internal
{
	/// <summary>
	/// Listens for Ctrl+C or SIGTERM and initiates shutdown.
	/// </summary>
	public class ConsoleLifetime : IHostLifetime, IDisposable
	{
		public ConsoleLifetime(IOptions<ConsoleLifetimeOptions> options, IHostEnvironment environment, IHostApplicationLifetime applicationLifetime, IOptions<HostOptions> hostOptions)
		{
		}

		public ConsoleLifetime(IOptions<ConsoleLifetimeOptions> options, IHostEnvironment environment, IHostApplicationLifetime applicationLifetime, IOptions<HostOptions> hostOptions, ILoggerFactory loggerFactory)
		{
		}

		public void Dispose()
		{
		}

		public Task StopAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		public Task WaitForStartAsync(CancellationToken cancellationToken)
		{
			throw null;
		}
	}
}
