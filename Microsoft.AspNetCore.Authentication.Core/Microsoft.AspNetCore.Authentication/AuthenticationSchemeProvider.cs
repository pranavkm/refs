using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Implements <see cref="T:Microsoft.AspNetCore.Authentication.IAuthenticationSchemeProvider" />.
	/// </summary>
	public class AuthenticationSchemeProvider : IAuthenticationSchemeProvider
	{
		/// <summary>
		/// Creates an instance of <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationSchemeProvider" />
		/// using the specified <paramref name="options" />,
		/// </summary>
		/// <param name="options">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationOptions" /> options.</param>
		public AuthenticationSchemeProvider(IOptions<AuthenticationOptions> options)
		{
			throw null;
		}

		/// <summary>
		/// Creates an instance of <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationSchemeProvider" />
		/// using the specified <paramref name="options" /> and <paramref name="schemes" />.
		/// </summary>
		/// <param name="options">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationOptions" /> options.</param>
		/// <param name="schemes">The dictionary used to store authentication schemes.</param>
		protected AuthenticationSchemeProvider(IOptions<AuthenticationOptions> options, IDictionary<string, AuthenticationScheme> schemes)
		{
			throw null;
		}

		/// <summary>
		/// Returns the scheme that will be used by default for <see cref="M:Microsoft.AspNetCore.Authentication.IAuthenticationService.AuthenticateAsync(Microsoft.AspNetCore.Http.HttpContext,System.String)" />.
		/// This is typically specified via <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationOptions.DefaultAuthenticateScheme" />.
		/// Otherwise, this will fallback to <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationOptions.DefaultScheme" />.
		/// </summary>
		/// <returns>The scheme that will be used by default for <see cref="M:Microsoft.AspNetCore.Authentication.IAuthenticationService.AuthenticateAsync(Microsoft.AspNetCore.Http.HttpContext,System.String)" />.</returns>
		public virtual Task<AuthenticationScheme?> GetDefaultAuthenticateSchemeAsync()
		{
			throw null;
		}

		/// <summary>
		/// Returns the scheme that will be used by default for <see cref="M:Microsoft.AspNetCore.Authentication.IAuthenticationService.ChallengeAsync(Microsoft.AspNetCore.Http.HttpContext,System.String,Microsoft.AspNetCore.Authentication.AuthenticationProperties)" />.
		/// This is typically specified via <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationOptions.DefaultChallengeScheme" />.
		/// Otherwise, this will fallback to <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationOptions.DefaultScheme" />.
		/// </summary>
		/// <returns>The scheme that will be used by default for <see cref="M:Microsoft.AspNetCore.Authentication.IAuthenticationService.ChallengeAsync(Microsoft.AspNetCore.Http.HttpContext,System.String,Microsoft.AspNetCore.Authentication.AuthenticationProperties)" />.</returns>
		public virtual Task<AuthenticationScheme?> GetDefaultChallengeSchemeAsync()
		{
			throw null;
		}

		/// <summary>
		/// Returns the scheme that will be used by default for <see cref="M:Microsoft.AspNetCore.Authentication.IAuthenticationService.ForbidAsync(Microsoft.AspNetCore.Http.HttpContext,System.String,Microsoft.AspNetCore.Authentication.AuthenticationProperties)" />.
		/// This is typically specified via <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationOptions.DefaultForbidScheme" />.
		/// Otherwise, this will fallback to <see cref="M:Microsoft.AspNetCore.Authentication.AuthenticationSchemeProvider.GetDefaultChallengeSchemeAsync" /> .
		/// </summary>
		/// <returns>The scheme that will be used by default for <see cref="M:Microsoft.AspNetCore.Authentication.IAuthenticationService.ForbidAsync(Microsoft.AspNetCore.Http.HttpContext,System.String,Microsoft.AspNetCore.Authentication.AuthenticationProperties)" />.</returns>
		public virtual Task<AuthenticationScheme?> GetDefaultForbidSchemeAsync()
		{
			throw null;
		}

		/// <summary>
		/// Returns the scheme that will be used by default for <see cref="M:Microsoft.AspNetCore.Authentication.IAuthenticationService.SignInAsync(Microsoft.AspNetCore.Http.HttpContext,System.String,System.Security.Claims.ClaimsPrincipal,Microsoft.AspNetCore.Authentication.AuthenticationProperties)" />.
		/// This is typically specified via <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationOptions.DefaultSignInScheme" />.
		/// Otherwise, this will fallback to <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationOptions.DefaultScheme" />.
		/// </summary>
		/// <returns>The scheme that will be used by default for <see cref="M:Microsoft.AspNetCore.Authentication.IAuthenticationService.SignInAsync(Microsoft.AspNetCore.Http.HttpContext,System.String,System.Security.Claims.ClaimsPrincipal,Microsoft.AspNetCore.Authentication.AuthenticationProperties)" />.</returns>
		public virtual Task<AuthenticationScheme?> GetDefaultSignInSchemeAsync()
		{
			throw null;
		}

		/// <summary>
		/// Returns the scheme that will be used by default for <see cref="M:Microsoft.AspNetCore.Authentication.IAuthenticationService.SignOutAsync(Microsoft.AspNetCore.Http.HttpContext,System.String,Microsoft.AspNetCore.Authentication.AuthenticationProperties)" />.
		/// This is typically specified via <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticationOptions.DefaultSignOutScheme" />.
		/// Otherwise this will fallback to <see cref="M:Microsoft.AspNetCore.Authentication.AuthenticationSchemeProvider.GetDefaultSignInSchemeAsync" /> if that supports sign out.
		/// </summary>
		/// <returns>The scheme that will be used by default for <see cref="M:Microsoft.AspNetCore.Authentication.IAuthenticationService.SignOutAsync(Microsoft.AspNetCore.Http.HttpContext,System.String,Microsoft.AspNetCore.Authentication.AuthenticationProperties)" />.</returns>
		public virtual Task<AuthenticationScheme?> GetDefaultSignOutSchemeAsync()
		{
			throw null;
		}

		/// <summary>
		/// Returns the <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationScheme" /> matching the name, or null.
		/// </summary>
		/// <param name="name">The name of the authenticationScheme.</param>
		/// <returns>The scheme or null if not found.</returns>
		public virtual Task<AuthenticationScheme?> GetSchemeAsync(string name)
		{
			throw null;
		}

		/// <summary>
		/// Returns the schemes in priority order for request handling.
		/// </summary>
		/// <returns>The schemes in priority order for request handling</returns>
		public virtual Task<IEnumerable<AuthenticationScheme>> GetRequestHandlerSchemesAsync()
		{
			throw null;
		}

		/// <summary>
		/// Registers a scheme for use by <see cref="T:Microsoft.AspNetCore.Authentication.IAuthenticationService" />. 
		/// </summary>
		/// <param name="scheme">The scheme.</param>
		/// <returns>true if the scheme was added successfully.</returns>
		public virtual bool TryAddScheme(AuthenticationScheme scheme)
		{
			throw null;
		}

		/// <summary>
		/// Registers a scheme for use by <see cref="T:Microsoft.AspNetCore.Authentication.IAuthenticationService" />. 
		/// </summary>
		/// <param name="scheme">The scheme.</param>
		public virtual void AddScheme(AuthenticationScheme scheme)
		{
			throw null;
		}

		/// <summary>
		/// Removes a scheme, preventing it from being used by <see cref="T:Microsoft.AspNetCore.Authentication.IAuthenticationService" />.
		/// </summary>
		/// <param name="name">The name of the authenticationScheme being removed.</param>
		public virtual void RemoveScheme(string name)
		{
			throw null;
		}

		public virtual Task<IEnumerable<AuthenticationScheme>> GetAllSchemesAsync()
		{
			throw null;
		}
	}
}
