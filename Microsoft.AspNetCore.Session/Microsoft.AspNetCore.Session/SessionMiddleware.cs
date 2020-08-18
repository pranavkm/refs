using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Session
{
	/// <summary>
	/// Enables the session state for the application.
	/// </summary>
	public class SessionMiddleware
	{
		private class SessionEstablisher
		{
			public SessionEstablisher(HttpContext context, string cookieValue, SessionOptions options)
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Session.SessionMiddleware" />.
		/// </summary>
		/// <param name="next">The <see cref="T:Microsoft.AspNetCore.Http.RequestDelegate" /> representing the next middleware in the pipeline.</param>
		/// <param name="loggerFactory">The <see cref="T:Microsoft.Extensions.Logging.ILoggerFactory" /> representing the factory that used to create logger instances.</param>
		/// <param name="dataProtectionProvider">The <see cref="T:Microsoft.AspNetCore.DataProtection.IDataProtectionProvider" /> used to protect and verify the cookie.</param>
		/// <param name="sessionStore">The <see cref="T:Microsoft.AspNetCore.Session.ISessionStore" /> representing the session store.</param>
		/// <param name="options">The session configuration options.</param>
		public SessionMiddleware(RequestDelegate next, ILoggerFactory loggerFactory, IDataProtectionProvider dataProtectionProvider, ISessionStore sessionStore, IOptions<SessionOptions> options)
		{
			throw null;
		}

		/// <summary>
		/// Invokes the logic of the middleware.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that completes when the middleware has completed processing.</returns>
		[AsyncStateMachine(typeof(_003CInvoke_003Ed__8))]
		[DebuggerStepThrough]
		public Task Invoke(HttpContext context)
		{
			throw null;
		}
	}
}
