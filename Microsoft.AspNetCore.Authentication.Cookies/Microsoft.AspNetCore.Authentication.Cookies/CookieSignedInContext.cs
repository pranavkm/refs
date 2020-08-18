using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace Microsoft.AspNetCore.Authentication.Cookies
{
	/// <summary>
	/// Context object passed to the ICookieAuthenticationEvents method SignedIn.
	/// </summary>    
	public class CookieSignedInContext : PrincipalContext<CookieAuthenticationOptions>
	{
		/// <summary>
		/// Creates a new instance of the context object.
		/// </summary>
		/// <param name="context">The HTTP request context</param>
		/// <param name="scheme">The scheme data</param>
		/// <param name="principal">Initializes Principal property</param>
		/// <param name="properties">Initializes Properties property</param>
		/// <param name="options">The handler options</param>
		public CookieSignedInContext(HttpContext context, AuthenticationScheme scheme, ClaimsPrincipal principal, AuthenticationProperties? properties, CookieAuthenticationOptions options)
		{
			throw null;
		}
	}
}
