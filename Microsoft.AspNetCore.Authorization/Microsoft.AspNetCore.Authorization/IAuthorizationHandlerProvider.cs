using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authorization
{
	/// <summary>
	/// A type which can provide the <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationHandler" />s for an authorization request.
	/// </summary>
	public interface IAuthorizationHandlerProvider
	{
		/// <summary>
		/// Return the handlers that will be called for the authorization request.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizationHandlerContext" />.</param>
		/// <returns>The list of handlers.</returns>
		Task<IEnumerable<IAuthorizationHandler>> GetHandlersAsync(AuthorizationHandlerContext context);
	}
}
