using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	internal class GroupProxy<THub> : IClientProxy where THub : Hub
	{
		public GroupProxy(HubLifetimeManager<THub> lifetimeManager, string groupName)
		{
			throw null;
		}

		public Task SendCoreAsync(string method, object?[]? args, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
