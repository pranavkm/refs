using System.Runtime.CompilerServices;
using System.Security.Claims;

namespace Microsoft.AspNetCore.Components.Authorization
{
	/// <summary>
	/// Provides information about the currently authenticated user, if any.
	/// </summary>
	public class AuthenticationState
	{
		/// <summary>
		/// Gets a <see cref="T:System.Security.Claims.ClaimsPrincipal" /> that describes the current user.
		/// </summary>
		public ClaimsPrincipal User
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Constructs an instance of <see cref="T:Microsoft.AspNetCore.Components.Authorization.AuthenticationState" />.
		/// </summary>
		/// <param name="user">A <see cref="T:System.Security.Claims.ClaimsPrincipal" /> representing the user.</param>
		public AuthenticationState(ClaimsPrincipal user)
		{
			throw null;
		}
	}
}
