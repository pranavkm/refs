using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// Options used to create a new cookie.
	/// </summary>
	public class CookieOptions
	{
		/// <summary>
		/// Gets or sets the domain to associate the cookie with.
		/// </summary>
		/// <returns>The domain to associate the cookie with.</returns>
		public string? Domain
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
		/// Gets or sets the cookie path.
		/// </summary>
		/// <returns>The cookie path.</returns>
		public string? Path
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
		/// Gets or sets the expiration date and time for the cookie.
		/// </summary>
		/// <returns>The expiration date and time for the cookie.</returns>
		public DateTimeOffset? Expires
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
		/// Gets or sets a value that indicates whether to transmit the cookie using Secure Sockets Layer (SSL)--that is, over HTTPS only.
		/// </summary>
		/// <returns>true to transmit the cookie only over an SSL connection (HTTPS); otherwise, false.</returns>
		public bool Secure
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
		/// Gets or sets the value for the SameSite attribute of the cookie. The default value is <see cref="F:Microsoft.AspNetCore.Http.SameSiteMode.Unspecified" />
		/// </summary>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Http.SameSiteMode" /> representing the enforcement mode of the cookie.</returns>
		public SameSiteMode SameSite
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
		/// Gets or sets a value that indicates whether a cookie is accessible by client-side script.
		/// </summary>
		/// <returns>true if a cookie must not be accessible by client-side script; otherwise, false.</returns>
		public bool HttpOnly
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
		/// Gets or sets the max-age for the cookie.
		/// </summary>
		/// <returns>The max-age date and time for the cookie.</returns>
		public TimeSpan? MaxAge
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
		/// Indicates if this cookie is essential for the application to function correctly. If true then
		/// consent policy checks may be bypassed. The default value is false.
		/// </summary>
		public bool IsEssential
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
		/// Creates a default cookie with a path of '/'.
		/// </summary>
		public CookieOptions()
		{
			throw null;
		}
	}
}
