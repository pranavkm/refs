using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Routing.Constraints
{
	/// <summary>
	/// Constrains a route parameter to represent only <see cref="T:System.Guid" /> values.
	/// Matches values specified in any of the five formats "N", "D", "B", "P", or "X",
	/// supported by Guid.ToString(string) and Guid.ToString(String, IFormatProvider) methods.
	/// </summary>
	public class GuidRouteConstraint : IRouteConstraint, IParameterPolicy
	{
		/// <inheritdoc />
		public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
		{
			throw null;
		}

		public GuidRouteConstraint()
		{
			throw null;
		}
	}
}
