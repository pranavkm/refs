using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Extension methods for <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> related to routing.
	/// </summary>
	public static class RoutingHttpContextExtensions
	{
		/// <summary>
		/// Gets the <see cref="T:Microsoft.AspNetCore.Routing.RouteData" /> associated with the provided <paramref name="httpContext" />.
		/// </summary>
		/// <param name="httpContext">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> associated with the current request.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.RouteData" />, or null.</returns>
		public static RouteData GetRouteData(this HttpContext httpContext)
		{
			throw null;
		}

		/// <summary>
		/// Gets a route value from <see cref="P:Microsoft.AspNetCore.Routing.RouteData.Values" /> associated with the provided
		/// <paramref name="httpContext" />.
		/// </summary>
		/// <param name="httpContext">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> associated with the current request.</param>
		/// <param name="key">The key of the route value.</param>
		/// <returns>The corresponding route value, or null.</returns>
		public static object? GetRouteValue(this HttpContext httpContext, string key)
		{
			throw null;
		}
	}
}
