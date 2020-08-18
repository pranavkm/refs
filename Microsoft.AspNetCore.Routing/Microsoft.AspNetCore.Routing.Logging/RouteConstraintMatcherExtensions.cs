using Microsoft.Extensions.Logging;

namespace Microsoft.AspNetCore.Routing.Logging
{
	internal static class RouteConstraintMatcherExtensions
	{
		public static void ConstraintNotMatched(this ILogger logger, object routeValue, string routeKey, IRouteConstraint routeConstraint)
		{
			throw null;
		}
	}
}
