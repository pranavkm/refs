using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Routing.Constraints
{
	/// <summary>
	/// Constrains a route parameter to represent only <see cref="T:System.DateTime" /> values.
	/// </summary>
	/// <remarks>
	/// This constraint tries to parse strings by using all of the formats returned by the
	/// CultureInfo.InvariantCulture.DateTimeFormat.GetAllDateTimePatterns() method.
	/// For a sample on how to list all formats which are considered, please visit
	/// http://msdn.microsoft.com/en-us/library/aszyst2c(v=vs.110).aspx
	/// </remarks>
	public class DateTimeRouteConstraint : IRouteConstraint, IParameterPolicy
	{
		/// <inheritdoc />
		public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
		{
			throw null;
		}

		public DateTimeRouteConstraint()
		{
			throw null;
		}
	}
}
