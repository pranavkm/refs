using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Identity
{
	/// <summary>
	/// Provides the APIs for user sign in.
	/// </summary>
	/// <typeparam name="TUser">The type encapsulating a user.</typeparam>
	public class SignInManager<TUser> where TUser : class
	{
		internal class TwoFactorAuthenticationInfo
		{
			public string UserId
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

			public string LoginProvider
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

			public TwoFactorAuthenticationInfo()
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the <see cref="T:Microsoft.Extensions.Logging.ILogger" /> used to log messages from the manager.
		/// </summary>
		/// <value>
		/// The <see cref="T:Microsoft.Extensions.Logging.ILogger" /> used to log messages from the manager.
		/// </value>
		public virtual ILogger Logger
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
		/// The <see cref="T:Microsoft.AspNetCore.Identity.UserManager`1" /> used.
		/// </summary>
		public UserManager<TUser> UserManager
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
		/// The <see cref="T:Microsoft.AspNetCore.Identity.IUserClaimsPrincipalFactory`1" /> used.
		/// </summary>
		public IUserClaimsPrincipalFactory<TUser> ClaimsFactory
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
		/// The <see cref="T:Microsoft.AspNetCore.Identity.IdentityOptions" /> used.
		/// </summary>
		public IdentityOptions Options
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
		/// The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> used.
		/// </summary>
		public HttpContext Context
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Identity.SignInManager`1" />.
		/// </summary>
		/// <param name="userManager">An instance of <see cref="P:Microsoft.AspNetCore.Identity.SignInManager`1.UserManager" /> used to retrieve users from and persist users.</param>
		/// <param name="contextAccessor">The accessor used to access the <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />.</param>
		/// <param name="claimsFactory">The factory to use to create claims principals for a user.</param>
		/// <param name="optionsAccessor">The accessor used to access the <see cref="T:Microsoft.AspNetCore.Identity.IdentityOptions" />.</param>
		/// <param name="logger">The logger used to log messages, warnings and errors.</param>
		/// <param name="schemes">The scheme provider that is used enumerate the authentication schemes.</param>
		/// <param name="confirmation">The <see cref="T:Microsoft.AspNetCore.Identity.IUserConfirmation`1" /> used check whether a user account is confirmed.</param>
		public SignInManager(UserManager<TUser> userManager, IHttpContextAccessor contextAccessor, IUserClaimsPrincipalFactory<TUser> claimsFactory, IOptions<IdentityOptions> optionsAccessor, ILogger<SignInManager<TUser>> logger, IAuthenticationSchemeProvider schemes, IUserConfirmation<TUser> confirmation)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:System.Security.Claims.ClaimsPrincipal" /> for the specified <paramref name="user" />, as an asynchronous operation.
		/// </summary>
		/// <param name="user">The user to create a <see cref="T:System.Security.Claims.ClaimsPrincipal" /> for.</param>
		/// <returns>The task object representing the asynchronous operation, containing the ClaimsPrincipal for the specified user.</returns>
		[AsyncStateMachine(typeof(SignInManager<>._003CCreateUserPrincipalAsync_003Ed__26))]
		[DebuggerStepThrough]
		public virtual Task<ClaimsPrincipal> CreateUserPrincipalAsync(TUser user)
		{
			throw null;
		}

		/// <summary>
		/// Returns true if the principal has an identity with the application cookie identity
		/// </summary>
		/// <param name="principal">The <see cref="T:System.Security.Claims.ClaimsPrincipal" /> instance.</param>
		/// <returns>True if the user is logged in with identity.</returns>
		public virtual bool IsSignedIn(ClaimsPrincipal principal)
		{
			throw null;
		}

		/// <summary>
		/// Returns a flag indicating whether the specified user can sign in.
		/// </summary>
		/// <param name="user">The user whose sign-in status should be returned.</param>
		/// <returns>
		/// The task object representing the asynchronous operation, containing a flag that is true
		/// if the specified user can sign-in, otherwise false.
		/// </returns>
		[AsyncStateMachine(typeof(SignInManager<>._003CCanSignInAsync_003Ed__28))]
		[DebuggerStepThrough]
		public virtual Task<bool> CanSignInAsync(TUser user)
		{
			throw null;
		}

		/// <summary>
		/// Signs in the specified <paramref name="user" />, whilst preserving the existing
		/// AuthenticationProperties of the current signed-in user like rememberMe, as an asynchronous operation.
		/// </summary>
		/// <param name="user">The user to sign-in.</param>
		/// <returns>The task object representing the asynchronous operation.</returns>
		[AsyncStateMachine(typeof(SignInManager<>._003CRefreshSignInAsync_003Ed__29))]
		[DebuggerStepThrough]
		public virtual Task RefreshSignInAsync(TUser user)
		{
			throw null;
		}

		/// <summary>
		/// Signs in the specified <paramref name="user" />.
		/// </summary>
		/// <param name="user">The user to sign-in.</param>
		/// <param name="isPersistent">Flag indicating whether the sign-in cookie should persist after the browser is closed.</param>
		/// <param name="authenticationMethod">Name of the method used to authenticate the user.</param>
		/// <returns>The task object representing the asynchronous operation.</returns>
		public virtual Task SignInAsync(TUser user, bool isPersistent, string authenticationMethod = null)
		{
			throw null;
		}

		/// <summary>
		/// Signs in the specified <paramref name="user" />.
		/// </summary>
		/// <param name="user">The user to sign-in.</param>
		/// <param name="authenticationProperties">Properties applied to the login and authentication cookie.</param>
		/// <param name="authenticationMethod">Name of the method used to authenticate the user.</param>
		/// <returns>The task object representing the asynchronous operation.</returns>
		public virtual Task SignInAsync(TUser user, AuthenticationProperties authenticationProperties, string authenticationMethod = null)
		{
			throw null;
		}

		/// <summary>
		/// Signs in the specified <paramref name="user" />.
		/// </summary>
		/// <param name="user">The user to sign-in.</param>
		/// <param name="isPersistent">Flag indicating whether the sign-in cookie should persist after the browser is closed.</param>
		/// <param name="additionalClaims">Additional claims that will be stored in the cookie.</param>
		/// <returns>The task object representing the asynchronous operation.</returns>
		public virtual Task SignInWithClaimsAsync(TUser user, bool isPersistent, IEnumerable<Claim> additionalClaims)
		{
			throw null;
		}

		/// <summary>
		/// Signs in the specified <paramref name="user" />.
		/// </summary>
		/// <param name="user">The user to sign-in.</param>
		/// <param name="authenticationProperties">Properties applied to the login and authentication cookie.</param>
		/// <param name="additionalClaims">Additional claims that will be stored in the cookie.</param>
		/// <returns>The task object representing the asynchronous operation.</returns>
		[AsyncStateMachine(typeof(SignInManager<>._003CSignInWithClaimsAsync_003Ed__33))]
		[DebuggerStepThrough]
		public virtual Task SignInWithClaimsAsync(TUser user, AuthenticationProperties authenticationProperties, IEnumerable<Claim> additionalClaims)
		{
			throw null;
		}

		/// <summary>
		/// Signs the current user out of the application.
		/// </summary>
		[AsyncStateMachine(typeof(SignInManager<>._003CSignOutAsync_003Ed__34))]
		[DebuggerStepThrough]
		public virtual Task SignOutAsync()
		{
			throw null;
		}

		/// <summary>
		/// Validates the security stamp for the specified <paramref name="principal" /> against
		/// the persisted stamp for the current user, as an asynchronous operation.
		/// </summary>
		/// <param name="principal">The principal whose stamp should be validated.</param>
		/// <returns>The task object representing the asynchronous operation. The task will contain the <typeparamref name="TUser" />
		/// if the stamp matches the persisted value, otherwise it will return false.</returns>
		[AsyncStateMachine(typeof(SignInManager<>._003CValidateSecurityStampAsync_003Ed__35))]
		[DebuggerStepThrough]
		public virtual Task<TUser> ValidateSecurityStampAsync(ClaimsPrincipal principal)
		{
			throw null;
		}

		/// <summary>
		/// Validates the security stamp for the specified <paramref name="principal" /> from one of
		/// the two factor principals (remember client or user id) against
		/// the persisted stamp for the current user, as an asynchronous operation.
		/// </summary>
		/// <param name="principal">The principal whose stamp should be validated.</param>
		/// <returns>The task object representing the asynchronous operation. The task will contain the <typeparamref name="TUser" />
		/// if the stamp matches the persisted value, otherwise it will return false.</returns>
		[AsyncStateMachine(typeof(SignInManager<>._003CValidateTwoFactorSecurityStampAsync_003Ed__36))]
		[DebuggerStepThrough]
		public virtual Task<TUser> ValidateTwoFactorSecurityStampAsync(ClaimsPrincipal principal)
		{
			throw null;
		}

		/// <summary>
		/// Validates the security stamp for the specified <paramref name="user" />.  If no user is specified, or if the store
		/// does not support security stamps, validation is considered successful.
		/// </summary>
		/// <param name="user">The user whose stamp should be validated.</param>
		/// <param name="securityStamp">The expected security stamp value.</param>
		/// <returns>The result of the validation.</returns>
		[AsyncStateMachine(typeof(SignInManager<>._003CValidateSecurityStampAsync_003Ed__37))]
		[DebuggerStepThrough]
		public virtual Task<bool> ValidateSecurityStampAsync(TUser user, string securityStamp)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to sign in the specified <paramref name="user" /> and <paramref name="password" /> combination
		/// as an asynchronous operation.
		/// </summary>
		/// <param name="user">The user to sign in.</param>
		/// <param name="password">The password to attempt to sign in with.</param>
		/// <param name="isPersistent">Flag indicating whether the sign-in cookie should persist after the browser is closed.</param>
		/// <param name="lockoutOnFailure">Flag indicating if the user account should be locked if the sign in fails.</param>
		/// <returns>The task object representing the asynchronous operation containing the <see name="SignInResult" />
		/// for the sign-in attempt.</returns>
		[AsyncStateMachine(typeof(SignInManager<>._003CPasswordSignInAsync_003Ed__38))]
		[DebuggerStepThrough]
		public virtual Task<SignInResult> PasswordSignInAsync(TUser user, string password, bool isPersistent, bool lockoutOnFailure)
		{
			throw null;
		}

		/// <summary>
		/// Attempts to sign in the specified <paramref name="userName" /> and <paramref name="password" /> combination
		/// as an asynchronous operation.
		/// </summary>
		/// <param name="userName">The user name to sign in.</param>
		/// <param name="password">The password to attempt to sign in with.</param>
		/// <param name="isPersistent">Flag indicating whether the sign-in cookie should persist after the browser is closed.</param>
		/// <param name="lockoutOnFailure">Flag indicating if the user account should be locked if the sign in fails.</param>
		/// <returns>The task object representing the asynchronous operation containing the <see name="SignInResult" />
		/// for the sign-in attempt.</returns>
		[AsyncStateMachine(typeof(SignInManager<>._003CPasswordSignInAsync_003Ed__39))]
		[DebuggerStepThrough]
		public virtual Task<SignInResult> PasswordSignInAsync(string userName, string password, bool isPersistent, bool lockoutOnFailure)
		{
			throw null;
		}

		/// <summary>
		/// Attempts a password sign in for a user.
		/// </summary>
		/// <param name="user">The user to sign in.</param>
		/// <param name="password">The password to attempt to sign in with.</param>
		/// <param name="lockoutOnFailure">Flag indicating if the user account should be locked if the sign in fails.</param>
		/// <returns>The task object representing the asynchronous operation containing the <see name="SignInResult" />
		/// for the sign-in attempt.</returns>
		/// <returns></returns>
		[AsyncStateMachine(typeof(SignInManager<>._003CCheckPasswordSignInAsync_003Ed__40))]
		[DebuggerStepThrough]
		public virtual Task<SignInResult> CheckPasswordSignInAsync(TUser user, string password, bool lockoutOnFailure)
		{
			throw null;
		}

		/// <summary>
		/// Returns a flag indicating if the current client browser has been remembered by two factor authentication
		/// for the user attempting to login, as an asynchronous operation.
		/// </summary>
		/// <param name="user">The user attempting to login.</param>
		/// <returns>
		/// The task object representing the asynchronous operation containing true if the browser has been remembered
		/// for the current user.
		/// </returns>
		[AsyncStateMachine(typeof(SignInManager<>._003CIsTwoFactorClientRememberedAsync_003Ed__41))]
		[DebuggerStepThrough]
		public virtual Task<bool> IsTwoFactorClientRememberedAsync(TUser user)
		{
			throw null;
		}

		/// <summary>
		/// Sets a flag on the browser to indicate the user has selected "Remember this browser" for two factor authentication purposes,
		/// as an asynchronous operation.
		/// </summary>
		/// <param name="user">The user who choose "remember this browser".</param>
		/// <returns>The task object representing the asynchronous operation.</returns>
		[AsyncStateMachine(typeof(SignInManager<>._003CRememberTwoFactorClientAsync_003Ed__42))]
		[DebuggerStepThrough]
		public virtual Task RememberTwoFactorClientAsync(TUser user)
		{
			throw null;
		}

		/// <summary>
		/// Clears the "Remember this browser flag" from the current browser, as an asynchronous operation.
		/// </summary>
		/// <returns>The task object representing the asynchronous operation.</returns>
		public virtual Task ForgetTwoFactorClientAsync()
		{
			throw null;
		}

		/// <summary>
		/// Signs in the user without two factor authentication using a two factor recovery code.
		/// </summary>
		/// <param name="recoveryCode">The two factor recovery code.</param>
		/// <returns></returns>
		[AsyncStateMachine(typeof(SignInManager<>._003CTwoFactorRecoveryCodeSignInAsync_003Ed__44))]
		[DebuggerStepThrough]
		public virtual Task<SignInResult> TwoFactorRecoveryCodeSignInAsync(string recoveryCode)
		{
			throw null;
		}

		/// <summary>
		/// Validates the sign in code from an authenticator app and creates and signs in the user, as an asynchronous operation.
		/// </summary>
		/// <param name="code">The two factor authentication code to validate.</param>
		/// <param name="isPersistent">Flag indicating whether the sign-in cookie should persist after the browser is closed.</param>
		/// <param name="rememberClient">Flag indicating whether the current browser should be remember, suppressing all further 
		/// two factor authentication prompts.</param>
		/// <returns>The task object representing the asynchronous operation containing the <see name="SignInResult" />
		/// for the sign-in attempt.</returns>
		[AsyncStateMachine(typeof(SignInManager<>._003CTwoFactorAuthenticatorSignInAsync_003Ed__46))]
		[DebuggerStepThrough]
		public virtual Task<SignInResult> TwoFactorAuthenticatorSignInAsync(string code, bool isPersistent, bool rememberClient)
		{
			throw null;
		}

		/// <summary>
		/// Validates the two factor sign in code and creates and signs in the user, as an asynchronous operation.
		/// </summary>
		/// <param name="provider">The two factor authentication provider to validate the code against.</param>
		/// <param name="code">The two factor authentication code to validate.</param>
		/// <param name="isPersistent">Flag indicating whether the sign-in cookie should persist after the browser is closed.</param>
		/// <param name="rememberClient">Flag indicating whether the current browser should be remember, suppressing all further 
		/// two factor authentication prompts.</param>
		/// <returns>The task object representing the asynchronous operation containing the <see name="SignInResult" />
		/// for the sign-in attempt.</returns>
		[AsyncStateMachine(typeof(SignInManager<>._003CTwoFactorSignInAsync_003Ed__47))]
		[DebuggerStepThrough]
		public virtual Task<SignInResult> TwoFactorSignInAsync(string provider, string code, bool isPersistent, bool rememberClient)
		{
			throw null;
		}

		/// <summary>
		/// Gets the <typeparamref name="TUser" /> for the current two factor authentication login, as an asynchronous operation.
		/// </summary>
		/// <returns>The task object representing the asynchronous operation containing the <typeparamref name="TUser" />
		/// for the sign-in attempt.</returns>
		[AsyncStateMachine(typeof(SignInManager<>._003CGetTwoFactorAuthenticationUserAsync_003Ed__48))]
		[DebuggerStepThrough]
		public virtual Task<TUser> GetTwoFactorAuthenticationUserAsync()
		{
			throw null;
		}

		/// <summary>
		/// Signs in a user via a previously registered third party login, as an asynchronous operation.
		/// </summary>
		/// <param name="loginProvider">The login provider to use.</param>
		/// <param name="providerKey">The unique provider identifier for the user.</param>
		/// <param name="isPersistent">Flag indicating whether the sign-in cookie should persist after the browser is closed.</param>
		/// <returns>The task object representing the asynchronous operation containing the <see name="SignInResult" />
		/// for the sign-in attempt.</returns>
		public virtual Task<SignInResult> ExternalLoginSignInAsync(string loginProvider, string providerKey, bool isPersistent)
		{
			throw null;
		}

		/// <summary>
		/// Signs in a user via a previously registered third party login, as an asynchronous operation.
		/// </summary>
		/// <param name="loginProvider">The login provider to use.</param>
		/// <param name="providerKey">The unique provider identifier for the user.</param>
		/// <param name="isPersistent">Flag indicating whether the sign-in cookie should persist after the browser is closed.</param>
		/// <param name="bypassTwoFactor">Flag indicating whether to bypass two factor authentication.</param>
		/// <returns>The task object representing the asynchronous operation containing the <see name="SignInResult" />
		/// for the sign-in attempt.</returns>
		[AsyncStateMachine(typeof(SignInManager<>._003CExternalLoginSignInAsync_003Ed__50))]
		[DebuggerStepThrough]
		public virtual Task<SignInResult> ExternalLoginSignInAsync(string loginProvider, string providerKey, bool isPersistent, bool bypassTwoFactor)
		{
			throw null;
		}

		/// <summary>
		/// Gets a collection of <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationScheme" />s for the known external login providers.		
		/// </summary>		
		/// <returns>A collection of <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationScheme" />s for the known external login providers.</returns>		
		[AsyncStateMachine(typeof(SignInManager<>._003CGetExternalAuthenticationSchemesAsync_003Ed__51))]
		[DebuggerStepThrough]
		public virtual Task<IEnumerable<AuthenticationScheme>> GetExternalAuthenticationSchemesAsync()
		{
			throw null;
		}

		/// <summary>
		/// Gets the external login information for the current login, as an asynchronous operation.
		/// </summary>
		/// <param name="expectedXsrf">Flag indication whether a Cross Site Request Forgery token was expected in the current request.</param>
		/// <returns>The task object representing the asynchronous operation containing the <see name="ExternalLoginInfo" />
		/// for the sign-in attempt.</returns>
		[AsyncStateMachine(typeof(SignInManager<>._003CGetExternalLoginInfoAsync_003Ed__52))]
		[DebuggerStepThrough]
		public virtual Task<ExternalLoginInfo> GetExternalLoginInfoAsync(string expectedXsrf = null)
		{
			throw null;
		}

		/// <summary>
		/// Stores any authentication tokens found in the external authentication cookie into the associated user.
		/// </summary>
		/// <param name="externalLogin">The information from the external login provider.</param>
		/// <returns>The <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous operation, containing the <see cref="T:Microsoft.AspNetCore.Identity.IdentityResult" /> of the operation.</returns>
		[AsyncStateMachine(typeof(SignInManager<>._003CUpdateExternalAuthenticationTokensAsync_003Ed__53))]
		[DebuggerStepThrough]
		public virtual Task<IdentityResult> UpdateExternalAuthenticationTokensAsync(ExternalLoginInfo externalLogin)
		{
			throw null;
		}

		/// <summary>
		/// Configures the redirect URL and user identifier for the specified external login <paramref name="provider" />.
		/// </summary>
		/// <param name="provider">The provider to configure.</param>
		/// <param name="redirectUrl">The external login URL users should be redirected to during the login flow.</param>
		/// <param name="userId">The current user's identifier, which will be used to provide CSRF protection.</param>
		/// <returns>A configured <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" />.</returns>
		public virtual AuthenticationProperties ConfigureExternalAuthenticationProperties(string provider, string redirectUrl, string userId = null)
		{
			throw null;
		}

		/// <summary>
		/// Creates a claims principal for the specified 2fa information.
		/// </summary>
		/// <param name="userId">The user whose is logging in via 2fa.</param>
		/// <param name="loginProvider">The 2fa provider.</param>
		/// <returns>A <see cref="T:System.Security.Claims.ClaimsPrincipal" /> containing the user 2fa information.</returns>
		internal ClaimsPrincipal StoreTwoFactorInfo(string userId, string loginProvider)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(SignInManager<>._003CStoreRememberClient_003Ed__56))]
		[DebuggerStepThrough]
		internal Task<ClaimsPrincipal> StoreRememberClient(TUser user)
		{
			throw null;
		}

		/// <summary>
		/// Signs in the specified <paramref name="user" /> if <paramref name="bypassTwoFactor" /> is set to false.
		/// Otherwise stores the <paramref name="user" /> for use after a two factor check.
		/// </summary>
		/// <param name="user"></param>
		/// <param name="isPersistent">Flag indicating whether the sign-in cookie should persist after the browser is closed.</param>
		/// <param name="loginProvider">The login provider to use. Default is null</param>
		/// <param name="bypassTwoFactor">Flag indicating whether to bypass two factor authentication. Default is false</param>
		/// <returns>Returns a <see cref="T:Microsoft.AspNetCore.Identity.SignInResult" /></returns>
		[AsyncStateMachine(typeof(SignInManager<>._003CSignInOrTwoFactorAsync_003Ed__59))]
		[DebuggerStepThrough]
		protected virtual Task<SignInResult> SignInOrTwoFactorAsync(TUser user, bool isPersistent, string loginProvider = null, bool bypassTwoFactor = false)
		{
			throw null;
		}

		/// <summary>
		/// Used to determine if a user is considered locked out.
		/// </summary>
		/// <param name="user">The user.</param>
		/// <returns>Whether a user is considered locked out.</returns>
		[AsyncStateMachine(typeof(SignInManager<>._003CIsLockedOut_003Ed__61))]
		[DebuggerStepThrough]
		protected virtual Task<bool> IsLockedOut(TUser user)
		{
			throw null;
		}

		/// <summary>
		/// Returns a locked out SignInResult.
		/// </summary>
		/// <param name="user">The user.</param>
		/// <returns>A locked out SignInResult</returns>
		protected virtual Task<SignInResult> LockedOut(TUser user)
		{
			throw null;
		}

		/// <summary>
		/// Used to ensure that a user is allowed to sign in.
		/// </summary>
		/// <param name="user">The user</param>
		/// <returns>Null if the user should be allowed to sign in, otherwise the SignInResult why they should be denied.</returns>
		[AsyncStateMachine(typeof(SignInManager<>._003CPreSignInCheck_003Ed__63))]
		[DebuggerStepThrough]
		protected virtual Task<SignInResult> PreSignInCheck(TUser user)
		{
			throw null;
		}

		/// <summary>
		/// Used to reset a user's lockout count.
		/// </summary>
		/// <param name="user">The user</param>
		/// <returns>The <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous operation, containing the <see cref="T:Microsoft.AspNetCore.Identity.IdentityResult" /> of the operation.</returns>
		protected virtual Task ResetLockout(TUser user)
		{
			throw null;
		}
	}
}
