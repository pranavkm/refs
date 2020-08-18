using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Builder.Extensions
{
	/// <summary>
	/// Represents a middleware that extracts the specified path base from request path and postpend it to the request path base.
	/// </summary>
	public class UsePathBaseMiddleware
	{
		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Builder.Extensions.UsePathBaseMiddleware" />.
		/// </summary>
		/// <param name="next">The delegate representing the next middleware in the request pipeline.</param>
		/// <param name="pathBase">The path base to extract.</param>
		public UsePathBaseMiddleware(RequestDelegate next, PathString pathBase)
		{
			throw null;
		}

		/// <summary>
		/// Executes the middleware.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> for the current request.</param>
		/// <returns>A task that represents the execution of this middleware.</returns>
		[AsyncStateMachine(typeof(_003CInvoke_003Ed__3))]
		[DebuggerStepThrough]
		public Task Invoke(HttpContext context)
		{
			throw null;
		}
	}
}
