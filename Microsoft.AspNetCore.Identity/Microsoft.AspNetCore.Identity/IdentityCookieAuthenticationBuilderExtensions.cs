using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Options;
using System;

namespace Microsoft.AspNetCore.Identity
{
	/// <summary>
	/// Helper functions for configuring identity services.
	/// </summary>
	public static class IdentityCookieAuthenticationBuilderExtensions
	{
		/// <summary>
		/// Adds cookie authentication.
		/// </summary>
		/// <param name="builder">The current <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationBuilder" /> instance.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Identity.IdentityCookiesBuilder" /> which can be used to configure the identity cookies.</returns>
		public static IdentityCookiesBuilder AddIdentityCookies(this AuthenticationBuilder builder)
		{
			throw null;
		}

		/// <summary>
		/// Adds the cookie authentication needed for sign in manager.
		/// </summary>
		/// <param name="builder">The current <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationBuilder" /> instance.</param>
		/// <param name="configureCookies">Action used to configure the cookies.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Identity.IdentityCookiesBuilder" /> which can be used to configure the identity cookies.</returns>
		public static IdentityCookiesBuilder AddIdentityCookies(this AuthenticationBuilder builder, Action<IdentityCookiesBuilder> configureCookies)
		{
			throw null;
		}

		/// <summary>
		/// Adds the identity application cookie.
		/// </summary>
		/// <param name="builder">The current <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationBuilder" /> instance.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.Options.OptionsBuilder`1" /> which can be used to configure the cookie authentication.</returns>
		public static OptionsBuilder<CookieAuthenticationOptions> AddApplicationCookie(this AuthenticationBuilder builder)
		{
			throw null;
		}

		/// <summary>
		/// Adds the identity cookie used for external logins.
		/// </summary>
		/// <param name="builder">The current <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationBuilder" /> instance.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.Options.OptionsBuilder`1" /> which can be used to configure the cookie authentication.</returns>
		public static OptionsBuilder<CookieAuthenticationOptions> AddExternalCookie(this AuthenticationBuilder builder)
		{
			throw null;
		}

		/// <summary>
		/// Adds the identity cookie used for two factor remember me.
		/// </summary>
		/// <param name="builder">The current <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationBuilder" /> instance.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.Options.OptionsBuilder`1" /> which can be used to configure the cookie authentication.</returns>
		public static OptionsBuilder<CookieAuthenticationOptions> AddTwoFactorRememberMeCookie(this AuthenticationBuilder builder)
		{
			throw null;
		}

		/// <summary>
		/// Adds the identity cookie used for two factor logins.
		/// </summary>
		/// <param name="builder">The current <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationBuilder" /> instance.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.Options.OptionsBuilder`1" /> which can be used to configure the cookie authentication.</returns>
		public static OptionsBuilder<CookieAuthenticationOptions> AddTwoFactorUserIdCookie(this AuthenticationBuilder builder)
		{
			throw null;
		}
	}
}
