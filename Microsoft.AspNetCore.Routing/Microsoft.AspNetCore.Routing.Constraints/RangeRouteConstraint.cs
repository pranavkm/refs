using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Constraints
{
	/// <summary>
	/// Constraints a route parameter to be an integer within a given range of values.
	/// </summary>
	public class RangeRouteConstraint : IRouteConstraint, IParameterPolicy
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
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Routing.Constraints.RangeRouteConstraint" /> class.
		/// </summary>
		/// <param name="min">The minimum value.</param>
		/// <param name="max">The maximum value.</param>
		/// <remarks>The minimum value should be less than or equal to the maximum value.</remarks>
		public RangeRouteConstraint(long min, long max)
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
