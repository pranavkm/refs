using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Diagnostics.HealthChecks
{
	internal static class HealthCheckResponseWriters
	{
		public static Task WriteMinimalPlaintext(HttpContext httpContext, HealthReport result)
		{
			throw null;
		}
	}
}
