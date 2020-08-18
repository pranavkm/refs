using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Constraints
{
	/// <summary>
	/// Constrains a route parameter to be a string with a maximum length.
	/// </summary>
	public class MaxLengthRouteConstraint : IRouteConstraint, IParameterPolicy
	{
		/// <summary>
		/// Gets the maximum length allowed for the route parameter.
		/// </summary>
		public int MaxLength
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Routing.Constraints.MaxLengthRouteConstraint" /> class.
		/// </summary>
		/// <param name="maxLength">The maximum length allowed for the route parameter.</param>
		public MaxLengthRouteConstraint(int maxLength)
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
