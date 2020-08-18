using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Constraints
{
	/// <summary>
	/// Constrains a route parameter to contain only a specified string.
	/// </summary>
	public class StringRouteConstraint : IRouteConstraint, IParameterPolicy
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Routing.Constraints.StringRouteConstraint" /> class.
		/// </summary>
		/// <param name="value">The constraint value to match.</param>
		[System.Runtime.CompilerServices.NullableContext(1)]
		public StringRouteConstraint(string value)
		{
			throw null;
		}

		/// <inheritdoc />
		public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
		{
			throw null;
		}
	}
}
