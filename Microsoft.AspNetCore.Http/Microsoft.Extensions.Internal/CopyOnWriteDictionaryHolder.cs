using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Extensions.Internal
{
	internal struct CopyOnWriteDictionaryHolder<TKey, TValue> where TKey : notnull
	{
		private readonly Dictionary<TKey, TValue> _source;

		private Dictionary<TKey, TValue>? _copy;

		public bool HasBeenCopied
		{
			get
			{
				throw null;
			}
		}

		public Dictionary<TKey, TValue> ReadDictionary
		{
			get
			{
				throw null;
			}
		}

		public Dictionary<TKey, TValue> WriteDictionary
		{
			get
			{
				throw null;
			}
		}

		public Dictionary<TKey, TValue>.KeyCollection Keys
		{
			get
			{
				throw null;
			}
		}

		public Dictionary<TKey, TValue>.ValueCollection Values
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

		public bool IsReadOnly
		{
			get
			{
				throw null;
			}
		}

		public TValue this[TKey key]
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

		public CopyOnWriteDictionaryHolder(Dictionary<TKey, TValue> source)
		{
			throw null;
		}

		public CopyOnWriteDictionaryHolder(CopyOnWriteDictionaryHolder<TKey, TValue> source)
		{
			throw null;
		}

		public bool ContainsKey(TKey key)
		{
			throw null;
		}

		public void Add(TKey key, TValue value)
		{
			throw null;
		}

		public bool Remove(TKey key)
		{
			throw null;
		}

		public bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value)
		{
			throw null;
		}

		public void Add(KeyValuePair<TKey, TValue> item)
		{
			throw null;
		}

		public void Clear()
		{
			throw null;
		}

		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			throw null;
		}

		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			throw null;
		}

		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			throw null;
		}

		public Dictionary<TKey, TValue>.Enumerator GetEnumerator()
		{
			throw null;
		}
	}
}
