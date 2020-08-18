using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// A function that can process an HTTP request.
	/// </summary>
	/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> for the request.</param>
	/// <returns>A task that represents the completion of request processing.</returns>
	public delegate Task RequestDelegate(HttpContext context);
}
