using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Hosting
{
	internal class HostedServiceExecutor
	{
		public HostedServiceExecutor(ILogger<HostedServiceExecutor> logger, IEnumerable<IHostedService> services)
		{
			throw null;
		}

		public Task StartAsync(CancellationToken token)
		{
			throw null;
		}

		public Task StopAsync(CancellationToken token)
		{
			throw null;
		}
	}
}
