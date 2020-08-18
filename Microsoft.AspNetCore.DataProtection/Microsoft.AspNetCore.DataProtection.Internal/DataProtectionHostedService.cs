using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.DataProtection.Internal
{
	internal class DataProtectionHostedService : IHostedService
	{
		public DataProtectionHostedService(IKeyRingProvider keyRingProvider)
		{
			throw null;
		}

		public DataProtectionHostedService(IKeyRingProvider keyRingProvider, ILoggerFactory loggerFactory)
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
