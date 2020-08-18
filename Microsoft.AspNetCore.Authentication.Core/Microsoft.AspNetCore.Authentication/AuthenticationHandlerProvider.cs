using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authentication
{
	/// <summary>
	/// Implementation of <see cref="T:Microsoft.AspNetCore.Authentication.IAuthenticationHandlerProvider" />.
	/// </summary>
	public class AuthenticationHandlerProvider : IAuthenticationHandlerProvider
	{
		/// <summary>
		/// The <see cref="T:Microsoft.AspNetCore.Authentication.IAuthenticationHandlerProvider" />.
		/// </summary>
		public IAuthenticationSchemeProvider Schemes
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="schemes">The <see cref="T:Microsoft.AspNetCore.Authentication.IAuthenticationHandlerProvider" />.</param>
		public AuthenticationHandlerProvider(IAuthenticationSchemeProvider schemes)
		{
			throw null;
		}

		/// <summary>
		/// Returns the handler instance that will be used.
		/// </summary>
		/// <param name="context">The context.</param>
		/// <param name="authenticationScheme">The name of the authentication scheme being handled.</param>
		/// <returns>The handler instance.</returns>
		[AsyncStateMachine(typeof(_003CGetHandlerAsync_003Ed__5))]
		[DebuggerStepThrough]
		public Task<IAuthenticationHandler?> GetHandlerAsync(HttpContext context, string authenticationScheme)
		{
			throw null;
		}
	}
}
