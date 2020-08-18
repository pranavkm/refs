using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Defines a contract for a handler of a route. 
	/// </summary>
	public interface IRouteHandler
	{
		/// <summary>
		/// Gets a <see cref="T:Microsoft.AspNetCore.Http.RequestDelegate" /> to handle the request, based on the provided
		/// <paramref name="routeData" />.
		/// </summary>
		/// <param name="httpContext">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> associated with the current request.</param>
		/// <param name="routeData">The <see cref="T:Microsoft.AspNetCore.Routing.RouteData" /> associated with the current routing match.</param>
		/// <returns>
		/// A <see cref="T:Microsoft.AspNetCore.Http.RequestDelegate" />, or <c>null</c> if the handler cannot handle this request.
		/// </returns>
		RequestDelegate GetRequestHandler(HttpContext httpContext, RouteData routeData);
	}
}
