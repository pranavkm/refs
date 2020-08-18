using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Used to determine if a handler supports SignOut.
	/// </summary>
	public interface IAuthenticationSignOutHandler : IAuthenticationHandler
	{
		/// <summary>
		/// Signout behavior.
		/// </summary>
		/// <param name="properties">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" /> that contains the extra meta-data arriving with the authentication.</param>
		/// <returns>A task.</returns>
		Task SignOutAsync(AuthenticationProperties? properties);
	}
}
