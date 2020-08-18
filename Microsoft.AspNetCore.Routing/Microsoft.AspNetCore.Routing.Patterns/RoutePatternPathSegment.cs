using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Patterns
{
	/// <summary>
	/// Represents a path segment in a route pattern. Instances of <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternPathSegment" /> are
	/// immutable.
	/// </summary>
	/// <remarks>
	/// Route patterns are made up of URL path segments, delimited by <c>/</c>. A
	/// <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternPathSegment" /> contains a group of 
	/// <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternPart" /> that represent the structure of a segment
	/// in a route pattern.
	/// </remarks>
	[DebuggerDisplay("{DebuggerToString()}")]
	public sealed class RoutePatternPathSegment
	{
		/// <summary>
		/// Returns <c>true</c> if the segment contains a single part;
		/// otherwise returns <c>false</c>.
		/// </summary>
		public bool IsSimple
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the list of parts in this segment.
		/// </summary>
		public IReadOnlyList<RoutePatternPart> Parts
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal RoutePatternPathSegment(IReadOnlyList<RoutePatternPart> parts)
		{
			throw null;
		}

		internal string DebuggerToString()
		{
			throw null;
		}

		internal static string DebuggerToString(IReadOnlyList<RoutePatternPart> parts)
		{
			throw null;
		}
	}
}
