using System.Collections.Concurrent;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	internal class GroupConnectionList : ConcurrentDictionary<string, HubConnectionContext>
	{
		public override bool Equals(object? obj)
		{
			throw null;
		}

		public override int GetHashCode()
		{
			throw null;
		}

		public GroupConnectionList()
		{
			throw null;
		}
	}
}
