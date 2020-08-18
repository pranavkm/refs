using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Authentication.Cookies
{
	/// <summary>
	/// Configuration options for <see cref="T:Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationOptions" />.
	/// </summary>
	public class CookieAuthenticationOptions : AuthenticationSchemeOptions
	{
		/// <summary>
		/// <para>
		/// Determines the settings used to create the cookie.
		/// </para>
		/// <para>
		/// <see cref="P:Microsoft.AspNetCore.Http.CookieBuilder.SameSite" /> defaults to <see cref="F:Microsoft.AspNetCore.Http.SameSiteMode.Lax" />.
		/// <see cref="P:Microsoft.AspNetCore.Http.CookieBuilder.HttpOnly" /> defaults to <c>true</c>.
		/// <see cref="P:Microsoft.AspNetCore.Http.CookieBuilder.SecurePolicy" /> defaults to <see cref="F:Microsoft.AspNetCore.Http.CookieSecurePolicy.SameAsRequest" />.
		/// </para>
		/// </summary>
		/// <remarks>
		/// <para>
		/// The default value for cookie <see cref="P:Microsoft.AspNetCore.Http.CookieBuilder.Name" /> is ".AspNetCore.Cookies".
		/// This value should be changed if you change the name of the <c>AuthenticationScheme</c>, especially if your
		/// system uses the cookie authentication handler multiple times.
		/// </para>
		/// <para>
		/// <see cref="P:Microsoft.AspNetCore.Http.CookieBuilder.SameSite" /> determines if the browser should allow the cookie to be attached to same-site or cross-site requests.
		/// The default is <c>Lax</c>, which means the cookie is only allowed to be attached to cross-site requests using safe HTTP methods and same-site requests.
		/// </para>
		/// <para>
		/// <see cref="P:Microsoft.AspNetCore.Http.CookieBuilder.HttpOnly" /> determines if the browser should allow the cookie to be accessed by client-side javascript.
		/// The default is true, which means the cookie will only be passed to http requests and is not made available to script on the page.
		/// </para>
		/// <para>
		/// <see cref="P:Microsoft.AspNetCore.Http.CookieBuilder.Expiration" /> is currently ignored. Use <see cref="P:Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationOptions.ExpireTimeSpan" /> to control lifetime of cookie authentication.
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
		/// If set this will be used by the CookieAuthenticationHandler for data protection.
		/// </summary>
		public IDataProtectionProvider? DataProtectionProvider
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
		/// The SlidingExpiration is set to true to instruct the handler to re-issue a new cookie with a new
		/// expiration time any time it processes a request which is more than halfway through the expiration window.
		/// </summary>
		public bool SlidingExpiration
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
		/// The LoginPath property is used by the handler for the redirection target when handling ChallengeAsync.
		/// The current url which is added to the LoginPath as a query string parameter named by the ReturnUrlParameter.
		/// Once a request to the LoginPath grants a new SignIn identity, the ReturnUrlParameter value is used to redirect
		/// the browser back to the original url.
		/// </summary>
		public PathString LoginPath
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
		/// If the LogoutPath is provided the handler then a request to that path will redirect based on the ReturnUrlParameter.
		/// </summary>
		public PathString LogoutPath
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
		/// The AccessDeniedPath property is used by the handler for the redirection target when handling ForbidAsync.
		/// </summary>
		public PathString AccessDeniedPath
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
		/// The ReturnUrlParameter determines the name of the query string parameter which is appended by the handler
		/// when during a Challenge. This is also the query string parameter looked for when a request arrives on the
		/// login path or logout path, in order to return to the original url after the action is performed.
		/// </summary>
		public string ReturnUrlParameter
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
		/// The Provider may be assigned to an instance of an object created by the application at startup time. The handler
		/// calls methods on the provider which give the application control at certain points where processing is occurring.
		/// If it is not provided a default instance is supplied which does nothing when the methods are called.
		/// </summary>
		public new CookieAuthenticationEvents Events
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
		/// The TicketDataFormat is used to protect and unprotect the identity and other properties which are stored in the
		/// cookie value. If not provided one will be created using <see cref="P:Microsoft.AspNetCore.Authentication.Cookies.CookieAuthenticationOptions.DataProtectionProvider" />.
		/// </summary>
		public ISecureDataFormat<AuthenticationTicket> TicketDataFormat
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
		/// The component used to get cookies from the request or set them on the response.
		///
		/// ChunkingCookieManager will be used by default.
		/// </summary>
		public ICookieManager CookieManager
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
		/// An optional container in which to store the identity across requests. When used, only a session identifier is sent
		/// to the client. This can be used to mitigate potential problems with very large identities.
		/// </summary>
		public ITicketStore? SessionStore
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
		/// <para>
		/// Controls how much time the authentication ticket stored in the cookie will remain valid from the point it is created
		/// The expiration information is stored in the protected cookie ticket. Because of that an expired cookie will be ignored
		/// even if it is passed to the server after the browser should have purged it.
		/// </para>
		/// <para>
		/// This is separate from the value of <see cref="P:Microsoft.AspNetCore.Http.CookieOptions.Expires" />, which specifies
		/// how long the browser will keep the cookie.
		/// </para>
		/// </summary>
		public TimeSpan ExpireTimeSpan
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
		/// Create an instance of the options initialized with the default values
		/// </summary>
		public CookieAuthenticationOptions()
		{
			throw null;
		}
	}
}
