using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	internal class AllClientsExceptProxy<THub> : IClientProxy where THub : Hub
	{
		public AllClientsExceptProxy(HubLifetimeManager<THub> lifetimeManager, IReadOnlyList<string> excludedConnectionIds)
		{
			throw null;
		}

		public Task SendCoreAsync(string method, object?[]? args, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
