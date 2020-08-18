using Microsoft.Extensions.Primitives;
using System;

namespace Microsoft.AspNetCore.Http
{
	internal readonly struct HeaderSegment : IEquatable<HeaderSegment>
	{
		private readonly StringSegment _formatting;

		private readonly StringSegment _data;

		public StringSegment Formatting
		{
			get
			{
				throw null;
			}
		}

		public StringSegment Data
		{
			get
			{
				throw null;
			}
		}

		public HeaderSegment(StringSegment formatting, StringSegment data)
		{
			throw null;
		}

		public bool Equals(HeaderSegment other)
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

		public static bool operator ==(HeaderSegment left, HeaderSegment right)
		{
			throw null;
		}

		public static bool operator !=(HeaderSegment left, HeaderSegment right)
		{
			throw null;
		}
	}
}
