using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal
{
	internal class ServerAddressesCollection : ICollection<string>, IEnumerable<string>, IEnumerable
	{
		private class PublicServerAddressesCollection : ICollection<string>, IEnumerable<string>, IEnumerable
		{
			public bool IsReadOnly
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

			public int Count
			{
				get
				{
					throw null;
				}
			}

			public PublicServerAddressesCollection(ServerAddressesCollection addresses)
			{
				throw null;
			}

			public void Add(string item)
			{
				throw null;
			}

			public bool Remove(string item)
			{
				throw null;
			}

			public void Clear()
			{
				throw null;
			}

			public bool Contains(string item)
			{
				throw null;
			}

			public void CopyTo(string[] array, int arrayIndex)
			{
				throw null;
			}

			public IEnumerator<string> GetEnumerator()
			{
				throw null;
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				throw null;
			}
		}

		public ICollection<string> PublicCollection
		{
			get
			{
				throw null;
			}
		}

		public bool IsReadOnly
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

		public ServerAddressesCollection()
		{
			throw null;
		}

		public void PreventPublicMutation()
		{
			throw null;
		}

		public void Add(string item)
		{
			throw null;
		}

		public bool Remove(string item)
		{
			throw null;
		}

		public void Clear()
		{
			throw null;
		}

		public bool Contains(string item)
		{
			throw null;
		}

		public void CopyTo(string[] array, int arrayIndex)
		{
			throw null;
		}

		public IEnumerator<string> GetEnumerator()
		{
			throw null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}
	}
}
