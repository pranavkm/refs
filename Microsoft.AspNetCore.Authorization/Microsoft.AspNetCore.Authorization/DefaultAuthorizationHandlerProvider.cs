using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authorization
{
	/// <summary>
	/// The default implementation of a handler provider,
	/// which provides the <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationHandler" />s for an authorization request.
	/// </summary>
	public class DefaultAuthorizationHandlerProvider : IAuthorizationHandlerProvider
	{
		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Authorization.DefaultAuthorizationHandlerProvider" />.
		/// </summary>
		/// <param name="handlers">The <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationHandler" />s.</param>
		public DefaultAuthorizationHandlerProvider(IEnumerable<IAuthorizationHandler> handlers)
		{
			throw null;
		}

		public Task<IEnumerable<IAuthorizationHandler>> GetHandlersAsync(AuthorizationHandlerContext context)
		{
			throw null;
		}
	}
}
