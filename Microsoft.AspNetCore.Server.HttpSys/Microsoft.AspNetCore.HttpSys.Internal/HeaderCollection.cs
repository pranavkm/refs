using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.HttpSys.Internal
{
	internal class HeaderCollection : IHeaderDictionary, IDictionary<string, StringValues>, ICollection<KeyValuePair<string, StringValues>>, IEnumerable<KeyValuePair<string, StringValues>>, IEnumerable
	{
		internal static readonly HashSet<string> DisallowedTrailers;

		public bool IsReadOnly
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			internal set
			{
				throw null;
			}
		}

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

		public ICollection<StringValues> Values
		{
			get
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

		public HeaderCollection(bool checkTrailers = false)
		{
			throw null;
		}

		public HeaderCollection(IDictionary<string, StringValues> store)
		{
			throw null;
		}

		public void Add(KeyValuePair<string, StringValues> item)
		{
			throw null;
		}

		public void Add(string key, StringValues value)
		{
			throw null;
		}

		public void Append(string key, string value)
		{
			throw null;
		}

		public void Clear()
		{
			throw null;
		}

		public bool Contains(KeyValuePair<string, StringValues> item)
		{
			throw null;
		}

		public bool ContainsKey(string key)
		{
			throw null;
		}

		public void CopyTo(KeyValuePair<string, StringValues>[] array, int arrayIndex)
		{
			throw null;
		}

		public IEnumerator<KeyValuePair<string, StringValues>> GetEnumerator()
		{
			throw null;
		}

		public IEnumerable<string> GetValues(string key)
		{
			throw null;
		}

		public bool Remove(KeyValuePair<string, StringValues> item)
		{
			throw null;
		}

		public bool Remove(string key)
		{
			throw null;
		}

		public bool TryGetValue(string key, out StringValues value)
		{
			throw null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}

		public static void ValidateHeaderCharacters(StringValues headerValues)
		{
			throw null;
		}

		public static void ValidateHeaderCharacters(string headerCharacters)
		{
			throw null;
		}
	}
}
