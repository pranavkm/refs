using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Routing
{
	internal struct PathTokenizer : IReadOnlyList<StringSegment>, IEnumerable<StringSegment>, IEnumerable, IReadOnlyCollection<StringSegment>
	{
		public struct Enumerator : IEnumerator<StringSegment>, IEnumerator, IDisposable
		{
			private readonly string _path;

			private int _index;

			private int _length;

			public StringSegment Current
			{
				get
				{
					throw null;
				}
			}

			object IEnumerator.Current
			{
				get
				{
					throw null;
				}
			}

			public Enumerator(PathTokenizer tokenizer)
			{
				throw null;
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
		}

		private readonly string _path;

		private int _count;

		public int Count
		{
			get
			{
				throw null;
			}
		}

		public StringSegment this[int index]
		{
			get
			{
				throw null;
			}
		}

		public PathTokenizer(PathString path)
		{
			throw null;
		}

		public Enumerator GetEnumerator()
		{
			throw null;
		}

		IEnumerator<StringSegment> IEnumerable<StringSegment>.GetEnumerator()
		{
			throw null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}
	}
}
