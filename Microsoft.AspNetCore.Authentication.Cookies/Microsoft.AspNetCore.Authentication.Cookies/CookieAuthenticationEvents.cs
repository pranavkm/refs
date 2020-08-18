using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authentication.Cookies
{
	/// <summary>
	/// This default implementation of the ICookieAuthenticationEvents may be used if the
	/// application only needs to override a few of the interface methods. This may be used as a base class
	/// or may be instantiated directly.
	/// </summary>
	public class CookieAuthenticationEvents
	{
		/// <summary>
		/// A delegate assigned to this property will be invoked when the related method is called.
		/// </summary>
		public Func<CookieValidatePrincipalContext, Task> OnValidatePrincipal
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
		/// A delegate assigned to this property will be invoked when the related method is called.
		/// </summary>
		public Func<CookieSigningInContext, Task> OnSigningIn
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
		/// A delegate assigned to this property will be invoked when the related method is called.
		/// </summary>
		public Func<CookieSignedInContext, Task> OnSignedIn
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
		/// A delegate assigned to this property will be invoked when the related method is called.
		/// </summary>
		public Func<CookieSigningOutContext, Task> OnSigningOut
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
		/// A delegate assigned to this property will be invoked when the related method is called.
		/// </summary>
		public Func<RedirectContext<CookieAuthenticationOptions>, Task> OnRedirectToLogin
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
		/// A delegate assigned to this property will be invoked when the related method is called.
		/// </summary>
		public Func<RedirectContext<CookieAuthenticationOptions>, Task> OnRedirectToAccessDenied
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
		/// A delegate assigned to this property will be invoked when the related method is called.
		/// </summary>
		public Func<RedirectContext<CookieAuthenticationOptions>, Task> OnRedirectToLogout
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
		/// A delegate assigned to this property will be invoked when the related method is called.
		/// </summary>
		public Func<RedirectContext<CookieAuthenticationOptions>, Task> OnRedirectToReturnUrl
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
		/// Implements the interface method by invoking the related delegate method.
		/// </summary>
		/// <param name="context"></param>
		/// <returns></returns>
		public virtual Task ValidatePrincipal(CookieValidatePrincipalContext context)
		{
			throw null;
		}

		/// <summary>
		/// Implements the interface method by invoking the related delegate method.
		/// </summary>
		/// <param name="context"></param>
		public virtual Task SigningIn(CookieSigningInContext context)
		{
			throw null;
		}

		/// <summary>
		/// Implements the interface method by invoking the related delegate method.
		/// </summary>
		/// <param name="context"></param>
		public virtual Task SignedIn(CookieSignedInContext context)
		{
			throw null;
		}

		/// <summary>
		/// Implements the interface method by invoking the related delegate method.
		/// </summary>
		/// <param name="context"></param>
		public virtual Task SigningOut(CookieSigningOutContext context)
		{
			throw null;
		}

		/// <summary>
		/// Implements the interface method by invoking the related delegate method.
		/// </summary>
		/// <param name="context">Contains information about the event</param>
		public virtual Task RedirectToLogout(RedirectContext<CookieAuthenticationOptions> context)
		{
			throw null;
		}

		/// <summary>
		/// Implements the interface method by invoking the related delegate method.
		/// </summary>
		/// <param name="context">Contains information about the event</param>
		public virtual Task RedirectToLogin(RedirectContext<CookieAuthenticationOptions> context)
		{
			throw null;
		}

		/// <summary>
		/// Implements the interface method by invoking the related delegate method.
		/// </summary>
		/// <param name="context">Contains information about the event</param>
		public virtual Task RedirectToReturnUrl(RedirectContext<CookieAuthenticationOptions> context)
		{
			throw null;
		}

		/// <summary>
		/// Implements the interface method by invoking the related delegate method.
		/// </summary>
		/// <param name="context">Contains information about the event</param>
		public virtual Task RedirectToAccessDenied(RedirectContext<CookieAuthenticationOptions> context)
		{
			throw null;
		}

		public CookieAuthenticationEvents()
		{
			throw null;
		}
	}
}
