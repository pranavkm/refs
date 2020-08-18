using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Authorization.Policy
{
	public class AuthorizationMiddlewareResultHandler : IAuthorizationMiddlewareResultHandler
	{
		[AsyncStateMachine(typeof(_003CHandleAsync_003Ed__0))]
		[DebuggerStepThrough]
		public Task HandleAsync(RequestDelegate next, HttpContext context, AuthorizationPolicy policy, PolicyAuthorizationResult authorizeResult)
		{
			throw null;
		}

		public AuthorizationMiddlewareResultHandler()
		{
			throw null;
		}
	}
}
