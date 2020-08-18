using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Patterns;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing
{
	internal class RoutePatternMatcher
	{
		public RouteValueDictionary Defaults
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public RoutePattern RoutePattern
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public RoutePatternMatcher(RoutePattern pattern, RouteValueDictionary defaults)
		{
			throw null;
		}

		public bool TryMatch(PathString path, RouteValueDictionary values)
		{
			throw null;
		}

		internal static bool MatchComplexSegment(RoutePatternPathSegment routeSegment, ReadOnlySpan<char> requestSegment, RouteValueDictionary values)
		{
			throw null;
		}
	}
}
