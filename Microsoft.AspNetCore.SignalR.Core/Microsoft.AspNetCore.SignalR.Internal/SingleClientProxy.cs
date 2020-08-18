using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	internal class SingleClientProxy<THub> : IClientProxy where THub : Hub
	{
		public SingleClientProxy(HubLifetimeManager<THub> lifetimeManager, string connectionId)
		{
			throw null;
		}

		public Task SendCoreAsync(string method, object?[]? args, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
