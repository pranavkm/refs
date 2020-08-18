using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Http.Connections.Internal
{
	internal class ConnectionLogScope : IReadOnlyList<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable, IReadOnlyCollection<KeyValuePair<string, object>>
	{
		public string ConnectionId
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public KeyValuePair<string, object> this[int index]
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

		public ConnectionLogScope(string connectionId)
		{
			throw null;
		}

		[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__10))]
		public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
		{
			throw null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}

		public override string ToString()
		{
			throw null;
		}
	}
}
