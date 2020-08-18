using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Implements <see cref="T:Microsoft.AspNetCore.Authentication.IAuthenticationService" />.
	/// </summary>
	public class AuthenticationService : IAuthenticationService
	{
		/// <summary>
		/// Used to lookup AuthenticationSchemes.
		/// </summary>
		public IAuthenticationSchemeProvider Schemes
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Used to resolve IAuthenticationHandler instances.
		/// </summary>
		public IAuthenticationHandlerProvider Handlers
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Used for claims transformation.
		/// </summary>
		public IClaimsTransformation Transform
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationOptions" />.
		/// </summary>
		public AuthenticationOptions Options
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="schemes">The <see cref="T:Microsoft.AspNetCore.Authentication.IAuthenticationSchemeProvider" />.</param>
		/// <param name="handlers">The <see cref="T:Microsoft.AspNetCore.Authentication.IAuthenticationHandlerProvider" />.</param>
		/// <param name="transform">The <see cref="T:Microsoft.AspNetCore.Authentication.IClaimsTransformation" />.</param>
		/// <param name="options">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationOptions" />.</param>
		public AuthenticationService(IAuthenticationSchemeProvider schemes, IAuthenticationHandlerProvider handlers, IClaimsTransformation transform, IOptions<AuthenticationOptions> options)
		{
			throw null;
		}

		/// <summary>
		/// Authenticate for the specified authentication scheme.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />.</param>
		/// <param name="scheme">The name of the authentication scheme.</param>
		/// <returns>The result.</returns>
		[AsyncStateMachine(typeof(_003CAuthenticateAsync_003Ed__14))]
		[DebuggerStepThrough]
		public virtual Task<AuthenticateResult> AuthenticateAsync(HttpContext context, string? scheme)
		{
			throw null;
		}

		/// <summary>
		/// Challenge the specified authentication scheme.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />.</param>
		/// <param name="scheme">The name of the authentication scheme.</param>
		/// <param name="properties">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" />.</param>
		/// <returns>A task.</returns>
		[AsyncStateMachine(typeof(_003CChallengeAsync_003Ed__15))]
		[DebuggerStepThrough]
		public virtual Task ChallengeAsync(HttpContext context, string? scheme, AuthenticationProperties? properties)
		{
			throw null;
		}

		/// <summary>
		/// Forbid the specified authentication scheme.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />.</param>
		/// <param name="scheme">The name of the authentication scheme.</param>
		/// <param name="properties">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" />.</param>
		/// <returns>A task.</returns>
		[AsyncStateMachine(typeof(_003CForbidAsync_003Ed__16))]
		[DebuggerStepThrough]
		public virtual Task ForbidAsync(HttpContext context, string? scheme, AuthenticationProperties? properties)
		{
			throw null;
		}

		/// <summary>
		/// Sign a principal in for the specified authentication scheme.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />.</param>
		/// <param name="scheme">The name of the authentication scheme.</param>
		/// <param name="principal">The <see cref="T:System.Security.Claims.ClaimsPrincipal" /> to sign in.</param>
		/// <param name="properties">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" />.</param>
		/// <returns>A task.</returns>
		[AsyncStateMachine(typeof(_003CSignInAsync_003Ed__17))]
		[DebuggerStepThrough]
		public virtual Task SignInAsync(HttpContext context, string? scheme, ClaimsPrincipal principal, AuthenticationProperties? properties)
		{
			throw null;
		}

		/// <summary>
		/// Sign out the specified authentication scheme.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />.</param>
		/// <param name="scheme">The name of the authentication scheme.</param>
		/// <param name="properties">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" />.</param>
		/// <returns>A task.</returns>
		[AsyncStateMachine(typeof(_003CSignOutAsync_003Ed__18))]
		[DebuggerStepThrough]
		public virtual Task SignOutAsync(HttpContext context, string? scheme, AuthenticationProperties? properties)
		{
			throw null;
		}
	}
}
