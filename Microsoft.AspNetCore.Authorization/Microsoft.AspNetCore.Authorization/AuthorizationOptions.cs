using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Authorization
{
	/// <summary>
	/// Provides programmatic configuration used by <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationService" /> and <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationPolicyProvider" />.
	/// </summary>
	public class AuthorizationOptions
	{
		/// <summary>
		/// Determines whether authentication handlers should be invoked after a failure.
		/// Defaults to true.
		/// </summary>
		public bool InvokeHandlersAfterFailure
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
		/// Gets or sets the default authorization policy. Defaults to require authenticated users.
		/// </summary>
		/// <remarks>
		/// The default policy used when evaluating <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizeData" /> with no policy name specified.
		/// </remarks>
		public AuthorizationPolicy DefaultPolicy
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
		/// Gets or sets the fallback authorization policy used by <see cref="M:Microsoft.AspNetCore.Authorization.AuthorizationPolicy.CombineAsync(Microsoft.AspNetCore.Authorization.IAuthorizationPolicyProvider,System.Collections.Generic.IEnumerable{Microsoft.AspNetCore.Authorization.IAuthorizeData})" />
		/// when no IAuthorizeData have been provided. As a result, the AuthorizationMiddleware uses the fallback policy
		/// if there are no <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizeData" /> instances for a resource. If a resource has any <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizeData" />
		/// then they are evaluated instead of the fallback policy. By default the fallback policy is null, and usually will have no 
		/// effect unless you have the AuthorizationMiddleware in your pipeline. It is not used in any way by the 
		/// default <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationService" />.
		/// </summary>
		public AuthorizationPolicy? FallbackPolicy
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
		/// Add an authorization policy with the provided name.
		/// </summary>
		/// <param name="name">The name of the policy.</param>
		/// <param name="policy">The authorization policy.</param>
		public void AddPolicy(string name, AuthorizationPolicy policy)
		{
			throw null;
		}

		/// <summary>
		/// Add a policy that is built from a delegate with the provided name.
		/// </summary>
		/// <param name="name">The name of the policy.</param>
		/// <param name="configurePolicy">The delegate that will be used to build the policy.</param>
		public void AddPolicy(string name, Action<AuthorizationPolicyBuilder> configurePolicy)
		{
			throw null;
		}

		/// <summary>
		/// Returns the policy for the specified name, or null if a policy with the name does not exist.
		/// </summary>
		/// <param name="name">The name of the policy to return.</param>
		/// <returns>The policy for the specified name, or null if a policy with the name does not exist.</returns>
		public AuthorizationPolicy? GetPolicy(string name)
		{
			throw null;
		}

		public AuthorizationOptions()
		{
			throw null;
		}
	}
}
