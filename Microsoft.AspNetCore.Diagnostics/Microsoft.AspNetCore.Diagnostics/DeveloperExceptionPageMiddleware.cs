using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Diagnostics
{
	/// <summary>
	/// Captures synchronous and asynchronous exceptions from the pipeline and generates error responses.
	/// </summary>
	public class DeveloperExceptionPageMiddleware
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Diagnostics.DeveloperExceptionPageMiddleware" /> class
		/// </summary>
		/// <param name="next"></param>
		/// <param name="options"></param>
		/// <param name="loggerFactory"></param>
		/// <param name="hostingEnvironment"></param>
		/// <param name="diagnosticSource"></param>
		/// <param name="filters"></param>
		public DeveloperExceptionPageMiddleware(RequestDelegate next, IOptions<DeveloperExceptionPageOptions> options, ILoggerFactory loggerFactory, IWebHostEnvironment hostingEnvironment, DiagnosticSource diagnosticSource, IEnumerable<IDeveloperPageExceptionFilter> filters)
		{
			throw null;
		}

		/// <summary>
		/// Process an individual request.
		/// </summary>
		/// <param name="context"></param>
		/// <returns></returns>
		[AsyncStateMachine(typeof(_003CInvoke_003Ed__9))]
		[DebuggerStepThrough]
		public Task Invoke(HttpContext context)
		{
			throw null;
		}
	}
}
