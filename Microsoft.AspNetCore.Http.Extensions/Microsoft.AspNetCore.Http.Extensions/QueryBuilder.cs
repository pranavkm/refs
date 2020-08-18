using Microsoft.Extensions.Primitives;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Http.Extensions
{
	public class QueryBuilder : IEnumerable<KeyValuePair<string, string>>, IEnumerable
	{
		public QueryBuilder()
		{
			throw null;
		}

		public QueryBuilder(IEnumerable<KeyValuePair<string, string>> parameters)
		{
			throw null;
		}

		public QueryBuilder(IEnumerable<KeyValuePair<string, StringValues>> parameters)
		{
			throw null;
		}

		public void Add(string key, IEnumerable<string> values)
		{
			throw null;
		}

		public void Add(string key, string value)
		{
			throw null;
		}

		public override string ToString()
		{
			throw null;
		}

		public QueryString ToQueryString()
		{
			throw null;
		}

		public override int GetHashCode()
		{
			throw null;
		}

		public override bool Equals(object obj)
		{
			throw null;
		}

		public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
		{
			throw null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}
	}
}
