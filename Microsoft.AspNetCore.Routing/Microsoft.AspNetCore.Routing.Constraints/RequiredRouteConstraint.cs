using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Routing.Constraints
{
	/// <summary>
	/// Constraints a route parameter that must have a value.
	/// </summary>
	/// <remarks>
	/// This constraint is primarily used to enforce that a non-parameter value is present during
	/// URL generation.
	/// </remarks>
	public class RequiredRouteConstraint : IRouteConstraint, IParameterPolicy
	{
		/// <inheritdoc />
		public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
		{
			throw null;
		}

		public RequiredRouteConstraint()
		{
			throw null;
		}
	}
}
