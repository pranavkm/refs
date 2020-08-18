using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Authentication.Cookies
{
	/// <summary>
	/// Context object passed to the <see cref="M:Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationEvents.SigningOut(Microsoft.AspNetCore.Authentication.Cookies.CookieSigningOutContext)" />
	/// </summary>
	public class CookieSigningOutContext : PropertiesContext<CookieAuthenticationOptions>
	{
		/// <summary>
		/// The options for creating the outgoing cookie.
		/// May be replace or altered during the SigningOut call.
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
		///
		/// </summary>
		/// <param name="context"></param>
		/// <param name="scheme"></param>
		/// <param name="options"></param>
		/// <param name="properties"></param>
		/// <param name="cookieOptions"></param>
		public CookieSigningOutContext(HttpContext context, AuthenticationScheme scheme, CookieAuthenticationOptions options, AuthenticationProperties? properties, CookieOptions cookieOptions)
		{
			throw null;
		}
	}
}
