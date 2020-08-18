using Microsoft.AspNetCore.Authentication;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace Microsoft.AspNetCore.Identity
{
	/// <summary>
	/// Represents login information, source and externally source principal for a user record
	/// </summary>
	public class ExternalLoginInfo : UserLoginInfo
	{
		/// <summary>
		/// Gets or sets the <see cref="T:System.Security.Claims.ClaimsPrincipal" /> associated with this login.
		/// </summary>
		/// <value>The <see cref="T:System.Security.Claims.ClaimsPrincipal" /> associated with this login.</value>
		public ClaimsPrincipal Principal
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
		/// The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationToken" />s associated with this login.
		/// </summary>
		public IEnumerable<AuthenticationToken> AuthenticationTokens
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
		/// The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" /> associated with this login.
		/// </summary>
		public AuthenticationProperties AuthenticationProperties
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
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Identity.ExternalLoginInfo" />
		/// </summary>
		/// <param name="principal">The <see cref="T:System.Security.Claims.ClaimsPrincipal" /> to associate with this login.</param>
		/// <param name="loginProvider">The provider associated with this login information.</param>
		/// <param name="providerKey">The unique identifier for this user provided by the login provider.</param>
		/// <param name="displayName">The display name for the login provider.</param>
		public ExternalLoginInfo(ClaimsPrincipal principal, string loginProvider, string providerKey, string displayName)
		{
			throw null;
		}
	}
}
