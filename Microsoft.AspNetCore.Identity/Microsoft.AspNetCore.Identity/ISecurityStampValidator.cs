using Microsoft.AspNetCore.Authentication.Cookies;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Identity
{
	/// <summary>
	/// Provides an abstraction for a validating a security stamp of an incoming identity, and regenerating or rejecting the 
	/// identity based on the validation result.
	/// </summary>
	public interface ISecurityStampValidator
	{
		/// <summary>
		/// Validates a security stamp of an identity as an asynchronous operation, and rebuilds the identity if the validation succeeds, otherwise rejects
		/// the identity.
		/// </summary>
		/// <param name="context">The context containing the <see cref="T:System.Security.Claims.ClaimsPrincipal" />
		/// and <see cref="T:Microsoft.AspNetCore.Authentication.AuthenticationProperties" /> to validate.</param>
		/// <returns>The <see cref="T:System.Threading.Tasks.Task" /> that represents the asynchronous validation operation.</returns>
		Task ValidateAsync(CookieValidatePrincipalContext context);
	}
}
