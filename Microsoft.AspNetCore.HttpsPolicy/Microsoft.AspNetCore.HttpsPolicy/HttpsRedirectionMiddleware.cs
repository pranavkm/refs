using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.HttpsPolicy
{
	/// <summary>
	/// Middleware that redirects non-HTTPS requests to an HTTPS URL.
	/// </summary>
	public class HttpsRedirectionMiddleware
	{
		/// <summary>
		/// Initializes <see cref="T:Microsoft.AspNetCore.HttpsPolicy.HttpsRedirectionMiddleware" />.
		/// </summary>
		/// <param name="next"></param>
		/// <param name="options"></param>
		/// <param name="config"></param>
		/// <param name="loggerFactory"></param>
		public HttpsRedirectionMiddleware(RequestDelegate next, IOptions<HttpsRedirectionOptions> options, IConfiguration config, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		/// <summary>
		/// Initializes <see cref="T:Microsoft.AspNetCore.HttpsPolicy.HttpsRedirectionMiddleware" />.
		/// </summary>
		/// <param name="next"></param>
		/// <param name="options"></param>
		/// <param name="config"></param>
		/// <param name="loggerFactory"></param>
		/// <param name="serverAddressesFeature"></param>
		public HttpsRedirectionMiddleware(RequestDelegate next, IOptions<HttpsRedirectionOptions> options, IConfiguration config, ILoggerFactory loggerFactory, IServerAddressesFeature serverAddressesFeature)
		{
			throw null;
		}

		/// <summary>
		/// Invokes the HttpsRedirectionMiddleware.
		/// </summary>
		/// <param name="context"></param>
		/// <returns></returns>
		public Task Invoke(HttpContext context)
		{
			throw null;
		}
	}
}
