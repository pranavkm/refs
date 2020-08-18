using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authorization
{
	/// <summary>
	/// Base class for authorization handlers that need to be called for a specific requirement type.
	/// </summary>
	/// <typeparam name="TRequirement">The type of the requirement to handle.</typeparam>
	public abstract class AuthorizationHandler<TRequirement> : IAuthorizationHandler where TRequirement : IAuthorizationRequirement
	{
		/// <summary>
		/// Makes a decision if authorization is allowed.
		/// </summary>
		/// <param name="context">The authorization context.</param>
		[AsyncStateMachine(typeof(AuthorizationHandler<>._003CHandleAsync_003Ed__0))]
		[DebuggerStepThrough]
		public virtual Task HandleAsync(AuthorizationHandlerContext context)
		{
			throw null;
		}

		/// <summary>
		/// Makes a decision if authorization is allowed based on a specific requirement.
		/// </summary>
		/// <param name="context">The authorization context.</param>
		/// <param name="requirement">The requirement to evaluate.</param>
		protected abstract Task HandleRequirementAsync(AuthorizationHandlerContext context, TRequirement requirement);

		protected AuthorizationHandler()
		{
			throw null;
		}
	}
	/// <summary>
	/// Base class for authorization handlers that need to be called for specific requirement and
	/// resource types.
	/// </summary>
	/// <typeparam name="TRequirement">The type of the requirement to evaluate.</typeparam>
	/// <typeparam name="TResource">The type of the resource to evaluate.</typeparam>
	public abstract class AuthorizationHandler<TRequirement, TResource> : IAuthorizationHandler where TRequirement : IAuthorizationRequirement
	{
		/// <summary>
		/// Makes a decision if authorization is allowed.
		/// </summary>
		/// <param name="context">The authorization context.</param>
		[AsyncStateMachine(typeof(AuthorizationHandler<, >._003CHandleAsync_003Ed__0))]
		[DebuggerStepThrough]
		public virtual Task HandleAsync(AuthorizationHandlerContext context)
		{
			throw null;
		}

		/// <summary>
		/// Makes a decision if authorization is allowed based on a specific requirement and resource.
		/// </summary>
		/// <param name="context">The authorization context.</param>
		/// <param name="requirement">The requirement to evaluate.</param>
		/// <param name="resource">The resource to evaluate.</param>
		protected abstract Task HandleRequirementAsync(AuthorizationHandlerContext context, TRequirement requirement, TResource resource);

		protected AuthorizationHandler()
		{
			throw null;
		}
	}
}
