using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	internal class HubClients<THub> : IHubClients, IHubClients<IClientProxy> where THub : Hub
	{
		public IClientProxy All
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public HubClients(HubLifetimeManager<THub> lifetimeManager)
		{
			throw null;
		}

		public IClientProxy AllExcept(IReadOnlyList<string> excludedConnectionIds)
		{
			throw null;
		}

		public IClientProxy Client(string connectionId)
		{
			throw null;
		}

		public IClientProxy Group(string groupName)
		{
			throw null;
		}

		public IClientProxy GroupExcept(string groupName, IReadOnlyList<string> excludedConnectionIds)
		{
			throw null;
		}

		public IClientProxy Clients(IReadOnlyList<string> connectionIds)
		{
			throw null;
		}

		public IClientProxy Groups(IReadOnlyList<string> groupNames)
		{
			throw null;
		}

		public IClientProxy User(string userId)
		{
			throw null;
		}

		public IClientProxy Users(IReadOnlyList<string> userIds)
		{
			throw null;
		}
	}
	internal class HubClients<THub, T> : IHubClients<T> where THub : Hub
	{
		public T All
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public HubClients(HubLifetimeManager<THub> lifetimeManager)
		{
			throw null;
		}

		public T AllExcept(IReadOnlyList<string> excludedConnectionIds)
		{
			throw null;
		}

		public virtual T Client(string connectionId)
		{
			throw null;
		}

		public T Clients(IReadOnlyList<string> connectionIds)
		{
			throw null;
		}

		public virtual T Group(string groupName)
		{
			throw null;
		}

		public T GroupExcept(string groupName, IReadOnlyList<string> excludedConnectionIds)
		{
			throw null;
		}

		public T Groups(IReadOnlyList<string> groupNames)
		{
			throw null;
		}

		public virtual T User(string userId)
		{
			throw null;
		}

		public virtual T Users(IReadOnlyList<string> userIds)
		{
			throw null;
		}
	}
}
