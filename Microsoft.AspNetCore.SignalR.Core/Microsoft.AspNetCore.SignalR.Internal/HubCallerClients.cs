using System.Collections.Generic;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	internal class HubCallerClients : IHubCallerClients, IHubCallerClients<IClientProxy>, IHubClients<IClientProxy>
	{
		public IClientProxy Caller
		{
			get
			{
				throw null;
			}
		}

		public IClientProxy Others
		{
			get
			{
				throw null;
			}
		}

		public IClientProxy All
		{
			get
			{
				throw null;
			}
		}

		public HubCallerClients(IHubClients hubClients, string connectionId)
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

		public IClientProxy Groups(IReadOnlyList<string> groupNames)
		{
			throw null;
		}

		public IClientProxy OthersInGroup(string groupName)
		{
			throw null;
		}

		public IClientProxy GroupExcept(string groupName, IReadOnlyList<string> excludedConnectionIds)
		{
			throw null;
		}

		public IClientProxy User(string userId)
		{
			throw null;
		}

		public IClientProxy Clients(IReadOnlyList<string> connectionIds)
		{
			throw null;
		}

		public IClientProxy Users(IReadOnlyList<string> userIds)
		{
			throw null;
		}
	}
}
