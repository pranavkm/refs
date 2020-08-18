using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// Defines middleware that can be added to the application's request pipeline.
	/// </summary>
	public interface IMiddleware
	{
		/// <summary>
		/// Request handling method.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> for the current request.</param>
		/// <param name="next">The delegate representing the remaining middleware in the request pipeline.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that represents the execution of this middleware.</returns>
		Task InvokeAsync(HttpContext context, RequestDelegate next);
	}
}
