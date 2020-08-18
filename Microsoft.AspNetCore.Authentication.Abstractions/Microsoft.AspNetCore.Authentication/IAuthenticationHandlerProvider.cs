using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Provides the appropriate IAuthenticationHandler instance for the authenticationScheme and request.
	/// </summary>
	public interface IAuthenticationHandlerProvider
	{
		/// <summary>
		/// Returns the handler instance that will be used.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="authenticationScheme">The name of the authentication scheme being handled.</param>
		/// <returns>The handler instance.</returns>
		Task<IAuthenticationHandler?> GetHandlerAsync(HttpContext context, string authenticationScheme);
	}
}
