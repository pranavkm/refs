using Microsoft.AspNetCore.Http;
using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Base context for authentication events which deal with a ClaimsPrincipal.
	/// </summary>
	public abstract class PrincipalContext<TOptions> : PropertiesContext<TOptions> where TOptions : AuthenticationSchemeOptions
	{
		/// <summary>
		/// Gets the <see cref="T:System.Security.Claims.ClaimsPrincipal" /> containing the user claims.
		/// </summary>
		public virtual ClaimsPrincipal? Principal
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
		[System.Runtime.CompilerServices.NullableContext(1)]
		protected PrincipalContext(HttpContext context, AuthenticationScheme scheme, TOptions options, AuthenticationProperties? properties)
		{
			throw null;
		}
	}
}
