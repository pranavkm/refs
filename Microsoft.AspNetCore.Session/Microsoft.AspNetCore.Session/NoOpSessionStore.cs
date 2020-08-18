using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Session
{
	internal class NoOpSessionStore : IDictionary<EncodedKey, byte[]>, ICollection<KeyValuePair<EncodedKey, byte[]>>, IEnumerable<KeyValuePair<EncodedKey, byte[]>>, IEnumerable
	{
		public byte[] this[EncodedKey key]
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public int Count
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public bool IsReadOnly
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public ICollection<EncodedKey> Keys
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public ICollection<byte[]> Values
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public void Add(KeyValuePair<EncodedKey, byte[]> item)
		{
			throw null;
		}

		public void Add(EncodedKey key, byte[] value)
		{
			throw null;
		}

		public void Clear()
		{
			throw null;
		}

		public bool Contains(KeyValuePair<EncodedKey, byte[]> item)
		{
			throw null;
		}

		public bool ContainsKey(EncodedKey key)
		{
			throw null;
		}

		public void CopyTo(KeyValuePair<EncodedKey, byte[]>[] array, int arrayIndex)
		{
			throw null;
		}

		public IEnumerator<KeyValuePair<EncodedKey, byte[]>> GetEnumerator()
		{
			throw null;
		}

		public bool Remove(KeyValuePair<EncodedKey, byte[]> item)
		{
			throw null;
		}

		public bool Remove(EncodedKey key)
		{
			throw null;
		}

		public bool TryGetValue(EncodedKey key, out byte[] value)
		{
			throw null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}

		public NoOpSessionStore()
		{
			throw null;
		}
	}
}
