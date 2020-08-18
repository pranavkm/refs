using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	internal class HubGroupList : IReadOnlyCollection<ConcurrentDictionary<string, HubConnectionContext>>, IEnumerable<ConcurrentDictionary<string, HubConnectionContext>>, IEnumerable
	{
		public ConcurrentDictionary<string, HubConnectionContext>? this[string groupName]
		{
			get
			{
				throw null;
			}
		}

		public int Count
		{
			get
			{
				throw null;
			}
		}

		public void Add(HubConnectionContext connection, string groupName)
		{
			throw null;
		}

		public void Remove(string connectionId, string groupName)
		{
			throw null;
		}

		public void RemoveDisconnectedConnection(string connectionId)
		{
			throw null;
		}

		public IEnumerator<ConcurrentDictionary<string, HubConnectionContext>> GetEnumerator()
		{
			throw null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}

		public HubGroupList()
		{
			throw null;
		}
	}
}
