using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Routing
{
	public static class RouteConstraintMatcher
	{
		public static bool Match(IDictionary<string, IRouteConstraint> constraints, RouteValueDictionary routeValues, HttpContext httpContext, IRouter route, RouteDirection routeDirection, ILogger logger)
		{
			throw null;
		}
	}
}
