using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Constraints
{
	/// <summary>
	/// Constrains a route parameter to be a string with a minimum length.
	/// </summary>
	public class MinLengthRouteConstraint : IRouteConstraint, IParameterPolicy
	{
		/// <summary>
		/// Gets the minimum length allowed for the route parameter.
		/// </summary>
		public int MinLength
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Routing.Constraints.MinLengthRouteConstraint" /> class.
		/// </summary>
		/// <param name="minLength">The minimum length allowed for the route parameter.</param>
		public MinLengthRouteConstraint(int minLength)
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
