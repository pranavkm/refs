using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Routing
{
	public class RouteHandler : IRouteHandler, IRouter
	{
		public RouteHandler(RequestDelegate requestDelegate)
		{
			throw null;
		}

		public RequestDelegate GetRequestHandler(HttpContext httpContext, RouteData routeData)
		{
			throw null;
		}

		public VirtualPathData? GetVirtualPath(VirtualPathContext context)
		{
			throw null;
		}

		public Task RouteAsync(RouteContext context)
		{
			throw null;
		}
	}
}
