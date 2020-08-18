using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Adds support for SignInAsync
	/// </summary>
	public abstract class SignInAuthenticationHandler<TOptions> : SignOutAuthenticationHandler<TOptions>, IAuthenticationSignInHandler, IAuthenticationSignOutHandler, IAuthenticationHandler where TOptions : AuthenticationSchemeOptions, new()
	{
		[System.Runtime.CompilerServices.NullableContext(1)]
		public SignInAuthenticationHandler(IOptionsMonitor<TOptions> options, ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock)
		{
			throw null;
		}

		public virtual Task SignInAsync(ClaimsPrincipal user, AuthenticationProperties? properties)
		{
			throw null;
		}

		/// <summary>
		/// Override this method to handle SignIn.
		/// </summary>
		/// <param name="user"></param>
		/// <param name="properties"></param>
		/// <returns>A Task.</returns>
		protected abstract Task HandleSignInAsync(ClaimsPrincipal user, AuthenticationProperties? properties);
	}
}
