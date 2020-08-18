using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Identity
{
	/// <summary>
	/// Provides default implementation of validation functions for security stamps.
	/// </summary>
	/// <typeparam name="TUser">The type encapsulating a user.</typeparam>
	public class SecurityStampValidator<TUser> : ISecurityStampValidator where TUser : class
	{
		/// <summary>
		/// The SignInManager.
		/// </summary>
		public SignInManager<TUser> SignInManager
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The <see cref="T:Microsoft.AspNetCore.Identity.SecurityStampValidatorOptions" />.
		/// </summary>
		public SecurityStampValidatorOptions Options
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The <see cref="T:Microsoft.AspNetCore.Authentication.ISystemClock" />.
		/// </summary>
		public ISystemClock Clock
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the <see cref="T:Microsoft.Extensions.Logging.ILogger" /> used to log messages.
		/// </summary>
		/// <value>
		/// The <see cref="T:Microsoft.Extensions.Logging.ILogger" /> used to log messages.
		/// </value>
		public ILogger Logger
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
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Identity.SecurityStampValidator`1" />.
		/// </summary>
		/// <param name="options">Used to access the <see cref="T:Microsoft.AspNetCore.Identity.IdentityOptions" />.</param>
		/// <param name="signInManager">The <see cref="T:Microsoft.AspNetCore.Identity.SignInManager`1" />.</param>
		/// <param name="clock">The system clock.</param>
		/// <param name="logger">The logger.</param>
		public SecurityStampValidator(IOptions<SecurityStampValidatorOptions> options, SignInManager<TUser> signInManager, ISystemClock clock, ILoggerFactory logger)
		{
			throw null;
		}

		/// <summary>
		/// Called when the security stamp has been verified.
		/// </summary>
		/// <param name="user">The user who has been verified.</param>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Authentication.Cookies.CookieValidatePrincipalContext" />.</param>
		/// <returns>A task.</returns>
		[AsyncStateMachine(typeof(SecurityStampValidator<>._003CSecurityStampVerified_003Ed__14))]
		[DebuggerStepThrough]
		protected virtual Task SecurityStampVerified(TUser user, CookieValidatePrincipalContext context)
		{
			throw null;
		}

		/// <summary>
		/// Verifies the principal's security stamp, returns the matching user if successful
		/// </summary>
		/// <param name="principal">The principal to verify.</param>
		/// <returns>The verified user or null if verification fails.</returns>
		protected virtual Task<TUser> VerifySecurityStamp(ClaimsPrincipal principal)
		{
			throw null;
		}

		/// <summary>
		/// Validates a security stamp of an identity as an asynchronous operation, and rebuilds the identity if the validation succeeds, otherwise rejects
		/// the identity.
		/// </summary>
		/// <param name="context">The context containing the <see cref="T:System.Security.Claims.ClaimsPrincipal" />
		/// and <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" /> to validate.</param>
		/// <returns>The <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous validation operation.</returns>
		[AsyncStateMachine(typeof(SecurityStampValidator<>._003CValidateAsync_003Ed__16))]
		[DebuggerStepThrough]
		public virtual Task ValidateAsync(CookieValidatePrincipalContext context)
		{
			throw null;
		}
	}
	/// <summary>
	/// Static helper class used to configure a CookieAuthenticationNotifications to validate a cookie against a user's security
	/// stamp.
	/// </summary>
	public static class SecurityStampValidator
	{
		/// <summary>
		/// Validates a principal against a user's stored security stamp.
		/// </summary>
		/// <param name="context">The context containing the <see cref="T:System.Security.Claims.ClaimsPrincipal" />
		/// and <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" /> to validate.</param>
		/// <returns>The <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous validation operation.</returns>
		public static Task ValidatePrincipalAsync(CookieValidatePrincipalContext context)
		{
			throw null;
		}

		/// <summary>
		/// Used to validate the <see cref="F:Microsoft.AspNetCore.Identity.IdentityConstants.TwoFactorUserIdScheme" /> and 
		/// <see cref="F:Microsoft.AspNetCore.Identity.IdentityConstants.TwoFactorRememberMeScheme" /> cookies against the user's 
		/// stored security stamp.
		/// </summary>
		/// <param name="context">The context containing the <see cref="T:System.Security.Claims.ClaimsPrincipal" />
		/// and <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" /> to validate.</param>
		/// <returns></returns>
		public static Task ValidateAsync<TValidator>(CookieValidatePrincipalContext context) where TValidator : ISecurityStampValidator
		{
			throw null;
		}
	}
}
