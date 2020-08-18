using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Context passed for redirect events.
	/// </summary>
	public class RedirectContext<TOptions> : PropertiesContext<TOptions> where TOptions : AuthenticationSchemeOptions
	{
		/// <summary>
		/// Gets or Sets the URI used for the redirect operation.
		/// </summary>
		public string RedirectUri
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
		/// Creates a new context object.
		/// </summary>
		/// <param name="context">The HTTP request context</param>
		/// <param name="scheme">The scheme data</param>
		/// <param name="options">The handler options</param>
		/// <param name="redirectUri">The initial redirect URI</param>
		/// <param name="properties">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" />.</param>
		public RedirectContext(HttpContext context, AuthenticationScheme scheme, TOptions options, AuthenticationProperties properties, string redirectUri)
		{
			throw null;
		}
	}
}
