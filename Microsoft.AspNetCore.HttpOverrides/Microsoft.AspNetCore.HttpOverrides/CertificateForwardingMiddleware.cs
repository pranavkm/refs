using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.HttpOverrides
{
	/// <summary>
	/// Middleware that converts a forward header into a client certificate if found.
	/// </summary>
	public class CertificateForwardingMiddleware
	{
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="next"></param>
		/// <param name="loggerFactory"></param>
		/// <param name="options"></param>
		public CertificateForwardingMiddleware(RequestDelegate next, ILoggerFactory loggerFactory, IOptions<CertificateForwardingOptions> options)
		{
			throw null;
		}

		/// <summary>
		/// Looks for the presence of a <see cref="P:Microsoft.AspNetCore.HttpOverrides.CertificateForwardingOptions.CertificateHeader" /> header in the request,
		/// if found, converts this header to a ClientCertificate set on the connection.
		/// </summary>
		/// <param name="httpContext">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" />.</returns>
		public Task Invoke(HttpContext httpContext)
		{
			throw null;
		}
	}
}
