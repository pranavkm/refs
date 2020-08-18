using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Constraints
{
	/// <summary>
	/// Constrains a route parameter to be a long with a minimum value.
	/// </summary>
	public class MinRouteConstraint : IRouteConstraint, IParameterPolicy
	{
		/// <summary>
		/// Gets the minimum allowed value of the route parameter.
		/// </summary>
		public long Min
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Routing.Constraints.MinRouteConstraint" /> class.
		/// </summary>
		/// <param name="min">The minimum value allowed for the route parameter.</param>
		public MinRouteConstraint(long min)
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
