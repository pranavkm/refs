using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.HttpsPolicy
{
	/// <summary>
	/// Enables HTTP Strict Transport Security (HSTS)
	/// See https://tools.ietf.org/html/rfc6797.
	/// </summary>
	public class HstsMiddleware
	{
		/// <summary>
		/// Initialize the HSTS middleware.
		/// </summary>
		/// <param name="next"></param>
		/// <param name="options"></param>
		/// <param name="loggerFactory"></param>
		public HstsMiddleware(RequestDelegate next, IOptions<HstsOptions> options, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		/// <summary>
		/// Initialize the HSTS middleware.
		/// </summary>
		/// <param name="next"></param>
		/// <param name="options"></param>
		public HstsMiddleware(RequestDelegate next, IOptions<HstsOptions> options)
		{
			throw null;
		}

		/// <summary>
		/// Invoke the middleware.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />.</param>
		/// <returns></returns>
		public Task Invoke(HttpContext context)
		{
			throw null;
		}
	}
}
