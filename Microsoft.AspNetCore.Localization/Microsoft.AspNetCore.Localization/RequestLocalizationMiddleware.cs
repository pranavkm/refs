using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Localization
{
	/// <summary>
	/// Enables automatic setting of the culture for <see cref="T:Microsoft.AspNetCore.Http.HttpRequest" />s based on information
	/// sent by the client in headers and logic provided by the application.
	/// </summary>
	public class RequestLocalizationMiddleware
	{
		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Localization.RequestLocalizationMiddleware" />.
		/// </summary>
		/// <param name="next">The <see cref="T:Microsoft.AspNetCore.Http.RequestDelegate" /> representing the next middleware in the pipeline.</param>
		/// <param name="options">The <see cref="T:Microsoft.AspNetCore.Builder.RequestLocalizationOptions" /> representing the options for the
		/// <param name="loggerFactory">The <see cref="T:Microsoft.Extensions.Logging.ILoggerFactory" /> used for logging.</param>
		/// <see cref="T:Microsoft.AspNetCore.Localization.RequestLocalizationMiddleware" />.</param>
		public RequestLocalizationMiddleware(RequestDelegate next, IOptions<RequestLocalizationOptions> options, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		/// <summary>
		/// Invokes the logic of the middleware.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that completes when the middleware has completed processing.</returns>
		[AsyncStateMachine(typeof(_003CInvoke_003Ed__5))]
		[DebuggerStepThrough]
		public Task Invoke(HttpContext context)
		{
			throw null;
		}
	}
}
