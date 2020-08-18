using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Extension methods for storing authentication tokens in <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" />.
	/// </summary>
	public static class AuthenticationTokenExtensions
	{
		/// <summary>
		/// Stores a set of authentication tokens, after removing any old tokens.
		/// </summary>
		/// <param name="properties">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" /> properties.</param>
		/// <param name="tokens">The tokens to store.</param>
		public static void StoreTokens(this AuthenticationProperties properties, IEnumerable<AuthenticationToken> tokens)
		{
			throw null;
		}

		/// <summary>
		/// Returns the value of a token.
		/// </summary>
		/// <param name="properties">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" /> properties.</param>
		/// <param name="tokenName">The token name.</param>
		/// <returns>The token value.</returns>
		public static string? GetTokenValue(this AuthenticationProperties properties, string tokenName)
		{
			throw null;
		}

		public static bool UpdateTokenValue(this AuthenticationProperties properties, string tokenName, string tokenValue)
		{
			throw null;
		}

		/// <summary>
		/// Returns all of the AuthenticationTokens contained in the properties.
		/// </summary>
		/// <param name="properties">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" /> properties.</param>
		/// <returns>The authentication tokens.</returns>
		public static IEnumerable<AuthenticationToken> GetTokens(this AuthenticationProperties properties)
		{
			throw null;
		}

		/// <summary>
		/// Extension method for getting the value of an authentication token.
		/// </summary>
		/// <param name="auth">The <see cref="T:Microsoft.AspNetCore.Authentication.IAuthenticationService" />.</param>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> context.</param>
		/// <param name="tokenName">The name of the token.</param>
		/// <returns>The value of the token.</returns>
		public static Task<string?> GetTokenAsync(this IAuthenticationService auth, HttpContext context, string tokenName)
		{
			throw null;
		}

		/// <summary>
		/// Extension method for getting the value of an authentication token.
		/// </summary>
		/// <param name="auth">The <see cref="T:Microsoft.AspNetCore.Authentication.IAuthenticationService" />.</param>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> context.</param>
		/// <param name="scheme">The name of the authentication scheme.</param>
		/// <param name="tokenName">The name of the token.</param>
		/// <returns>The value of the token.</returns>
		[AsyncStateMachine(typeof(_003CGetTokenAsync_003Ed__7))]
		[DebuggerStepThrough]
		public static Task<string?> GetTokenAsync(this IAuthenticationService auth, HttpContext context, string? scheme, string tokenName)
		{
			throw null;
		}
	}
}
