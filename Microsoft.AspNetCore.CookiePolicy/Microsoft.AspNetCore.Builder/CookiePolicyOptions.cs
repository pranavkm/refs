using Microsoft.AspNetCore.CookiePolicy;
using Microsoft.AspNetCore.Http;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Provides programmatic configuration for the <see cref="T:Microsoft.AspNetCore.CookiePolicy.CookiePolicyMiddleware" />.
	/// </summary>
	public class CookiePolicyOptions
	{
		/// <summary>
		/// Affects the cookie's same site attribute.
		/// </summary>
		public SameSiteMode MinimumSameSitePolicy
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
		/// Affects whether cookies must be HttpOnly.
		/// </summary>
		public HttpOnlyPolicy HttpOnly
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
		/// Affects whether cookies must be Secure.
		/// </summary>
		public CookieSecurePolicy Secure
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

		public CookieBuilder ConsentCookie
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
		/// Checks if consent policies should be evaluated on this request. The default is false.
		/// </summary>
		public Func<HttpContext, bool> CheckConsentNeeded
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
		/// Called when a cookie is appended.
		/// </summary>
		public Action<AppendCookieContext> OnAppendCookie
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
		/// Called when a cookie is deleted.
		/// </summary>
		public Action<DeleteCookieContext> OnDeleteCookie
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

		public CookiePolicyOptions()
		{
			throw null;
		}
	}
}
