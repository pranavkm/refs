using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace Microsoft.AspNetCore.Authorization
{
	/// <summary>
	/// Contains authorization information used by <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationHandler" />.
	/// </summary>
	public class AuthorizationHandlerContext
	{
		/// <summary>
		/// The collection of all the <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationRequirement" /> for the current authorization action.
		/// </summary>
		public virtual IEnumerable<IAuthorizationRequirement> Requirements
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The <see cref="T:System.Security.Claims.ClaimsPrincipal" /> representing the current user.
		/// </summary>
		public virtual ClaimsPrincipal User
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The optional resource to evaluate the <see cref="P:Microsoft.AspNetCore.Authorization.AuthorizationHandlerContext.Requirements" /> against.
		/// </summary>
		public virtual object? Resource
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the requirements that have not yet been marked as succeeded.
		/// </summary>
		public virtual IEnumerable<IAuthorizationRequirement> PendingRequirements
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Flag indicating whether the current authorization processing has failed.
		/// </summary>
		public virtual bool HasFailed
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Flag indicating whether the current authorization processing has succeeded.
		/// </summary>
		public virtual bool HasSucceeded
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizationHandlerContext" />.
		/// </summary>
		/// <param name="requirements">A collection of all the <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationRequirement" /> for the current authorization action.</param>
		/// <param name="user">A <see cref="T:System.Security.Claims.ClaimsPrincipal" /> representing the current user.</param>
		/// <param name="resource">An optional resource to evaluate the <paramref name="requirements" /> against.</param>
		public AuthorizationHandlerContext(IEnumerable<IAuthorizationRequirement> requirements, ClaimsPrincipal user, object? resource)
		{
			throw null;
		}

		/// <summary>
		/// Called to indicate <see cref="P:Microsoft.AspNetCore.Authorization.AuthorizationHandlerContext.HasSucceeded" /> will
		/// never return true, even if all requirements are met.
		/// </summary>
		public virtual void Fail()
		{
			throw null;
		}

		/// <summary>
		/// Called to mark the specified <paramref name="requirement" /> as being
		/// successfully evaluated.
		/// </summary>
		/// <param name="requirement">The requirement whose evaluation has succeeded.</param>
		public virtual void Succeed(IAuthorizationRequirement requirement)
		{
			throw null;
		}
	}
}
