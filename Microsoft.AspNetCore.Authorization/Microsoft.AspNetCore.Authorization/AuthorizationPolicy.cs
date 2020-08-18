using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authorization
{
	/// <summary>
	/// Represents a collection of authorization requirements and the scheme or 
	/// schemes they are evaluated against, all of which must succeed
	/// for authorization to succeed.
	/// </summary>
	public class AuthorizationPolicy
	{
		/// <summary>
		/// Gets a readonly list of <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationRequirement" />s which must succeed for
		/// this policy to be successful.
		/// </summary>
		public IReadOnlyList<IAuthorizationRequirement> Requirements
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets a readonly list of the authentication schemes the <see cref="P:Microsoft.AspNetCore.Authorization.AuthorizationPolicy.Requirements" /> 
		/// are evaluated against.
		/// </summary>
		public IReadOnlyList<string> AuthenticationSchemes
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizationPolicy" />.
		/// </summary>
		/// <param name="requirements">
		/// The list of <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationRequirement" />s which must succeed for
		/// this policy to be successful.
		/// </param>
		/// <param name="authenticationSchemes">
		/// The authentication schemes the <paramref name="requirements" /> are evaluated against.
		/// </param>
		public AuthorizationPolicy(IEnumerable<IAuthorizationRequirement> requirements, IEnumerable<string> authenticationSchemes)
		{
			throw null;
		}

		/// <summary>
		/// Combines the specified <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizationPolicy" /> into a single policy.
		/// </summary>
		/// <param name="policies">The authorization policies to combine.</param>
		/// <returns>
		/// A new <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizationPolicy" /> which represents the combination of the
		/// specified <paramref name="policies" />.
		/// </returns>
		public static AuthorizationPolicy Combine(params AuthorizationPolicy[] policies)
		{
			throw null;
		}

		/// <summary>
		/// Combines the specified <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizationPolicy" /> into a single policy.
		/// </summary>
		/// <param name="policies">The authorization policies to combine.</param>
		/// <returns>
		/// A new <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizationPolicy" /> which represents the combination of the
		/// specified <paramref name="policies" />.
		/// </returns>
		public static AuthorizationPolicy Combine(IEnumerable<AuthorizationPolicy> policies)
		{
			throw null;
		}

		/// <summary>
		/// Combines the <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizationPolicy" /> provided by the specified
		/// <paramref name="policyProvider" />.
		/// </summary>
		/// <param name="policyProvider">A <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationPolicyProvider" /> which provides the policies to combine.</param>
		/// <param name="authorizeData">A collection of authorization data used to apply authorization to a resource.</param>
		/// <returns>
		/// A new <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizationPolicy" /> which represents the combination of the
		/// authorization policies provided by the specified <paramref name="policyProvider" />.
		/// </returns>
		[AsyncStateMachine(typeof(_003CCombineAsync_003Ed__9))]
		[DebuggerStepThrough]
		public static Task<AuthorizationPolicy?> CombineAsync(IAuthorizationPolicyProvider policyProvider, IEnumerable<IAuthorizeData> authorizeData)
		{
			throw null;
		}
	}
}
