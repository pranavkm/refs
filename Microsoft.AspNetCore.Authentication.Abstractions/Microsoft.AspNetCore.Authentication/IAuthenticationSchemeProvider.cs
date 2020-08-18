using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Responsible for managing what authenticationSchemes are supported.
	/// </summary>
	public interface IAuthenticationSchemeProvider
	{
		/// <summary>
		/// Returns all currently registered <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationScheme" />s.
		/// </summary>
		/// <returns>All currently registered <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationScheme" />s.</returns>
		Task<IEnumerable<AuthenticationScheme>> GetAllSchemesAsync();

		/// <summary>
		/// Returns the <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationScheme" /> matching the name, or null.
		/// </summary>
		/// <param name="name">The name of the authenticationScheme.</param>
		/// <returns>The scheme or null if not found.</returns>
		Task<AuthenticationScheme?> GetSchemeAsync(string name);

		/// <summary>
		/// Returns the scheme that will be used by default for <see cref="M:Microsoft.AspNetCore.Authentication.IAuthenticationService.AuthenticateAsync(Microsoft.AspNetCore.Http.HttpContext,System.String)" />.
		/// This is typically specified via <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationOptions.DefaultAuthenticateScheme" />.
		/// Otherwise, this will fallback to <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationOptions.DefaultScheme" />.
		/// </summary>
		/// <returns>The scheme that will be used by default for <see cref="M:Microsoft.AspNetCore.Authentication.IAuthenticationService.AuthenticateAsync(Microsoft.AspNetCore.Http.HttpContext,System.String)" />.</returns>
		Task<AuthenticationScheme?> GetDefaultAuthenticateSchemeAsync();

		/// <summary>
		/// Returns the scheme that will be used by default for <see cref="M:Microsoft.AspNetCore.Authentication.IAuthenticationService.ChallengeAsync(Microsoft.AspNetCore.Http.HttpContext,System.String,Microsoft.AspNetCore.Authentication.AuthenticationProperties)" />.
		/// This is typically specified via <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationOptions.DefaultChallengeScheme" />.
		/// Otherwise, this will fallback to <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationOptions.DefaultScheme" />.
		/// </summary>
		/// <returns>The scheme that will be used by default for <see cref="M:Microsoft.AspNetCore.Authentication.IAuthenticationService.ChallengeAsync(Microsoft.AspNetCore.Http.HttpContext,System.String,Microsoft.AspNetCore.Authentication.AuthenticationProperties)" />.</returns>
		Task<AuthenticationScheme?> GetDefaultChallengeSchemeAsync();

		/// <summary>
		/// Returns the scheme that will be used by default for <see cref="M:Microsoft.AspNetCore.Authentication.IAuthenticationService.ForbidAsync(Microsoft.AspNetCore.Http.HttpContext,System.String,Microsoft.AspNetCore.Authentication.AuthenticationProperties)" />.
		/// This is typically specified via <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationOptions.DefaultForbidScheme" />.
		/// Otherwise, this will fallback to <see cref="M:Microsoft.AspNetCore.Authentication.IAuthenticationSchemeProvider.GetDefaultChallengeSchemeAsync" /> .
		/// </summary>
		/// <returns>The scheme that will be used by default for <see cref="M:Microsoft.AspNetCore.Authentication.IAuthenticationService.ForbidAsync(Microsoft.AspNetCore.Http.HttpContext,System.String,Microsoft.AspNetCore.Authentication.AuthenticationProperties)" />.</returns>
		Task<AuthenticationScheme?> GetDefaultForbidSchemeAsync();

		/// <summary>
		/// Returns the scheme that will be used by default for <see cref="M:Microsoft.AspNetCore.Authentication.IAuthenticationService.SignInAsync(Microsoft.AspNetCore.Http.HttpContext,System.String,System.Security.Claims.ClaimsPrincipal,Microsoft.AspNetCore.Authentication.AuthenticationProperties)" />.
		/// This is typically specified via <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationOptions.DefaultSignInScheme" />.
		/// Otherwise, this will fallback to <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationOptions.DefaultScheme" />.
		/// </summary>
		/// <returns>The scheme that will be used by default for <see cref="M:Microsoft.AspNetCore.Authentication.IAuthenticationService.SignInAsync(Microsoft.AspNetCore.Http.HttpContext,System.String,System.Security.Claims.ClaimsPrincipal,Microsoft.AspNetCore.Authentication.AuthenticationProperties)" />.</returns>
		Task<AuthenticationScheme?> GetDefaultSignInSchemeAsync();

		/// <summary>
		/// Returns the scheme that will be used by default for <see cref="M:Microsoft.AspNetCore.Authentication.IAuthenticationService.SignOutAsync(Microsoft.AspNetCore.Http.HttpContext,System.String,Microsoft.AspNetCore.Authentication.AuthenticationProperties)" />.
		/// This is typically specified via <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationOptions.DefaultSignOutScheme" />.
		/// Otherwise, this will fallback to <see cref="M:Microsoft.AspNetCore.Authentication.IAuthenticationSchemeProvider.GetDefaultSignInSchemeAsync" /> .
		/// </summary>
		/// <returns>The scheme that will be used by default for <see cref="M:Microsoft.AspNetCore.Authentication.IAuthenticationService.SignOutAsync(Microsoft.AspNetCore.Http.HttpContext,System.String,Microsoft.AspNetCore.Authentication.AuthenticationProperties)" />.</returns>
		Task<AuthenticationScheme?> GetDefaultSignOutSchemeAsync();

		/// <summary>
		/// Registers a scheme for use by <see cref="T:Microsoft.AspNetCore.Authentication.IAuthenticationService" />. 
		/// </summary>
		/// <param name="scheme">The scheme.</param>
		void AddScheme(AuthenticationScheme scheme);

		/// <summary>
		/// Registers a scheme for use by <see cref="T:Microsoft.AspNetCore.Authentication.IAuthenticationService" />. 
		/// </summary>
		/// <param name="scheme">The scheme.</param>
		/// <returns>true if the scheme was added successfully.</returns>
		bool TryAddScheme(AuthenticationScheme scheme)
		{
			throw null;
		}

		/// <summary>
		/// Removes a scheme, preventing it from being used by <see cref="T:Microsoft.AspNetCore.Authentication.IAuthenticationService" />.
		/// </summary>
		/// <param name="name">The name of the authenticationScheme being removed.</param>
		void RemoveScheme(string name);

		/// <summary>
		/// Returns the schemes in priority order for request handling.
		/// </summary>
		/// <returns>The schemes in priority order for request handling</returns>
		Task<IEnumerable<AuthenticationScheme>> GetRequestHandlerSchemesAsync();
	}
}
