using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Routing.Constraints
{
	internal class NullRouteConstraint : IRouteConstraint, IParameterPolicy
	{
		public static readonly NullRouteConstraint Instance;

		public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
		{
			throw null;
		}
	}
}
