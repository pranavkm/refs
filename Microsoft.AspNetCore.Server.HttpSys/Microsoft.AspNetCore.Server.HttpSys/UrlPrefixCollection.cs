using System.Collections;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	/// <summary>
	/// A collection or URL prefixes
	/// </summary>
	public class UrlPrefixCollection : ICollection<UrlPrefix>, IEnumerable<UrlPrefix>, IEnumerable
	{
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

		internal UrlPrefixCollection()
		{
			throw null;
		}

		public void Add(string prefix)
		{
			throw null;
		}

		public void Add(UrlPrefix item)
		{
			throw null;
		}

		internal UrlPrefix GetPrefix(int id)
		{
			throw null;
		}

		internal bool TryMatchLongestPrefix(bool isHttps, string host, string originalPath, out string pathBase, out string remainingPath)
		{
			throw null;
		}

		public void Clear()
		{
			throw null;
		}

		public bool Contains(UrlPrefix item)
		{
			throw null;
		}

		public void CopyTo(UrlPrefix[] array, int arrayIndex)
		{
			throw null;
		}

		public bool Remove(string prefix)
		{
			throw null;
		}

		public bool Remove(UrlPrefix item)
		{
			throw null;
		}

		public IEnumerator<UrlPrefix> GetEnumerator()
		{
			throw null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}

		internal void RegisterAllPrefixes(UrlGroup urlGroup)
		{
			throw null;
		}

		internal void UnregisterAllPrefixes()
		{
			throw null;
		}
	}
}
