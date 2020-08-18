using Microsoft.Extensions.Primitives;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// Contains the parsed form values.
	/// </summary>
	public class FormCollection : IFormCollection, IEnumerable<KeyValuePair<string, StringValues>>, IEnumerable
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

		public static readonly FormCollection Empty;

		public IFormFileCollection Files
		{
			get
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

		public ICollection<string> Keys
		{
			get
			{
				throw null;
			}
		}

		[System.Runtime.CompilerServices.NullableContext(2)]
		public FormCollection(Dictionary<string, StringValues>? fields, IFormFileCollection? files = null)
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
		/// Returns an struct enumerator that iterates through a collection without boxing and is also used via the <see cref="T:Microsoft.AspNetCore.Http.IFormCollection" /> interface.
		/// </summary>
		/// <returns>An <see cref="T:Microsoft.AspNetCore.Http.FormCollection.Enumerator" /> object that can be used to iterate through the collection.</returns>
		public Enumerator GetEnumerator()
		{
			throw null;
		}

		/// <summary>
		/// Returns an enumerator that iterates through a collection, boxes in non-empty path.
		/// </summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
		IEnumerator<KeyValuePair<string, StringValues>> IEnumerable<KeyValuePair<string, StringValues>>.GetEnumerator()
		{
			throw null;
		}

		/// <summary>
		/// Returns an enumerator that iterates through a collection, boxes in non-empty path.
		/// </summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.</returns>
		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}
	}
}
