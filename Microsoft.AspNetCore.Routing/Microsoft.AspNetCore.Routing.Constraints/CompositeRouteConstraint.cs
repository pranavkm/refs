using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Constraints
{
	/// <summary>
	/// Constrains a route by several child constraints.
	/// </summary>
	public class CompositeRouteConstraint : IRouteConstraint, IParameterPolicy
	{
		/// <summary>
		/// Gets the child constraints that must match for this constraint to match.
		/// </summary>
		public IEnumerable<IRouteConstraint> Constraints
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Routing.Constraints.CompositeRouteConstraint" /> class.
		/// </summary>
		/// <param name="constraints">The child constraints that must match for this constraint to match.</param>
		public CompositeRouteConstraint(IEnumerable<IRouteConstraint> constraints)
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
