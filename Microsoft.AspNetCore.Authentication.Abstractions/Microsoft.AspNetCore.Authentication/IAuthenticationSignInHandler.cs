using System.Security.Claims;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Used to determine if a handler supports SignIn.
	/// </summary>
	public interface IAuthenticationSignInHandler : IAuthenticationSignOutHandler, IAuthenticationHandler
	{
		/// <summary>
		/// Handle sign in.
		/// </summary>
		/// <param name="user">The <see cref="T:System.Security.Claims.ClaimsPrincipal" /> user.</param>
		/// <param name="properties">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" /> that contains the extra meta-data arriving with the authentication.</param>
		/// <returns>A task.</returns>
		Task SignInAsync(ClaimsPrincipal user, AuthenticationProperties? properties);
	}
}
