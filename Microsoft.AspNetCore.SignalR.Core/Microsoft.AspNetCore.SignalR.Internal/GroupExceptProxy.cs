using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	internal class GroupExceptProxy<THub> : IClientProxy where THub : Hub
	{
		public GroupExceptProxy(HubLifetimeManager<THub> lifetimeManager, string groupName, IReadOnlyList<string> excludedConnectionIds)
		{
			throw null;
		}

		public Task SendCoreAsync(string method, object?[]? args, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
