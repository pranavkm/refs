using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authorization.Infrastructure
{
	/// <summary>
	/// Implements an <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationHandler" /> and <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationRequirement" />
	/// which requires at least one instance of the specified claim type, and, if allowed values are specified, 
	/// the claim value must be any of the allowed values.
	/// </summary>
	public class ClaimsAuthorizationRequirement : AuthorizationHandler<ClaimsAuthorizationRequirement>, IAuthorizationRequirement
	{
		/// <summary>
		/// Gets the claim type that must be present.
		/// </summary>
		public string ClaimType
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the optional list of claim values, which, if present, 
		/// the claim must match.
		/// </summary>
		public IEnumerable<string>? AllowedValues
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Authorization.Infrastructure.ClaimsAuthorizationRequirement" />.
		/// </summary>
		/// <param name="claimType">The claim type that must be present.</param>
		/// <param name="allowedValues">The optional list of claim values, which, if present, 
		/// the claim must match.</param>
		public ClaimsAuthorizationRequirement(string claimType, IEnumerable<string>? allowedValues)
		{
			throw null;
		}

		/// <summary>
		/// Makes a decision if authorization is allowed based on the claims requirements specified.
		/// </summary>
		/// <param name="context">The authorization context.</param>
		/// <param name="requirement">The requirement to evaluate.</param>
		protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ClaimsAuthorizationRequirement requirement)
		{
			throw null;
		}

		public override string ToString()
		{
			throw null;
		}
	}
}
