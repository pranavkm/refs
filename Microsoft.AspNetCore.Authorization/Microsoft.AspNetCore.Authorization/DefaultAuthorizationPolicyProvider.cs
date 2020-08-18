using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authorization
{
	/// <summary>
	/// The default implementation of a policy provider,
	/// which provides a <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizationPolicy" /> for a particular name.
	/// </summary>
	public class DefaultAuthorizationPolicyProvider : IAuthorizationPolicyProvider
	{
		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Authorization.DefaultAuthorizationPolicyProvider" />.
		/// </summary>
		/// <param name="options">The options used to configure this instance.</param>
		public DefaultAuthorizationPolicyProvider(IOptions<AuthorizationOptions> options)
		{
			throw null;
		}

		/// <summary>
		/// Gets the default authorization policy.
		/// </summary>
		/// <returns>The default authorization policy.</returns>
		public Task<AuthorizationPolicy> GetDefaultPolicyAsync()
		{
			throw null;
		}

		/// <summary>
		/// Gets the fallback authorization policy.
		/// </summary>
		/// <returns>The fallback authorization policy.</returns>
		public Task<AuthorizationPolicy?> GetFallbackPolicyAsync()
		{
			throw null;
		}

		/// <summary>
		/// Gets a <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizationPolicy" /> from the given <paramref name="policyName" />
		/// </summary>
		/// <param name="policyName">The policy name to retrieve.</param>
		/// <returns>The named <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizationPolicy" />.</returns>
		public virtual Task<AuthorizationPolicy?> GetPolicyAsync(string policyName)
		{
			throw null;
		}
	}
}
