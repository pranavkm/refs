using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Diagnostics
{
	public class ExceptionHandlerMiddleware
	{
		public ExceptionHandlerMiddleware(RequestDelegate next, ILoggerFactory loggerFactory, IOptions<ExceptionHandlerOptions> options, DiagnosticListener diagnosticListener)
		{
			throw null;
		}

		public Task Invoke(HttpContext context)
		{
			throw null;
		}
	}
}
