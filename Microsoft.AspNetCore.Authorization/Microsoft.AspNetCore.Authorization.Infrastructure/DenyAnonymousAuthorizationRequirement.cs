using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authorization.Infrastructure
{
	/// <summary>
	/// Implements an <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationHandler" /> and <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationRequirement" />
	/// which requires the current user must be authenticated.
	/// </summary>
	public class DenyAnonymousAuthorizationRequirement : AuthorizationHandler<DenyAnonymousAuthorizationRequirement>, IAuthorizationRequirement
	{
		/// <summary>
		/// Makes a decision if authorization is allowed based on a specific requirement.
		/// </summary>
		/// <param name="context">The authorization context.</param>
		/// <param name="requirement">The requirement to evaluate.</param>
		protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, DenyAnonymousAuthorizationRequirement requirement)
		{
			throw null;
		}

		public override string ToString()
		{
			throw null;
		}

		public DenyAnonymousAuthorizationRequirement()
		{
			throw null;
		}
	}
}
