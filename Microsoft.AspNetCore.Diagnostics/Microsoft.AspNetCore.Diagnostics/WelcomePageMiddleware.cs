using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Diagnostics
{
	/// <summary>
	/// This middleware provides a default web page for new applications.
	/// </summary>
	public class WelcomePageMiddleware
	{
		/// <summary>
		/// Creates a default web page for new applications.
		/// </summary>
		/// <param name="next"></param>
		/// <param name="options"></param>
		public WelcomePageMiddleware(RequestDelegate next, IOptions<WelcomePageOptions> options)
		{
			throw null;
		}

		/// <summary>
		/// Process an individual request.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />.</param>
		/// <returns></returns>
		public Task Invoke(HttpContext context)
		{
			throw null;
		}
	}
}
