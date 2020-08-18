using Microsoft.Extensions.Primitives;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// Represents a wrapper for RequestHeaders and ResponseHeaders.
	/// </summary>
	public class HeaderDictionary : IHeaderDictionary, IDictionary<string, StringValues>, ICollection<KeyValuePair<string, StringValues>>, IEnumerable<KeyValuePair<string, StringValues>>, IEnumerable
	{
		public struct Enumerator : IEnumerator<KeyValuePair<string, StringValues>>, IEnumerator, IDisposable
		{
			private Dictionary<string, StringValues>.Enumerator _dictionaryEnumerator;

			private bool _notEmpty;

			public KeyValuePair<string, StringValues> Current
			{
				get
				{
					throw null;
				}
			}

			object IEnumerator.Current
			{
				[System.Runtime.CompilerServices.NullableContext(1)]
				get
				{
					throw null;
				}
			}

			internal Enumerator(Dictionary<string, StringValues>.Enumerator dictionaryEnumerator)
			{
				throw null;
			}

			public bool MoveNext()
			{
				throw null;
			}

			public void Dispose()
			{
				throw null;
			}

			void IEnumerator.Reset()
			{
				throw null;
			}
		}

		/// <summary>
		/// Get or sets the associated value from the collection as a single string.
		/// </summary>
		/// <param name="key">The header name.</param>
		/// <returns>the associated value from the collection as a StringValues or StringValues.Empty if the key is not present.</returns>
		public StringValues this[string key]
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

		/// <summary>
		/// Throws KeyNotFoundException if the key is not present.
		/// </summary>
		/// <param name="key">The header name.</param>
		/// <returns></returns>
		StringValues IDictionary<string, StringValues>.this[string key]
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

		public long? ContentLength
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

		/// <summary>
		/// Gets the number of elements contained in the <see cref="T:Microsoft.AspNetCore.Http.HeaderDictionary" />;.
		/// </summary>
		/// <returns>The number of elements contained in the <see cref="T:Microsoft.AspNetCore.Http.HeaderDictionary" />.</returns>
		public int Count
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets a value that indicates whether the <see cref="T:Microsoft.AspNetCore.Http.HeaderDictionary" /> is in read-only mode.
		/// </summary>
		/// <returns>true if the <see cref="T:Microsoft.AspNetCore.Http.HeaderDictionary" /> is in read-only mode; otherwise, false.</returns>
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

		public ICollection<string> Keys
		{
			get
			{
				throw null;
			}
		}

		public ICollection<StringValues> Values
		{
			get
			{
				throw null;
			}
		}

		public HeaderDictionary()
		{
			throw null;
		}

		public HeaderDictionary(Dictionary<string, StringValues>? store)
		{
			throw null;
		}

		public HeaderDictionary(int capacity)
		{
			throw null;
		}

		/// <summary>
		/// Adds a new list of items to the collection.
		/// </summary>
		/// <param name="item">The item to add.</param>
		public void Add(KeyValuePair<string, StringValues> item)
		{
			throw null;
		}

		/// <summary>
		/// Adds the given header and values to the collection.
		/// </summary>
		/// <param name="key">The header name.</param>
		/// <param name="value">The header values.</param>
		public void Add(string key, StringValues value)
		{
			throw null;
		}

		/// <summary>
		/// Clears the entire list of objects.
		/// </summary>
		public void Clear()
		{
			throw null;
		}

		/// <summary>
		/// Returns a value indicating whether the specified object occurs within this collection.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <returns>true if the specified object occurs within this collection; otherwise, false.</returns>
		public bool Contains(KeyValuePair<string, StringValues> item)
		{
			throw null;
		}

		/// <summary>
		/// Determines whether the <see cref="T:Microsoft.AspNetCore.Http.HeaderDictionary" /> contains a specific key.
		/// </summary>
		/// <param name="key">The key.</param>
		/// <returns>true if the <see cref="T:Microsoft.AspNetCore.Http.HeaderDictionary" /> contains a specific key; otherwise, false.</returns>
		public bool ContainsKey(string key)
		{
			throw null;
		}

		/// <summary>
		/// Copies the <see cref="T:Microsoft.AspNetCore.Http.HeaderDictionary" /> elements to a one-dimensional Array instance at the specified index.
		/// </summary>
		/// <param name="array">The one-dimensional Array that is the destination of the specified objects copied from the <see cref="T:Microsoft.AspNetCore.Http.HeaderDictionary" />.</param>
		/// <param name="arrayIndex">The zero-based index in <paramref name="array" /> at which copying begins.</param>
		public void CopyTo(KeyValuePair<string, StringValues>[] array, int arrayIndex)
		{
			throw null;
		}

		/// <summary>
		/// Removes the given item from the the collection.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <returns>true if the specified object was removed from the collection; otherwise, false.</returns>
		public bool Remove(KeyValuePair<string, StringValues> item)
		{
			throw null;
		}

		/// <summary>
		/// Removes the given header from the collection.
		/// </summary>
		/// <param name="key">The header name.</param>
		/// <returns>true if the specified object was removed from the collection; otherwise, false.</returns>
		public bool Remove(string key)
		{
			throw null;
		}

		/// <summary>
		/// Retrieves a value from the dictionary.
		/// </summary>
		/// <param name="key">The header name.</param>
		/// <param name="value">The value.</param>
		/// <returns>true if the <see cref="T:Microsoft.AspNetCore.Http.HeaderDictionary" /> contains the key; otherwise, false.</returns>
		public bool TryGetValue(string key, out StringValues value)
		{
			throw null;
		}

		/// <summary>
		/// Returns an enumerator that iterates through a collection.
		/// </summary>
		/// <returns>An <see cref="T:Microsoft.AspNetCore.Http.HeaderDictionary.Enumerator" /> object that can be used to iterate through the collection.</returns>
		public Enumerator GetEnumerator()
		{
			throw null;
		}

		/// <summary>
		/// Returns an enumerator that iterates through a collection.
		/// </summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
		IEnumerator<KeyValuePair<string, StringValues>> IEnumerable<KeyValuePair<string, StringValues>>.GetEnumerator()
		{
			throw null;
		}

		/// <summary>
		/// Returns an enumerator that iterates through a collection.
		/// </summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}
	}
}
