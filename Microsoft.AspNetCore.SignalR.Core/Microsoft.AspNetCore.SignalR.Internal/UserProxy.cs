using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	internal class UserProxy<THub> : IClientProxy where THub : Hub
	{
		public UserProxy(HubLifetimeManager<THub> lifetimeManager, string userId)
		{
			throw null;
		}

		public Task SendCoreAsync(string method, object?[]? args, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
