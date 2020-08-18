using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Created per request to handle authentication for to a particular scheme.
	/// </summary>
	public interface IAuthenticationHandler
	{
		/// <summary>
		/// The handler should initialize anything it needs from the request and scheme here.
		/// </summary>
		/// <param name="scheme">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationScheme" /> scheme.</param>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> context.</param>
		/// <returns></returns>
		Task InitializeAsync(AuthenticationScheme scheme, HttpContext context);

		/// <summary>
		/// Authentication behavior.
		/// </summary>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticateResult" /> result.</returns>
		Task<AuthenticateResult> AuthenticateAsync();

		/// <summary>
		/// Challenge behavior.
		/// </summary>
		/// <param name="properties">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" /> that contains the extra meta-data arriving with the authentication.</param>
		/// <returns>A task.</returns>
		Task ChallengeAsync(AuthenticationProperties? properties);

		/// <summary>
		/// Forbid behavior.
		/// </summary>
		/// <param name="properties">The <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" /> that contains the extra meta-data arriving with the authentication.</param>
		/// <returns>A task.</returns>
		Task ForbidAsync(AuthenticationProperties? properties);
	}
}
