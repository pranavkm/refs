using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.StaticFiles
{
	/// <summary>
	/// Enables serving static files for a given request path
	/// </summary>
	public class StaticFileMiddleware
	{
		/// <summary>
		/// Creates a new instance of the StaticFileMiddleware.
		/// </summary>
		/// <param name="next">The next middleware in the pipeline.</param>
		/// <param name="hostingEnv">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostEnvironment" /> used by this middleware.</param>
		/// <param name="options">The configuration options.</param>
		/// <param name="loggerFactory">An <see cref="T:Microsoft.Extensions.Logging.ILoggerFactory" /> instance used to create loggers.</param>
		public StaticFileMiddleware(RequestDelegate next, IWebHostEnvironment hostingEnv, IOptions<StaticFileOptions> options, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		/// <summary>
		/// Processes a request to determine if it matches a known file, and if so, serves it.
		/// </summary>
		/// <param name="context"></param>
		/// <returns></returns>
		public Task Invoke(HttpContext context)
		{
			throw null;
		}

		internal static bool ValidatePath(HttpContext context, PathString matchUrl, out PathString subPath)
		{
			throw null;
		}

		internal static bool LookupContentType(IContentTypeProvider contentTypeProvider, StaticFileOptions options, PathString subPath, out string contentType)
		{
			throw null;
		}
	}
}
