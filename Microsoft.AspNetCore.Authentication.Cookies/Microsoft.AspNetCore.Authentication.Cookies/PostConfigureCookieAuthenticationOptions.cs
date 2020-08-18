using Microsoft.AspNetCore.DataProtection;
using Microsoft.Extensions.Options;

namespace Microsoft.AspNetCore.Authentication.Cookies
{
	/// <summary>
	/// Used to setup defaults for all <see cref="T:Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationOptions" />.
	/// </summary>
	public class PostConfigureCookieAuthenticationOptions : IPostConfigureOptions<CookieAuthenticationOptions>
	{
		public PostConfigureCookieAuthenticationOptions(IDataProtectionProvider dataProtection)
		{
			throw null;
		}

		/// <summary>
		/// Invoked to post configure a TOptions instance.
		/// </summary>
		/// <param name="name">The name of the options instance being configured.</param>
		/// <param name="options">The options instance to configure.</param>
		public void PostConfigure(string name, CookieAuthenticationOptions options)
		{
			throw null;
		}
	}
}
