using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authorization.Infrastructure
{
	/// <summary>
	/// Infrastructure class which allows an <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationRequirement" /> to
	/// be its own <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizationHandler" />.
	/// </summary>
	public class PassThroughAuthorizationHandler : IAuthorizationHandler
	{
		/// <summary>
		/// Makes a decision if authorization is allowed.
		/// </summary>
		/// <param name="context">The authorization context.</param>
		[AsyncStateMachine(typeof(_003CHandleAsync_003Ed__0))]
		[DebuggerStepThrough]
		public Task HandleAsync(AuthorizationHandlerContext context)
		{
			throw null;
		}

		public PassThroughAuthorizationHandler()
		{
			throw null;
		}
	}
}
