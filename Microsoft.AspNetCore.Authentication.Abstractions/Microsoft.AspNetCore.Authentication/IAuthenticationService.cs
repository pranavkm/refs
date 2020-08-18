using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Used to provide authentication.
	/// </summary>
	public interface IAuthenticationService
	{
		/// <summary>
		/// Authenticate for the specified authentication scheme.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />.</param>
		/// <param name="scheme">The name of the authentication scheme.</param>
		/// <returns>The result.</returns>
		Task<AuthenticateResult> AuthenticateAsync(HttpContext context, string? scheme);

		/// <summary>
		/// Challenge the specified authentication scheme.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />.</param>
		/// <param name="scheme">The name of the authentication scheme.</param>
		/// <param name="properties">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" />.</param>
		/// <returns>A task.</returns>
		Task ChallengeAsync(HttpContext context, string? scheme, AuthenticationProperties? properties);

		/// <summary>
		/// Forbids the specified authentication scheme.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />.</param>
		/// <param name="scheme">The name of the authentication scheme.</param>
		/// <param name="properties">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" />.</param>
		/// <returns>A task.</returns>
		Task ForbidAsync(HttpContext context, string? scheme, AuthenticationProperties? properties);

		/// <summary>
		/// Sign a principal in for the specified authentication scheme.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />.</param>
		/// <param name="scheme">The name of the authentication scheme.</param>
		/// <param name="principal">The <see cref="T:System.Security.Claims.ClaimsPrincipal" /> to sign in.</param>
		/// <param name="properties">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" />.</param>
		/// <returns>A task.</returns>
		Task SignInAsync(HttpContext context, string? scheme, ClaimsPrincipal principal, AuthenticationProperties? properties);

		/// <summary>
		/// Sign out the specified authentication scheme.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />.</param>
		/// <param name="scheme">The name of the authentication scheme.</param>
		/// <param name="properties">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" />.</param>
		/// <returns>A task.</returns>
		Task SignOutAsync(HttpContext context, string? scheme, AuthenticationProperties? properties);
	}
}
