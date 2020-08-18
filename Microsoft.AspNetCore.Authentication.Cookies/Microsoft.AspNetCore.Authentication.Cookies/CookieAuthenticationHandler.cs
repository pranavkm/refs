using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authentication.Cookies
{
	public class CookieAuthenticationHandler : SignInAuthenticationHandler<CookieAuthenticationOptions>
	{
		/// <summary>
		/// The handler calls methods on the events which give the application control at certain points where processing is occurring.
		/// If it is not provided a default instance is supplied which does nothing when the methods are called.
		/// </summary>
		protected new CookieAuthenticationEvents Events
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public CookieAuthenticationHandler(IOptionsMonitor<CookieAuthenticationOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock)
		{
			throw null;
		}

		protected override Task InitializeHandlerAsync()
		{
			throw null;
		}

		/// <summary>
		/// Creates a new instance of the events instance.
		/// </summary>
		/// <returns>A new instance of the events instance.</returns>
		protected override Task<object> CreateEventsAsync()
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CHandleAuthenticateAsync_003Ed__23))]
		[DebuggerStepThrough]
		protected override Task<AuthenticateResult> HandleAuthenticateAsync()
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CFinishResponseAsync_003Ed__25))]
		[DebuggerStepThrough]
		protected virtual Task FinishResponseAsync()
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CHandleSignInAsync_003Ed__26))]
		[DebuggerStepThrough]
		protected override Task HandleSignInAsync(ClaimsPrincipal user, AuthenticationProperties? properties)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CHandleSignOutAsync_003Ed__27))]
		[DebuggerStepThrough]
		protected override Task HandleSignOutAsync(AuthenticationProperties? properties)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CHandleForbiddenAsync_003Ed__30))]
		[DebuggerStepThrough]
		protected override Task HandleForbiddenAsync(AuthenticationProperties properties)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CHandleChallengeAsync_003Ed__31))]
		[DebuggerStepThrough]
		protected override Task HandleChallengeAsync(AuthenticationProperties properties)
		{
			throw null;
		}
	}
}
