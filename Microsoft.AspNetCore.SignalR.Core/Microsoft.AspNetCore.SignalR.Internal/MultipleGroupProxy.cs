using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	internal class MultipleGroupProxy<THub> : IClientProxy where THub : Hub
	{
		public MultipleGroupProxy(HubLifetimeManager<THub> lifetimeManager, IReadOnlyList<string> groupNames)
		{
			throw null;
		}

		public Task SendCoreAsync(string method, object?[]? args, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
