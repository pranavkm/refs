using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Localization
{
	/// <summary>
	/// Determines the culture information for a request via the value of a cookie.
	/// </summary>
	public class CookieRequestCultureProvider : RequestCultureProvider
	{
		/// <summary>
		/// Represent the default cookie name used to track the user's preferred culture information, which is ".AspNetCore.Culture".
		/// </summary>
		public static readonly string DefaultCookieName;

		/// <summary>
		/// The name of the cookie that contains the user's preferred culture information.
		/// Defaults to <see cref="F:Microsoft.AspNetCore.Localization.CookieRequestCultureProvider.DefaultCookieName" />.
		/// </summary>
		public string CookieName
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

		/// <inheritdoc />
		public override Task<ProviderCultureResult> DetermineProviderCultureResult(HttpContext httpContext)
		{
			throw null;
		}

		/// <summary>
		/// Creates a string representation of a <see cref="T:Microsoft.AspNetCore.Localization.RequestCulture" /> for placement in a cookie.
		/// </summary>
		/// <param name="requestCulture">The <see cref="T:Microsoft.AspNetCore.Localization.RequestCulture" />.</param>
		/// <returns>The cookie value.</returns>
		public static string MakeCookieValue(RequestCulture requestCulture)
		{
			throw null;
		}

		/// <summary>
		/// Parses a <see cref="T:Microsoft.AspNetCore.Localization.RequestCulture" /> from the specified cookie value.
		/// Returns <c>null</c> if parsing fails.
		/// </summary>
		/// <param name="value">The cookie value to parse.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Localization.RequestCulture" /> or <c>null</c> if parsing fails.</returns>
		public static ProviderCultureResult ParseCookieValue(string value)
		{
			throw null;
		}

		public CookieRequestCultureProvider()
		{
			throw null;
		}
	}
}
