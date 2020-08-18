using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	internal class AllClientProxy<THub> : IClientProxy where THub : Hub
	{
		public AllClientProxy(HubLifetimeManager<THub> lifetimeManager)
		{
			throw null;
		}

		public Task SendCoreAsync(string method, object?[]? args, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
