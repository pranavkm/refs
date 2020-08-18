using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	internal class GroupManager<THub> : IGroupManager where THub : Hub
	{
		public GroupManager(HubLifetimeManager<THub> lifetimeManager)
		{
			throw null;
		}

		public Task AddToGroupAsync(string connectionId, string groupName, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		public Task RemoveFromGroupAsync(string connectionId, string groupName, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
