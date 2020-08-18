using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Authorization
{
	/// <summary>
	/// Encapsulates a failure result of <see cref="M:Microsoft.AspNetCore.Authorization.IAuthorizationService.AuthorizeAsync(System.Security.Claims.ClaimsPrincipal,System.Object,System.Collections.Generic.IEnumerable{Microsoft.AspNetCore.Authorization.IAuthorizationRequirement})" />.
	/// </summary>
	public class AuthorizationFailure
	{
		/// <summary>
		/// Failure was due to <see cref="M:Microsoft.AspNetCore.Authorization.AuthorizationHandlerContext.Fail" /> being called.
		/// </summary>
		public bool FailCalled
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Failure was due to these requirements not being met via <see cref="M:Microsoft.AspNetCore.Authorization.AuthorizationHandlerContext.Succeed(Microsoft.AspNetCore.Authorization.IAuthorizationRequirement)" />.
		/// </summary>
		public IEnumerable<IAuthorizationRequirement> FailedRequirements
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Return a failure due to <see cref="M:Microsoft.AspNetCore.Authorization.AuthorizationHandlerContext.Fail" /> being called.
		/// </summary>
		/// <returns>The failure.</returns>
		public static AuthorizationFailure ExplicitFail()
		{
			throw null;
		}

		/// <summary>
		/// Return a failure due to some requirements not being met via <see cref="M:Microsoft.AspNetCore.Authorization.AuthorizationHandlerContext.Succeed(Microsoft.AspNetCore.Authorization.IAuthorizationRequirement)" />.
		/// </summary>
		/// <param name="failed">The requirements that were not met.</param>
		/// <returns>The failure.</returns>
		public static AuthorizationFailure Failed(IEnumerable<IAuthorizationRequirement> failed)
		{
			throw null;
		}
	}
}
