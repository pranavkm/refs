using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authorization
{
	/// <summary>
	/// Used for building policies during application startup.
	/// </summary>
	public class AuthorizationPolicyBuilder
	{
		/// <summary>
		/// Gets or sets a list of <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationRequirement" />s which must succeed for
		/// this policy to be successful.
		/// </summary>
		public IList<IAuthorizationRequirement> Requirements
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
		/// Gets or sets a list authentication schemes the <see cref="P:Microsoft.AspNetCore.Authorization.AuthorizationPolicyBuilder.Requirements" /> 
		/// are evaluated against.
		/// </summary>
		public IList<string> AuthenticationSchemes
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
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizationPolicyBuilder" />
		/// </summary>
		/// <param name="authenticationSchemes">An array of authentication schemes the policy should be evaluated against.</param>
		public AuthorizationPolicyBuilder(params string[] authenticationSchemes)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizationPolicyBuilder" />.
		/// </summary>
		/// <param name="policy">The <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizationPolicy" /> to build.</param>
		public AuthorizationPolicyBuilder(AuthorizationPolicy policy)
		{
			throw null;
		}

		/// <summary>
		/// Adds the specified authentication <paramref name="schemes" /> to the
		/// <see cref="P:Microsoft.AspNetCore.Authorization.AuthorizationPolicyBuilder.AuthenticationSchemes" /> for this instance.
		/// </summary>
		/// <param name="schemes">The schemes to add.</param>
		/// <returns>A reference to this instance after the operation has completed.</returns>
		public AuthorizationPolicyBuilder AddAuthenticationSchemes(params string[] schemes)
		{
			throw null;
		}

		/// <summary>
		/// Adds the specified <paramref name="requirements" /> to the
		/// <see cref="P:Microsoft.AspNetCore.Authorization.AuthorizationPolicyBuilder.Requirements" /> for this instance.
		/// </summary>
		/// <param name="requirements">The authorization requirements to add.</param>
		/// <returns>A reference to this instance after the operation has completed.</returns>
		public AuthorizationPolicyBuilder AddRequirements(params IAuthorizationRequirement[] requirements)
		{
			throw null;
		}

		/// <summary>
		/// Combines the specified <paramref name="policy" /> into the current instance.
		/// </summary>
		/// <param name="policy">The <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizationPolicy" /> to combine.</param>
		/// <returns>A reference to this instance after the operation has completed.</returns>
		public AuthorizationPolicyBuilder Combine(AuthorizationPolicy policy)
		{
			throw null;
		}

		/// <summary>
		/// Adds a <see cref="T:Microsoft.AspNetCore.Authorization.Infrastructure.ClaimsAuthorizationRequirement" />
		/// to the current instance.
		/// </summary>
		/// <param name="claimType">The claim type required.</param>
		/// <param name="allowedValues">Values the claim must process one or more of for evaluation to succeed.</param>
		/// <returns>A reference to this instance after the operation has completed.</returns>
		public AuthorizationPolicyBuilder RequireClaim(string claimType, params string[] allowedValues)
		{
			throw null;
		}

		/// <summary>
		/// Adds a <see cref="T:Microsoft.AspNetCore.Authorization.Infrastructure.ClaimsAuthorizationRequirement" />
		/// to the current instance.
		/// </summary>
		/// <param name="claimType">The claim type required.</param>
		/// <param name="allowedValues">Values the claim must process one or more of for evaluation to succeed.</param>
		/// <returns>A reference to this instance after the operation has completed.</returns>
		public AuthorizationPolicyBuilder RequireClaim(string claimType, IEnumerable<string> allowedValues)
		{
			throw null;
		}

		/// <summary>
		/// Adds a <see cref="T:Microsoft.AspNetCore.Authorization.Infrastructure.ClaimsAuthorizationRequirement" />
		/// to the current instance.
		/// </summary>
		/// <param name="claimType">The claim type required, with no restrictions on claim value.</param>
		/// <returns>A reference to this instance after the operation has completed.</returns>
		public AuthorizationPolicyBuilder RequireClaim(string claimType)
		{
			throw null;
		}

		/// <summary>
		/// Adds a <see cref="T:Microsoft.AspNetCore.Authorization.Infrastructure.RolesAuthorizationRequirement" />
		/// to the current instance.
		/// </summary>
		/// <param name="roles">The allowed roles.</param>
		/// <returns>A reference to this instance after the operation has completed.</returns>
		public AuthorizationPolicyBuilder RequireRole(params string[] roles)
		{
			throw null;
		}

		/// <summary>
		/// Adds a <see cref="T:Microsoft.AspNetCore.Authorization.Infrastructure.RolesAuthorizationRequirement" />
		/// to the current instance.
		/// </summary>
		/// <param name="roles">The allowed roles.</param>
		/// <returns>A reference to this instance after the operation has completed.</returns>
		public AuthorizationPolicyBuilder RequireRole(IEnumerable<string> roles)
		{
			throw null;
		}

		/// <summary>
		/// Adds a <see cref="T:Microsoft.AspNetCore.Authorization.Infrastructure.NameAuthorizationRequirement" />
		/// to the current instance.
		/// </summary>
		/// <param name="userName">The user name the current user must possess.</param>
		/// <returns>A reference to this instance after the operation has completed.</returns>
		public AuthorizationPolicyBuilder RequireUserName(string userName)
		{
			throw null;
		}

		/// <summary>
		/// Adds a <see cref="T:Microsoft.AspNetCore.Authorization.Infrastructure.DenyAnonymousAuthorizationRequirement" /> to the current instance.
		/// </summary>
		/// <returns>A reference to this instance after the operation has completed.</returns>
		public AuthorizationPolicyBuilder RequireAuthenticatedUser()
		{
			throw null;
		}

		/// <summary>
		/// Adds an <see cref="T:Microsoft.AspNetCore.Authorization.Infrastructure.AssertionRequirement" /> to the current instance.
		/// </summary>
		/// <param name="handler">The handler to evaluate during authorization.</param>
		/// <returns>A reference to this instance after the operation has completed.</returns>
		public AuthorizationPolicyBuilder RequireAssertion(Func<AuthorizationHandlerContext, bool> handler)
		{
			throw null;
		}

		/// <summary>
		/// Adds an <see cref="T:Microsoft.AspNetCore.Authorization.Infrastructure.AssertionRequirement" /> to the current instance.
		/// </summary>
		/// <param name="handler">The handler to evaluate during authorization.</param>
		/// <returns>A reference to this instance after the operation has completed.</returns>
		public AuthorizationPolicyBuilder RequireAssertion(Func<AuthorizationHandlerContext, Task<bool>> handler)
		{
			throw null;
		}

		/// <summary>
		/// Builds a new <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizationPolicy" /> from the requirements 
		/// in this instance.
		/// </summary>
		/// <returns>
		/// A new <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizationPolicy" /> built from the requirements in this instance.
		/// </returns>
		public AuthorizationPolicy Build()
		{
			throw null;
		}
	}
}
