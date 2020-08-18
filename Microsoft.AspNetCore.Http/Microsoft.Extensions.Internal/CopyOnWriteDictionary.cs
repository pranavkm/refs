using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Extensions.Internal
{
	internal class CopyOnWriteDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable where TKey : notnull
	{
		public virtual ICollection<TKey> Keys
		{
			get
			{
				throw null;
			}
		}

		public virtual ICollection<TValue> Values
		{
			get
			{
				throw null;
			}
		}

		public virtual int Count
		{
			get
			{
				throw null;
			}
		}

		public virtual bool IsReadOnly
		{
			get
			{
				throw null;
			}
		}

		public virtual TValue this[TKey key]
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

		public CopyOnWriteDictionary(IDictionary<TKey, TValue> sourceDictionary, IEqualityComparer<TKey> comparer)
		{
			throw null;
		}

		public virtual bool ContainsKey(TKey key)
		{
			throw null;
		}

		public virtual void Add(TKey key, TValue value)
		{
			throw null;
		}

		public virtual bool Remove(TKey key)
		{
			throw null;
		}

		public virtual bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value)
		{
			throw null;
		}

		public virtual void Add(KeyValuePair<TKey, TValue> item)
		{
			throw null;
		}

		public virtual void Clear()
		{
			throw null;
		}

		public virtual bool Contains(KeyValuePair<TKey, TValue> item)
		{
			throw null;
		}

		public virtual void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			throw null;
		}

		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			throw null;
		}

		public virtual IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			throw null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}
	}
}
