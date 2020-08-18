using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Matching;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Routing
{
	internal sealed class EndpointRoutingMiddleware
	{
		private static class Log
		{
			public static void MatchSuccess(ILogger logger, Endpoint endpoint)
			{
				throw null;
			}

			public static void MatchFailure(ILogger logger)
			{
				throw null;
			}

			public static void MatchSkipped(ILogger logger, Endpoint endpoint)
			{
				throw null;
			}
		}

		public EndpointRoutingMiddleware(MatcherFactory matcherFactory, ILogger<EndpointRoutingMiddleware> logger, IEndpointRouteBuilder endpointRouteBuilder, DiagnosticListener diagnosticListener, RequestDelegate next)
		{
			throw null;
		}

		public Task Invoke(HttpContext httpContext)
		{
			throw null;
		}
	}
}
