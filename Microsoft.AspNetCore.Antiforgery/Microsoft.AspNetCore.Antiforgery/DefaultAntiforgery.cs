using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Antiforgery
{
	/// <summary>
	/// Provides access to the antiforgery system, which provides protection against
	/// Cross-site Request Forgery (XSRF, also called CSRF) attacks.
	/// </summary>
	internal class DefaultAntiforgery : IAntiforgery
	{
		public DefaultAntiforgery(IOptions<AntiforgeryOptions> antiforgeryOptionsAccessor, IAntiforgeryTokenGenerator tokenGenerator, IAntiforgeryTokenSerializer tokenSerializer, IAntiforgeryTokenStore tokenStore, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		/// <inheritdoc />
		public AntiforgeryTokenSet GetAndStoreTokens(HttpContext httpContext)
		{
			throw null;
		}

		/// <inheritdoc />
		public AntiforgeryTokenSet GetTokens(HttpContext httpContext)
		{
			throw null;
		}

		/// <inheritdoc />
		[AsyncStateMachine(typeof(_003CIsRequestValidAsync_003Ed__8))]
		[DebuggerStepThrough]
		public Task<bool> IsRequestValidAsync(HttpContext httpContext)
		{
			throw null;
		}

		/// <inheritdoc />
		[AsyncStateMachine(typeof(_003CValidateRequestAsync_003Ed__9))]
		[DebuggerStepThrough]
		public Task ValidateRequestAsync(HttpContext httpContext)
		{
			throw null;
		}

		/// <inheritdoc />
		public void SetCookieTokenAndHeader(HttpContext httpContext)
		{
			throw null;
		}

		/// <summary>
		/// Sets the 'Cache-Control' header to 'no-cache, no-store' and 'Pragma' header to 'no-cache' overriding any user set value.
		/// </summary>
		/// <param name="httpContext">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />.</param>
		protected virtual void SetDoNotCacheHeaders(HttpContext httpContext)
		{
			throw null;
		}
	}
}
