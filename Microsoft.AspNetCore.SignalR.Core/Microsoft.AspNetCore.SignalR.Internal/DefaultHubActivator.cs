using System;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	internal class DefaultHubActivator<THub> : IHubActivator<THub> where THub : Hub
	{
		public DefaultHubActivator(IServiceProvider serviceProvider)
		{
			throw null;
		}

		public virtual THub Create()
		{
			throw null;
		}

		public virtual void Release(THub hub)
		{
			throw null;
		}
	}
}
