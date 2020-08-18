using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// Defines settings used to create a cookie.
	/// </summary>
	public class CookieBuilder
	{
		/// <summary>
		/// The name of the cookie.
		/// </summary>
		public virtual string? Name
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
		/// The cookie path.
		/// </summary>
		/// <remarks>
		/// Determines the value that will set on <see cref="P:Microsoft.AspNetCore.Http.CookieOptions.Path" />.
		/// </remarks>
		public virtual string? Path
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
		/// The domain to associate the cookie with.
		/// </summary>
		/// <remarks>
		/// Determines the value that will set on <see cref="P:Microsoft.AspNetCore.Http.CookieOptions.Domain" />.
		/// </remarks>
		public virtual string? Domain
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
		/// Indicates whether a cookie is accessible by client-side script.
		/// </summary>
		/// <remarks>
		/// Determines the value that will set on <see cref="P:Microsoft.AspNetCore.Http.CookieOptions.HttpOnly" />.
		/// </remarks>
		public virtual bool HttpOnly
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
		/// The SameSite attribute of the cookie. The default value is <see cref="F:Microsoft.AspNetCore.Http.SameSiteMode.Unspecified" />
		/// </summary>
		/// <remarks>
		/// Determines the value that will set on <see cref="P:Microsoft.AspNetCore.Http.CookieOptions.SameSite" />.
		/// </remarks>
		public virtual SameSiteMode SameSite
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
		/// The policy that will be used to determine <see cref="P:Microsoft.AspNetCore.Http.CookieOptions.Secure" />.
		/// This is determined from the <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> passed to <see cref="M:Microsoft.AspNetCore.Http.CookieBuilder.Build(Microsoft.AspNetCore.Http.HttpContext,System.DateTimeOffset)" />.
		/// </summary>
		public virtual CookieSecurePolicy SecurePolicy
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
		/// Gets or sets the lifespan of a cookie.
		/// </summary>
		public virtual TimeSpan? Expiration
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
		public virtual TimeSpan? MaxAge
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
		public virtual bool IsEssential
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
		/// Creates the cookie options from the given <paramref name="context" />.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />.</param>
		/// <returns>The cookie options.</returns>
		public CookieOptions Build(HttpContext context)
		{
			throw null;
		}

		/// <summary>
		/// Creates the cookie options from the given <paramref name="context" /> with an expiration based on <paramref name="expiresFrom" /> and <see cref="P:Microsoft.AspNetCore.Http.CookieBuilder.Expiration" />.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />.</param>
		/// <param name="expiresFrom">The time to use as the base for computing <see cref="P:Microsoft.AspNetCore.Http.CookieOptions.Expires" />.</param>
		/// <returns>The cookie options.</returns>
		public virtual CookieOptions Build(HttpContext context, DateTimeOffset expiresFrom)
		{
			throw null;
		}

		public CookieBuilder()
		{
			throw null;
		}
	}
}
