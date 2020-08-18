using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.SignalR
{
	public class HubConnectionStore
	{
		public readonly struct Enumerator : IEnumerator<HubConnectionContext>, IEnumerator, IDisposable
		{
			private readonly IEnumerator<KeyValuePair<string, HubConnectionContext>> _enumerator;

			public HubConnectionContext Current
			{
				get
				{
					throw null;
				}
			}

			object IEnumerator.Current
			{
				get
				{
					throw null;
				}
			}

			public Enumerator(HubConnectionStore hubConnectionList)
			{
				throw null;
			}

			public void Dispose()
			{
				throw null;
			}

			public bool MoveNext()
			{
				throw null;
			}

			public void Reset()
			{
				throw null;
			}
		}

		public HubConnectionContext? this[string connectionId]
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

		public void Add(HubConnectionContext connection)
		{
			throw null;
		}

		public void Remove(HubConnectionContext connection)
		{
			throw null;
		}

		public Enumerator GetEnumerator()
		{
			throw null;
		}

		public HubConnectionStore()
		{
			throw null;
		}
	}
}
