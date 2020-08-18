using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Builder.Extensions
{
	/// <summary>
	/// Represents a middleware that maps a request path to a sub-request pipeline.
	/// </summary>
	public class MapMiddleware
	{
		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Builder.Extensions.MapMiddleware" />.
		/// </summary>
		/// <param name="next">The delegate representing the next middleware in the request pipeline.</param>
		/// <param name="options">The middleware options.</param>
		public MapMiddleware(RequestDelegate next, MapOptions options)
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
