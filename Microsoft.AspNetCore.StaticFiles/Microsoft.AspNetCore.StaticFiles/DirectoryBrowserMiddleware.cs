using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.StaticFiles
{
	/// <summary>
	/// Enables directory browsing
	/// </summary>
	public class DirectoryBrowserMiddleware
	{
		/// <summary>
		/// Creates a new instance of the SendFileMiddleware. Using <see cref="P:System.Text.Encodings.Web.HtmlEncoder.Default" /> instance.
		/// </summary>
		/// <param name="next">The next middleware in the pipeline.</param>
		/// <param name="hostingEnv">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostEnvironment" /> used by this middleware.</param>
		/// <param name="options">The configuration for this middleware.</param>
		public DirectoryBrowserMiddleware(RequestDelegate next, IWebHostEnvironment hostingEnv, IOptions<DirectoryBrowserOptions> options)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new instance of the SendFileMiddleware.
		/// </summary>
		/// <param name="next">The next middleware in the pipeline.</param>
		/// <param name="hostingEnv">The <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostEnvironment" /> used by this middleware.</param>
		/// <param name="encoder">The <see cref="T:System.Text.Encodings.Web.HtmlEncoder" /> used by the default <see cref="T:Microsoft.AspNetCore.StaticFiles.HtmlDirectoryFormatter" />.</param>
		/// <param name="options">The configuration for this middleware.</param>
		public DirectoryBrowserMiddleware(RequestDelegate next, IWebHostEnvironment hostingEnv, HtmlEncoder encoder, IOptions<DirectoryBrowserOptions> options)
		{
			throw null;
		}

		/// <summary>
		/// Examines the request to see if it matches a configured directory.  If so, a view of the directory contents is returned.
		/// </summary>
		/// <param name="context"></param>
		/// <returns></returns>
		public Task Invoke(HttpContext context)
		{
			throw null;
		}
	}
}
