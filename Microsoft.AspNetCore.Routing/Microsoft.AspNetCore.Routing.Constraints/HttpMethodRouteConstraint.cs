using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Constraints
{
	/// <summary>
	/// Constrains the HTTP method of request or a route.
	/// </summary>
	public class HttpMethodRouteConstraint : IRouteConstraint, IParameterPolicy
	{
		/// <summary>
		/// Gets the HTTP methods allowed by the constraint.
		/// </summary>
		public IList<string> AllowedMethods
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Routing.Constraints.HttpMethodRouteConstraint" /> that accepts the HTTP methods specified
		/// by <paramref name="allowedMethods" />.
		/// </summary>
		/// <param name="allowedMethods">The allowed HTTP methods.</param>
		public HttpMethodRouteConstraint(params string[] allowedMethods)
		{
			throw null;
		}

		/// <inheritdoc />
		public virtual bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
		{
			throw null;
		}
	}
}
