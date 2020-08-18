using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Constraints
{
	/// <summary>
	/// Constrains a route parameter to be an integer with a maximum value.
	/// </summary>
	public class MaxRouteConstraint : IRouteConstraint, IParameterPolicy
	{
		/// <summary>
		/// Gets the maximum allowed value of the route parameter.
		/// </summary>
		public long Max
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Routing.Constraints.MaxRouteConstraint" /> class.
		/// </summary>
		/// <param name="max">The maximum value allowed for the route parameter.</param>
		public MaxRouteConstraint(long max)
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
