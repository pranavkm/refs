using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authorization.Infrastructure
{
	/// <summary>
	/// Implements an <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationHandler" /> and <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationRequirement" />
	/// which requires the current user name must match the specified value.
	/// </summary>
	public class NameAuthorizationRequirement : AuthorizationHandler<NameAuthorizationRequirement>, IAuthorizationRequirement
	{
		/// <summary>
		/// Gets the required name that the current user must have.
		/// </summary>
		public string RequiredName
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Constructs a new instance of <see cref="T:Microsoft.AspNetCore.Authorization.Infrastructure.NameAuthorizationRequirement" />.
		/// </summary>
		/// <param name="requiredName">The required name that the current user must have.</param>
		public NameAuthorizationRequirement(string requiredName)
		{
			throw null;
		}

		/// <summary>
		/// Makes a decision if authorization is allowed based on a specific requirement.
		/// </summary>
		/// <param name="context">The authorization context.</param>
		/// <param name="requirement">The requirement to evaluate.</param>
		protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, NameAuthorizationRequirement requirement)
		{
			throw null;
		}

		public override string ToString()
		{
			throw null;
		}
	}
}
