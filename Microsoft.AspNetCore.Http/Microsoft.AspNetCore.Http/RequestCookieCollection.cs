using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Http
{
	internal class RequestCookieCollection : IRequestCookieCollection, IEnumerable<KeyValuePair<string, string>>, IEnumerable
	{
		public struct Enumerator : IEnumerator<KeyValuePair<string, string>>, IEnumerator, IDisposable
		{
			private Dictionary<string, string>.Enumerator _dictionaryEnumerator;

			private bool _notEmpty;

			public KeyValuePair<string, string> Current
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

			internal Enumerator(Dictionary<string, string>.Enumerator dictionaryEnumerator)
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

			public void Reset()
			{
				throw null;
			}
		}

		public static readonly RequestCookieCollection Empty;

		public string? this[string key]
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

		public ICollection<string> Keys
		{
			get
			{
				throw null;
			}
		}

		public RequestCookieCollection()
		{
			throw null;
		}

		public RequestCookieCollection(Dictionary<string, string> store)
		{
			throw null;
		}

		public RequestCookieCollection(int capacity)
		{
			throw null;
		}

		public static RequestCookieCollection Parse(IList<string> values)
		{
			throw null;
		}

		internal static RequestCookieCollection ParseInternal(IList<string> values, bool enableCookieNameEncoding)
		{
			throw null;
		}

		public bool ContainsKey(string key)
		{
			throw null;
		}

		public bool TryGetValue(string key, [MaybeNullWhen(false)] out string? value)
		{
			throw null;
		}

		/// <summary>
		/// Returns an struct enumerator that iterates through a collection without boxing.
		/// </summary>
		/// <returns>An <see cref="T:Microsoft.AspNetCore.Http.RequestCookieCollection.Enumerator" /> object that can be used to iterate through the collection.</returns>
		public Enumerator GetEnumerator()
		{
			throw null;
		}

		/// <summary>
		/// Returns an enumerator that iterates through a collection, boxes in non-empty path.
		/// </summary>
		/// <returns>An <see cref="T:System.Collections.Generic.IEnumerator`1" /> object that can be used to iterate through the collection.</returns>
		IEnumerator<KeyValuePair<string, string>> IEnumerable<KeyValuePair<string, string>>.GetEnumerator()
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
