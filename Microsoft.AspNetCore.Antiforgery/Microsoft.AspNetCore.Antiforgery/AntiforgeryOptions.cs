using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Antiforgery
{
	/// <summary>
	/// Provides programmatic configuration for the antiforgery token system.
	/// </summary>
	public class AntiforgeryOptions
	{
		/// <summary>
		/// The default cookie prefix, which is ".AspNetCore.Antiforgery.".
		/// </summary>
		public static readonly string DefaultCookiePrefix;

		/// <summary>
		/// Determines the settings used to create the antiforgery cookies.
		/// </summary>
		/// <remarks>
		/// <para>
		/// If an explicit <see cref="P:Microsoft.AspNetCore.Http.CookieBuilder.Name" /> is not provided, the system will automatically generate a
		/// unique name that begins with <see cref="F:Microsoft.AspNetCore.Antiforgery.AntiforgeryOptions.DefaultCookiePrefix" />.
		/// </para>
		/// <para>
		/// <see cref="P:Microsoft.AspNetCore.Http.CookieBuilder.SameSite" /> defaults to <see cref="F:Microsoft.AspNetCore.Http.SameSiteMode.Strict" />.
		/// <see cref="P:Microsoft.AspNetCore.Http.CookieBuilder.HttpOnly" /> defaults to <c>true</c>.
		/// <see cref="P:Microsoft.AspNetCore.Http.CookieBuilder.IsEssential" /> defaults to <c>true</c>. The cookie used by the antiforgery system
		/// is part of a security system that is necessary when using cookie-based authentication. It should be
		/// considered required for the application to function.
		/// <see cref="P:Microsoft.AspNetCore.Http.CookieBuilder.SecurePolicy" /> defaults to <see cref="F:Microsoft.AspNetCore.Http.CookieSecurePolicy.None" />.
		/// </para>
		/// </remarks>
		public CookieBuilder Cookie
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Specifies the name of the antiforgery token field that is used by the antiforgery system.
		/// </summary>
		public string FormFieldName
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Specifies the name of the header value that is used by the antiforgery system. If <c>null</c> then
		/// antiforgery validation will only consider form data.
		/// </summary>
		public string? HeaderName
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Specifies whether to suppress the generation of X-Frame-Options header
		/// which is used to prevent ClickJacking. By default, the X-Frame-Options
		/// header is generated with the value SAMEORIGIN. If this setting is 'true',
		/// the X-Frame-Options header will not be generated for the response.
		/// </summary>
		public bool SuppressXFrameOptionsHeader
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

		public AntiforgeryOptions()
		{
			throw null;
		}
	}
}
