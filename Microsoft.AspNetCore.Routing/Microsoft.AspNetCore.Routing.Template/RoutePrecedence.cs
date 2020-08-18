using Microsoft.AspNetCore.Routing.Patterns;

namespace Microsoft.AspNetCore.Routing.Template
{
	/// <summary>
	/// Computes precedence for a route template.
	/// </summary>
	public static class RoutePrecedence
	{
		public static decimal ComputeInbound(RouteTemplate template)
		{
			throw null;
		}

		internal static decimal ComputeInbound(RoutePattern routePattern)
		{
			throw null;
		}

		public static decimal ComputeOutbound(RouteTemplate template)
		{
			throw null;
		}

		internal static decimal ComputeOutbound(RoutePattern routePattern)
		{
			throw null;
		}

		internal static int ComputeInboundPrecedenceDigit(RoutePattern routePattern, RoutePatternPathSegment pathSegment)
		{
			throw null;
		}
	}
}
