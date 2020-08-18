using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authorization.Policy
{
	/// <summary>
	/// Base class for authorization handlers that need to be called for a specific requirement type.
	/// </summary>
	public interface IPolicyEvaluator
	{
		/// <summary>
		/// Does authentication for <see cref="P:Microsoft.AspNetCore.Authorization.AuthorizationPolicy.AuthenticationSchemes" /> and sets the resulting
		/// <see cref="T:System.Security.Claims.ClaimsPrincipal" /> to <see cref="P:Microsoft.AspNetCore.Http.HttpContext.User" />.  If no schemes are set, this is a no-op.
		/// </summary>
		/// <param name="policy">The <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizationPolicy" />.</param>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />.</param>
		/// <returns><see cref="M:Microsoft.AspNetCore.Authentication.AuthenticateResult.Success(Microsoft.AspNetCore.Authentication.AuthenticationTicket)" /> unless all schemes specified by <see cref="P:Microsoft.AspNetCore.Authorization.AuthorizationPolicy.AuthenticationSchemes" /> fail to authenticate.  </returns>
		Task<AuthenticateResult> AuthenticateAsync(AuthorizationPolicy policy, HttpContext context);

		/// <summary>
		/// Attempts authorization for a policy using <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationService" />.
		/// </summary>
		/// <param name="policy">The <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizationPolicy" />.</param>
		/// <param name="authenticationResult">The result of a call to <see cref="M:Microsoft.AspNetCore.Authorization.Policy.IPolicyEvaluator.AuthenticateAsync(Microsoft.AspNetCore.Authorization.AuthorizationPolicy,Microsoft.AspNetCore.Http.HttpContext)" />.</param>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />.</param>
		/// <param name="resource">
		/// An optional resource the policy should be checked with.
		/// If a resource is not required for policy evaluation you may pass null as the value.
		/// </param>
		/// <returns>Returns <see cref="M:Microsoft.AspNetCore.Authorization.Policy.PolicyAuthorizationResult.Success" /> if authorization succeeds.
		/// Otherwise returns <see cref="M:Microsoft.AspNetCore.Authorization.Policy.PolicyAuthorizationResult.Forbid(Microsoft.AspNetCore.Authorization.AuthorizationFailure)" /> if <see cref="P:Microsoft.AspNetCore.Authentication.AuthenticateResult.Succeeded" />, otherwise
		/// returns  <see cref="M:Microsoft.AspNetCore.Authorization.Policy.PolicyAuthorizationResult.Challenge" /></returns>
		Task<PolicyAuthorizationResult> AuthorizeAsync(AuthorizationPolicy policy, AuthenticateResult authenticationResult, HttpContext context, object? resource);
	}
}
