using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Builder.Extensions
{
	/// <summary>
	/// Represents a middleware that runs a sub-request pipeline when a given predicate is matched.
	/// </summary>
	public class MapWhenMiddleware
	{
		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Builder.Extensions.MapWhenMiddleware" />.
		/// </summary>
		/// <param name="next">The delegate representing the next middleware in the request pipeline.</param>
		/// <param name="options">The middleware options.</param>
		public MapWhenMiddleware(RequestDelegate next, MapWhenOptions options)
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
