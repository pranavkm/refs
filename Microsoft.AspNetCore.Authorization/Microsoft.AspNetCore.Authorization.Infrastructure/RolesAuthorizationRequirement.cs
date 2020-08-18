using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authorization.Infrastructure
{
	/// <summary>
	/// Implements an <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationHandler" /> and <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationRequirement" />
	/// which requires at least one role claim whose value must be any of the allowed roles.
	/// </summary>
	public class RolesAuthorizationRequirement : AuthorizationHandler<RolesAuthorizationRequirement>, IAuthorizationRequirement
	{
		/// <summary>
		/// Gets the collection of allowed roles.
		/// </summary>
		public IEnumerable<string> AllowedRoles
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Authorization.Infrastructure.RolesAuthorizationRequirement" />.
		/// </summary>
		/// <param name="allowedRoles">A collection of allowed roles.</param>
		public RolesAuthorizationRequirement(IEnumerable<string> allowedRoles)
		{
			throw null;
		}

		/// <summary>
		/// Makes a decision if authorization is allowed based on a specific requirement.
		/// </summary>
		/// <param name="context">The authorization context.</param>
		/// <param name="requirement">The requirement to evaluate.</param>
		protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, RolesAuthorizationRequirement requirement)
		{
			throw null;
		}

		public override string ToString()
		{
			throw null;
		}
	}
}
