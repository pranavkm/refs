using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Constraints
{
	/// <summary>
	/// Constrains a route parameter to be a string of a given length or within a given range of lengths.
	/// </summary>
	public class LengthRouteConstraint : IRouteConstraint, IParameterPolicy
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
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Routing.Constraints.LengthRouteConstraint" /> class that constrains
		/// a route parameter to be a string of a given length.
		/// </summary>
		/// <param name="length">The length of the route parameter.</param>
		public LengthRouteConstraint(int length)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Routing.Constraints.LengthRouteConstraint" /> class that constrains
		/// a route parameter to be a string of a given length.
		/// </summary>
		/// <param name="minLength">The minimum length allowed for the route parameter.</param>
		/// <param name="maxLength">The maximum length allowed for the route parameter.</param>
		public LengthRouteConstraint(int minLength, int maxLength)
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
