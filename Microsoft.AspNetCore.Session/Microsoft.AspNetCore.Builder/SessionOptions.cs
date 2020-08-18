using Microsoft.AspNetCore.Http;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Represents the session state options for the application.
	/// </summary>
	public class SessionOptions
	{
		private class SessionCookieBuilder : CookieBuilder
		{
			public override TimeSpan? Expiration
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

			public SessionCookieBuilder()
			{
				throw null;
			}
		}

		/// <summary>
		/// Determines the settings used to create the cookie.
		/// <para>
		/// <see cref="P:Microsoft.AspNetCore.Http.CookieBuilder.Name" /> defaults to <see cref="F:Microsoft.AspNetCore.Session.SessionDefaults.CookieName" />.
		/// <see cref="P:Microsoft.AspNetCore.Http.CookieBuilder.Path" /> defaults to <see cref="F:Microsoft.AspNetCore.Session.SessionDefaults.CookiePath" />.
		/// <see cref="P:Microsoft.AspNetCore.Http.CookieBuilder.SameSite" /> defaults to <see cref="F:Microsoft.AspNetCore.Http.SameSiteMode.Lax" />.
		/// <see cref="P:Microsoft.AspNetCore.Http.CookieBuilder.HttpOnly" /> defaults to <c>true</c>
		/// <see cref="P:Microsoft.AspNetCore.Http.CookieBuilder.IsEssential" /> defaults to <c>false</c>
		/// </para>
		/// </summary>
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
		/// The IdleTimeout indicates how long the session can be idle before its contents are abandoned. Each session access
		/// resets the timeout. Note this only applies to the content of the session, not the cookie.
		/// </summary>
		public TimeSpan IdleTimeout
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
		/// The maximim amount of time allowed to load a session from the store or to commit it back to the store.
		/// Note this may only apply to asynchronous operations. This timeout can be disabled using <see cref="F:System.Threading.Timeout.InfiniteTimeSpan" />.
		/// </summary>
		public TimeSpan IOTimeout
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

		public SessionOptions()
		{
			throw null;
		}
	}
}
