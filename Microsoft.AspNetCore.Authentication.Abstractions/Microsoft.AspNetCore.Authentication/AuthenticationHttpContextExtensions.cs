using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Extension methods to expose Authentication on HttpContext.
	/// </summary>
	public static class AuthenticationHttpContextExtensions
	{
		/// <summary>
		/// Extension method for authenticate using the <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationOptions.DefaultAuthenticateScheme" /> scheme.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> context.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticateResult" />.</returns>
		public static Task<AuthenticateResult> AuthenticateAsync(this HttpContext context)
		{
			throw null;
		}

		/// <summary>
		/// Extension method for authenticate.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> context.</param>
		/// <param name="scheme">The name of the authentication scheme.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticateResult" />.</returns>
		public static Task<AuthenticateResult> AuthenticateAsync(this HttpContext context, string? scheme)
		{
			throw null;
		}

		/// <summary>
		/// Extension method for Challenge.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> context.</param>
		/// <param name="scheme">The name of the authentication scheme.</param>
		/// <returns>The result.</returns>
		public static Task ChallengeAsync(this HttpContext context, string? scheme)
		{
			throw null;
		}

		/// <summary>
		/// Extension method for authenticate using the <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationOptions.DefaultChallengeScheme" /> scheme.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> context.</param>
		/// <returns>The task.</returns>
		public static Task ChallengeAsync(this HttpContext context)
		{
			throw null;
		}

		/// <summary>
		/// Extension method for authenticate using the <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationOptions.DefaultChallengeScheme" /> scheme.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> context.</param>
		/// <param name="properties">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" /> properties.</param>
		/// <returns>The task.</returns>
		public static Task ChallengeAsync(this HttpContext context, AuthenticationProperties? properties)
		{
			throw null;
		}

		/// <summary>
		/// Extension method for Challenge.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> context.</param>
		/// <param name="scheme">The name of the authentication scheme.</param>
		/// <param name="properties">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" /> properties.</param>
		/// <returns>The task.</returns>
		public static Task ChallengeAsync(this HttpContext context, string? scheme, AuthenticationProperties? properties)
		{
			throw null;
		}

		/// <summary>
		/// Extension method for Forbid.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> context.</param>
		/// <param name="scheme">The name of the authentication scheme.</param>
		/// <returns>The task.</returns>
		public static Task ForbidAsync(this HttpContext context, string? scheme)
		{
			throw null;
		}

		/// <summary>
		/// Extension method for Forbid using the <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationOptions.DefaultForbidScheme" /> scheme..
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> context.</param>
		/// <returns>The task.</returns>
		public static Task ForbidAsync(this HttpContext context)
		{
			throw null;
		}

		/// <summary>
		/// Extension method for Forbid.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> context.</param>
		/// <param name="properties">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" /> properties.</param>
		/// <returns>The task.</returns>
		public static Task ForbidAsync(this HttpContext context, AuthenticationProperties? properties)
		{
			throw null;
		}

		/// <summary>
		/// Extension method for Forbid.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> context.</param>
		/// <param name="scheme">The name of the authentication scheme.</param>
		/// <param name="properties">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" /> properties.</param>
		/// <returns>The task.</returns>
		public static Task ForbidAsync(this HttpContext context, string? scheme, AuthenticationProperties? properties)
		{
			throw null;
		}

		/// <summary>
		/// Extension method for SignIn.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> context.</param>
		/// <param name="scheme">The name of the authentication scheme.</param>
		/// <param name="principal">The user.</param>
		/// <returns>The task.</returns>
		public static Task SignInAsync(this HttpContext context, string? scheme, ClaimsPrincipal principal)
		{
			throw null;
		}

		/// <summary>
		/// Extension method for SignIn using the <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationOptions.DefaultSignInScheme" />.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> context.</param>
		/// <param name="principal">The user.</param>
		/// <returns>The task.</returns>
		public static Task SignInAsync(this HttpContext context, ClaimsPrincipal principal)
		{
			throw null;
		}

		/// <summary>
		/// Extension method for SignIn using the <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationOptions.DefaultSignInScheme" />.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> context.</param>
		/// <param name="principal">The user.</param>
		/// <param name="properties">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" /> properties.</param>
		/// <returns>The task.</returns>
		public static Task SignInAsync(this HttpContext context, ClaimsPrincipal principal, AuthenticationProperties? properties)
		{
			throw null;
		}

		/// <summary>
		/// Extension method for SignIn.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> context.</param>
		/// <param name="scheme">The name of the authentication scheme.</param>
		/// <param name="principal">The user.</param>
		/// <param name="properties">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" /> properties.</param>
		/// <returns>The task.</returns>
		public static Task SignInAsync(this HttpContext context, string? scheme, ClaimsPrincipal principal, AuthenticationProperties? properties)
		{
			throw null;
		}

		/// <summary>
		/// Extension method for SignOut using the <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationOptions.DefaultSignOutScheme" />.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> context.</param>
		/// <returns>The task.</returns>
		public static Task SignOutAsync(this HttpContext context)
		{
			throw null;
		}

		/// <summary>
		/// Extension method for SignOut using the <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationOptions.DefaultSignOutScheme" />.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> context.</param>
		/// <param name="properties">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" /> properties.</param>
		/// <returns>The task.</returns>
		public static Task SignOutAsync(this HttpContext context, AuthenticationProperties? properties)
		{
			throw null;
		}

		/// <summary>
		/// Extension method for SignOut.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> context.</param>
		/// <param name="scheme">The name of the authentication scheme.</param>
		/// <returns>The task.</returns>
		public static Task SignOutAsync(this HttpContext context, string? scheme)
		{
			throw null;
		}

		/// <summary>
		/// Extension method for SignOut.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> context.</param>
		/// <param name="scheme">The name of the authentication scheme.</param>
		/// <param name="properties">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" /> properties.</param>
		/// <returns>The task.</returns>
		public static Task SignOutAsync(this HttpContext context, string? scheme, AuthenticationProperties? properties)
		{
			throw null;
		}

		/// <summary>
		/// Extension method for getting the value of an authentication token.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> context.</param>
		/// <param name="scheme">The name of the authentication scheme.</param>
		/// <param name="tokenName">The name of the token.</param>
		/// <returns>The value of the token.</returns>
		public static Task<string?> GetTokenAsync(this HttpContext context, string? scheme, string tokenName)
		{
			throw null;
		}

		/// <summary>
		/// Extension method for getting the value of an authentication token.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> context.</param>
		/// <param name="tokenName">The name of the token.</param>
		/// <returns>The value of the token.</returns>
		public static Task<string?> GetTokenAsync(this HttpContext context, string tokenName)
		{
			throw null;
		}
	}
}
