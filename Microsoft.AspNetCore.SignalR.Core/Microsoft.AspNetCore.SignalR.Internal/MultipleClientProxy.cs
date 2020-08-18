using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	internal class MultipleClientProxy<THub> : IClientProxy where THub : Hub
	{
		public MultipleClientProxy(HubLifetimeManager<THub> lifetimeManager, IReadOnlyList<string> connectionIds)
		{
			throw null;
		}

		public Task SendCoreAsync(string method, object?[]? args, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
