using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// PolicySchemes are used to redirect authentication methods to another scheme.
	/// </summary>
	public class PolicySchemeHandler : SignInAuthenticationHandler<PolicySchemeOptions>
	{
		public PolicySchemeHandler(IOptionsMonitor<PolicySchemeOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock)
		{
			throw null;
		}

		protected override Task HandleChallengeAsync(AuthenticationProperties? properties)
		{
			throw null;
		}

		protected override Task HandleForbiddenAsync(AuthenticationProperties? properties)
		{
			throw null;
		}

		protected override Task HandleSignInAsync(ClaimsPrincipal user, AuthenticationProperties? properties)
		{
			throw null;
		}

		protected override Task HandleSignOutAsync(AuthenticationProperties? properties)
		{
			throw null;
		}

		protected override Task<AuthenticateResult> HandleAuthenticateAsync()
		{
			throw null;
		}
	}
}
