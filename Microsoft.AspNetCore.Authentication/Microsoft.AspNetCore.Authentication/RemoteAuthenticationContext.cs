using Microsoft.AspNetCore.Http;
using System;
using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Base context for remote authentication.
	/// </summary>
	public abstract class RemoteAuthenticationContext<TOptions> : HandleRequestContext<TOptions> where TOptions : AuthenticationSchemeOptions
	{
		/// <summary>
		/// Gets the <see cref="T:System.Security.Claims.ClaimsPrincipal" /> containing the user claims.
		/// </summary>
		public ClaimsPrincipal? Principal
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
		/// Gets or sets the <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" />.
		/// </summary>
		public virtual AuthenticationProperties Properties
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
		/// Constructor.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="scheme">The authentication scheme.</param>
		/// <param name="options">The authentication options associated with the scheme.</param>
		/// <param name="properties">The authentication properties.</param>
		protected RemoteAuthenticationContext(HttpContext context, AuthenticationScheme scheme, TOptions options, AuthenticationProperties? properties)
		{
			throw null;
		}

		/// <summary>
		/// Calls success creating a ticket with the <see cref="P:Microsoft.AspNetCore.Authentication.RemoteAuthenticationContext`1.Principal" /> and <see cref="P:Microsoft.AspNetCore.Authentication.RemoteAuthenticationContext`1.Properties" />.
		/// </summary>
		public void Success()
		{
			throw null;
		}

		public void Fail(Exception failure)
		{
			throw null;
		}

		public void Fail(string failureMessage)
		{
			throw null;
		}
	}
}
