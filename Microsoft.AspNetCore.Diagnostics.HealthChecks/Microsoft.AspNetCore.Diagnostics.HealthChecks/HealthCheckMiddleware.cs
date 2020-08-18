using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Diagnostics.HealthChecks
{
	public class HealthCheckMiddleware
	{
		public HealthCheckMiddleware(RequestDelegate next, IOptions<HealthCheckOptions> healthCheckOptions, HealthCheckService healthCheckService)
		{
			throw null;
		}

		/// <summary>
		/// Processes a request.
		/// </summary>
		/// <param name="httpContext"></param>
		/// <returns></returns>
		[AsyncStateMachine(typeof(_003CInvokeAsync_003Ed__4))]
		[DebuggerStepThrough]
		public Task InvokeAsync(HttpContext httpContext)
		{
			throw null;
		}
	}
}
