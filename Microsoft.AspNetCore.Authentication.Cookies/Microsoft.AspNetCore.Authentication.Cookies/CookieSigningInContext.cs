using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace Microsoft.AspNetCore.Authentication.Cookies
{
	/// <summary>
	/// Context object passed to the <see cref="M:Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationEvents.SigningIn(Microsoft.AspNetCore.Authentication.Cookies.CookieSigningInContext)" />.
	/// </summary>    
	public class CookieSigningInContext : PrincipalContext<CookieAuthenticationOptions>
	{
		/// <summary>
		/// The options for creating the outgoing cookie.
		/// May be replace or altered during the SigningIn call.
		/// </summary>
		public CookieOptions CookieOptions
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new instance of the context object.
		/// </summary>
		/// <param name="context">The HTTP request context</param>
		/// <param name="scheme">The scheme data</param>
		/// <param name="options">The handler options</param>
		/// <param name="principal">Initializes Principal property</param>
		/// <param name="properties">The authentication properties.</param>
		/// <param name="cookieOptions">Initializes options for the authentication cookie.</param>
		public CookieSigningInContext(HttpContext context, AuthenticationScheme scheme, CookieAuthenticationOptions options, ClaimsPrincipal principal, AuthenticationProperties? properties, CookieOptions cookieOptions)
		{
			throw null;
		}
	}
}
