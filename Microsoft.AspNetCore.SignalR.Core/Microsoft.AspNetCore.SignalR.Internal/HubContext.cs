using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	internal class HubContext<THub> : IHubContext<THub> where THub : Hub
	{
		public IHubClients Clients
		{
			get
			{
				throw null;
			}
		}

		public virtual IGroupManager Groups
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public HubContext(HubLifetimeManager<THub> lifetimeManager)
		{
			throw null;
		}
	}
	internal class HubContext<THub, T> : IHubContext<THub, T> where THub : Hub<T> where T : class
	{
		public IHubClients<T> Clients
		{
			get
			{
				throw null;
			}
		}

		public virtual IGroupManager Groups
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public HubContext(HubLifetimeManager<THub> lifetimeManager)
		{
			throw null;
		}
	}
}
