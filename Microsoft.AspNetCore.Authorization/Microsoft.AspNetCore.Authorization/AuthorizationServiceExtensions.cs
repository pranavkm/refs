using System.Security.Claims;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authorization
{
	/// <summary>
	/// Extension methods for <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationService" />.
	/// </summary>
	public static class AuthorizationServiceExtensions
	{
		/// <summary>
		/// Checks if a user meets a specific requirement for the specified resource
		/// </summary>
		/// <param name="service">The <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationService" /> providing authorization.</param>
		/// <param name="user">The user to evaluate the policy against.</param>
		/// <param name="resource">The resource to evaluate the policy against.</param>
		/// <param name="requirement">The requirement to evaluate the policy against.</param>
		/// <returns>
		/// A flag indicating whether requirement evaluation has succeeded or failed.
		/// This value is <value>true</value> when the user fulfills the policy, otherwise <value>false</value>.
		/// </returns>
		public static Task<AuthorizationResult> AuthorizeAsync(this IAuthorizationService service, ClaimsPrincipal user, object resource, IAuthorizationRequirement requirement)
		{
			throw null;
		}

		/// <summary>
		/// Checks if a user meets a specific authorization policy against the specified resource.
		/// </summary>
		/// <param name="service">The <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationService" /> providing authorization.</param>
		/// <param name="user">The user to evaluate the policy against.</param>
		/// <param name="resource">The resource to evaluate the policy against.</param>
		/// <param name="policy">The policy to evaluate.</param>
		/// <returns>
		/// A flag indicating whether policy evaluation has succeeded or failed.
		/// This value is <value>true</value> when the user fulfills the policy, otherwise <value>false</value>.
		/// </returns>
		public static Task<AuthorizationResult> AuthorizeAsync(this IAuthorizationService service, ClaimsPrincipal user, object? resource, AuthorizationPolicy policy)
		{
			throw null;
		}

		/// <summary>
		/// Checks if a user meets a specific authorization policy against the specified resource.
		/// </summary>
		/// <param name="service">The <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationService" /> providing authorization.</param>
		/// <param name="user">The user to evaluate the policy against.</param>
		/// <param name="policy">The policy to evaluate.</param>
		/// <returns>
		/// A flag indicating whether policy evaluation has succeeded or failed.
		/// This value is <value>true</value> when the user fulfills the policy, otherwise <value>false</value>.
		/// </returns>
		public static Task<AuthorizationResult> AuthorizeAsync(this IAuthorizationService service, ClaimsPrincipal user, AuthorizationPolicy policy)
		{
			throw null;
		}

		/// <summary>
		/// Checks if a user meets a specific authorization policy against the specified resource.
		/// </summary>
		/// <param name="service">The <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationService" /> providing authorization.</param>
		/// <param name="user">The user to evaluate the policy against.</param>
		/// <param name="policyName">The name of the policy to evaluate.</param>
		/// <returns>
		/// A flag indicating whether policy evaluation has succeeded or failed.
		/// This value is <value>true</value> when the user fulfills the policy, otherwise <value>false</value>.
		/// </returns>
		public static Task<AuthorizationResult> AuthorizeAsync(this IAuthorizationService service, ClaimsPrincipal user, string policyName)
		{
			throw null;
		}
	}
}
