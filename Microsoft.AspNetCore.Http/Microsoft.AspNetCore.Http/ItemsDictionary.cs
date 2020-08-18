using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Http
{
	internal class ItemsDictionary : IDictionary<object, object?>, ICollection<KeyValuePair<object, object?>>, IEnumerable<KeyValuePair<object, object?>>, IEnumerable
	{
		private class EmptyEnumerator : IEnumerator<KeyValuePair<object, object?>>, IEnumerator, IDisposable
		{
			public static readonly IEnumerator<KeyValuePair<object, object?>> Instance;

			public KeyValuePair<object, object?> Current
			{
				get
				{
					throw null;
				}
			}

			object? IEnumerator.Current
			{
				[System.Runtime.CompilerServices.NullableContext(2)]
				get
				{
					throw null;
				}
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

			public EmptyEnumerator()
			{
				throw null;
			}
		}

		private static class EmptyDictionary
		{
			public static readonly IDictionary<object, object?> Dictionary;

			public static ICollection<KeyValuePair<object, object?>> Collection
			{
				get
				{
					throw null;
				}
			}
		}

		public IDictionary<object, object?> Items
		{
			get
			{
				throw null;
			}
		}

		object? IDictionary<object, object>.this[object key]
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

		ICollection<object> IDictionary<object, object>.Keys
		{
			get
			{
				throw null;
			}
		}

		ICollection<object?> IDictionary<object, object>.Values
		{
			get
			{
				throw null;
			}
		}

		int ICollection<KeyValuePair<object, object>>.Count
		{
			get
			{
				throw null;
			}
		}

		bool ICollection<KeyValuePair<object, object>>.IsReadOnly
		{
			get
			{
				throw null;
			}
		}

		public ItemsDictionary()
		{
			throw null;
		}

		public ItemsDictionary(IDictionary<object, object?> items)
		{
			throw null;
		}

		void IDictionary<object, object>.Add(object key, object? value)
		{
			throw null;
		}

		bool IDictionary<object, object>.ContainsKey(object key)
		{
			throw null;
		}

		bool IDictionary<object, object>.Remove(object key)
		{
			throw null;
		}

		bool IDictionary<object, object>.TryGetValue(object key, out object? value)
		{
			throw null;
		}

		void ICollection<KeyValuePair<object, object>>.Add(KeyValuePair<object, object?> item)
		{
			throw null;
		}

		void ICollection<KeyValuePair<object, object>>.Clear()
		{
			throw null;
		}

		bool ICollection<KeyValuePair<object, object>>.Contains(KeyValuePair<object, object?> item)
		{
			throw null;
		}

		void ICollection<KeyValuePair<object, object>>.CopyTo(KeyValuePair<object, object?>[] array, int arrayIndex)
		{
			throw null;
		}

		bool ICollection<KeyValuePair<object, object>>.Remove(KeyValuePair<object, object?> item)
		{
			throw null;
		}

		IEnumerator<KeyValuePair<object, object?>> IEnumerable<KeyValuePair<object, object>>.GetEnumerator()
		{
			throw null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}
	}
}
