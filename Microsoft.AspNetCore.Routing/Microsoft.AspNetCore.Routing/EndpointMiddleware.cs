using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Routing
{
	internal sealed class EndpointMiddleware
	{
		private static class Log
		{
			public static void ExecutingEndpoint(ILogger logger, Endpoint endpoint)
			{
				throw null;
			}

			public static void ExecutedEndpoint(ILogger logger, Endpoint endpoint)
			{
				throw null;
			}
		}

		internal const string AuthorizationMiddlewareInvokedKey = "__AuthorizationMiddlewareWithEndpointInvoked";

		internal const string CorsMiddlewareInvokedKey = "__CorsMiddlewareWithEndpointInvoked";

		public EndpointMiddleware(ILogger<EndpointMiddleware> logger, RequestDelegate next, IOptions<RouteOptions> routeOptions)
		{
			throw null;
		}

		public Task Invoke(HttpContext httpContext)
		{
			throw null;
		}
	}
}
