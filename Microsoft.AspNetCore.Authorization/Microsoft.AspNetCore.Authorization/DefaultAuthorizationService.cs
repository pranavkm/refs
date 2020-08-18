using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authorization
{
	/// <summary>
	/// The default implementation of an <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationService" />.
	/// </summary>
	public class DefaultAuthorizationService : IAuthorizationService
	{
		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Authorization.DefaultAuthorizationService" />.
		/// </summary>
		/// <param name="policyProvider">The <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationPolicyProvider" /> used to provide policies.</param>
		/// <param name="handlers">The handlers used to fulfill <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationRequirement" />s.</param>
		/// <param name="logger">The logger used to log messages, warnings and errors.</param>  
		/// <param name="contextFactory">The <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationHandlerContextFactory" /> used to create the context to handle the authorization.</param>  
		/// <param name="evaluator">The <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationEvaluator" /> used to determine if authorization was successful.</param>  
		/// <param name="options">The <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizationOptions" /> used.</param>  
		public DefaultAuthorizationService(IAuthorizationPolicyProvider policyProvider, IAuthorizationHandlerProvider handlers, ILogger<DefaultAuthorizationService> logger, IAuthorizationHandlerContextFactory contextFactory, IAuthorizationEvaluator evaluator, IOptions<AuthorizationOptions> options)
		{
			throw null;
		}

		/// <summary>
		/// Checks if a user meets a specific set of requirements for the specified resource.
		/// </summary>
		/// <param name="user">The user to evaluate the requirements against.</param>
		/// <param name="resource">The resource to evaluate the requirements against.</param>
		/// <param name="requirements">The requirements to evaluate.</param>
		/// <returns>
		/// A flag indicating whether authorization has succeeded.
		/// This value is <value>true</value> when the user fulfills the policy otherwise <value>false</value>.
		/// </returns>
		[AsyncStateMachine(typeof(_003CAuthorizeAsync_003Ed__7))]
		[DebuggerStepThrough]
		public virtual Task<AuthorizationResult> AuthorizeAsync(ClaimsPrincipal user, object? resource, IEnumerable<IAuthorizationRequirement> requirements)
		{
			throw null;
		}

		/// <summary>
		/// Checks if a user meets a specific authorization policy.
		/// </summary>
		/// <param name="user">The user to check the policy against.</param>
		/// <param name="resource">The resource the policy should be checked with.</param>
		/// <param name="policyName">The name of the policy to check against a specific context.</param>
		/// <returns>
		/// A flag indicating whether authorization has succeeded.
		/// This value is <value>true</value> when the user fulfills the policy otherwise <value>false</value>.
		/// </returns>
		[AsyncStateMachine(typeof(_003CAuthorizeAsync_003Ed__8))]
		[DebuggerStepThrough]
		public virtual Task<AuthorizationResult> AuthorizeAsync(ClaimsPrincipal user, object? resource, string policyName)
		{
			throw null;
		}
	}
}
