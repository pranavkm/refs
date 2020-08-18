using Microsoft.Extensions.Primitives;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Http
{
	internal readonly struct HeaderSegmentCollection : IEnumerable<HeaderSegment>, IEnumerable, IEquatable<HeaderSegmentCollection>
	{
		public struct Enumerator : IEnumerator<HeaderSegment>, IEnumerator, IDisposable
		{
			private enum Mode
			{
				Leading,
				Value,
				ValueQuoted,
				Trailing,
				Produce
			}

			private enum Attr
			{
				Value,
				Quote,
				Delimiter,
				Whitespace
			}

			private readonly StringValues _headers;

			private int _index;

			private string _header;

			private int _headerLength;

			private int _offset;

			private int _leadingStart;

			private int _leadingEnd;

			private int _valueStart;

			private int _valueEnd;

			private int _trailingStart;

			private Mode _mode;

			public HeaderSegment Current
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

			public Enumerator(StringValues headers)
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

		private readonly StringValues _headers;

		public HeaderSegmentCollection(StringValues headers)
		{
			throw null;
		}

		public bool Equals(HeaderSegmentCollection other)
		{
			throw null;
		}

		public override bool Equals(object? obj)
		{
			throw null;
		}

		public override int GetHashCode()
		{
			throw null;
		}

		public static bool operator ==(HeaderSegmentCollection left, HeaderSegmentCollection right)
		{
			throw null;
		}

		public static bool operator !=(HeaderSegmentCollection left, HeaderSegmentCollection right)
		{
			throw null;
		}

		public Enumerator GetEnumerator()
		{
			throw null;
		}

		IEnumerator<HeaderSegment> IEnumerable<HeaderSegment>.GetEnumerator()
		{
			throw null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}
	}
}
