using Microsoft.AspNetCore.Http;
using System;
using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Base context for events that produce AuthenticateResults.
	/// </summary>
	public abstract class ResultContext<TOptions> : BaseContext<TOptions> where TOptions : AuthenticationSchemeOptions
	{
		/// <summary>
		/// Gets or sets the <see cref="T:System.Security.Claims.ClaimsPrincipal" /> containing the user claims.
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
		public AuthenticationProperties Properties
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
		/// Gets the <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticateResult" /> result.
		/// </summary>
		public AuthenticateResult Result
		{
			[CompilerGenerated]
			get
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
		protected ResultContext(HttpContext context, AuthenticationScheme scheme, TOptions options)
		{
			throw null;
		}

		/// <summary>
		/// Calls success creating a ticket with the <see cref="P:Microsoft.AspNetCore.Authentication.ResultContext`1.Principal" /> and <see cref="P:Microsoft.AspNetCore.Authentication.ResultContext`1.Properties" />.
		/// </summary>
		public void Success()
		{
			throw null;
		}

		/// <summary>
		/// Indicates that there was no information returned for this authentication scheme.
		/// </summary>
		public void NoResult()
		{
			throw null;
		}

		/// <summary>
		/// Indicates that there was a failure during authentication.
		/// </summary>
		/// <param name="failure"></param>
		public void Fail(Exception failure)
		{
			throw null;
		}

		/// <summary>
		/// Indicates that there was a failure during authentication.
		/// </summary>
		/// <param name="failureMessage"></param>
		public void Fail(string failureMessage)
		{
			throw null;
		}
	}
}
