using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace Microsoft.AspNetCore.Authentication.Cookies
{
	/// <summary>
	/// Context object passed to the CookieAuthenticationEvents ValidatePrincipal method.
	/// </summary>
	public class CookieValidatePrincipalContext : PrincipalContext<CookieAuthenticationOptions>
	{
		/// <summary>
		/// If true, the cookie will be renewed
		/// </summary>
		public bool ShouldRenew
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
		/// <param name="context"></param>
		/// <param name="scheme"></param>
		/// <param name="ticket">Contains the initial values for identity and extra data</param>
		/// <param name="options"></param>
		public CookieValidatePrincipalContext(HttpContext context, AuthenticationScheme scheme, CookieAuthenticationOptions options, AuthenticationTicket ticket)
		{
			throw null;
		}

		/// <summary>
		/// Called to replace the claims principal. The supplied principal will replace the value of the 
		/// Principal property, which determines the identity of the authenticated request.
		/// </summary>
		/// <param name="principal">The <see cref="T:System.Security.Claims.ClaimsPrincipal" /> used as the replacement</param>
		public void ReplacePrincipal(ClaimsPrincipal principal)
		{
			throw null;
		}

		/// <summary>
		/// Called to reject the incoming principal. This may be done if the application has determined the
		/// account is no longer active, and the request should be treated as if it was anonymous.
		/// </summary>
		public void RejectPrincipal()
		{
			throw null;
		}
	}
}
