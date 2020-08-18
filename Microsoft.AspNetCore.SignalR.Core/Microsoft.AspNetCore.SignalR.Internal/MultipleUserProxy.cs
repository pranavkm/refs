using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	internal class MultipleUserProxy<THub> : IClientProxy where THub : Hub
	{
		public MultipleUserProxy(HubLifetimeManager<THub> lifetimeManager, IReadOnlyList<string> userIds)
		{
			throw null;
		}

		public Task SendCoreAsync(string method, object?[]? args, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
