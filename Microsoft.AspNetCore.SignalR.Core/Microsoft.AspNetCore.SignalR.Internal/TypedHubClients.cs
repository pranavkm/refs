using System.Collections.Generic;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	internal class TypedHubClients<T> : IHubCallerClients<T>, IHubClients<T>
	{
		public T All
		{
			get
			{
				throw null;
			}
		}

		public T Caller
		{
			get
			{
				throw null;
			}
		}

		public T Others
		{
			get
			{
				throw null;
			}
		}

		public TypedHubClients(IHubCallerClients dynamicContext)
		{
			throw null;
		}

		public T AllExcept(IReadOnlyList<string> excludedConnectionIds)
		{
			throw null;
		}

		public T Client(string connectionId)
		{
			throw null;
		}

		public T Group(string groupName)
		{
			throw null;
		}

		public T GroupExcept(string groupName, IReadOnlyList<string> excludedConnectionIds)
		{
			throw null;
		}

		public T Clients(IReadOnlyList<string> connectionIds)
		{
			throw null;
		}

		public T Groups(IReadOnlyList<string> groupNames)
		{
			throw null;
		}

		public T OthersInGroup(string groupName)
		{
			throw null;
		}

		public T User(string userId)
		{
			throw null;
		}

		public T Users(IReadOnlyList<string> userIds)
		{
			throw null;
		}
	}
}
