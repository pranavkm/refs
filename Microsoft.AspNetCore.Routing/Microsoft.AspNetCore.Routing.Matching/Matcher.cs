using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Routing.Matching
{
	/// <summary>
	/// An interface for components that can select an <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> given the current request, as part
	/// of the execution of <see cref="T:Microsoft.AspNetCore.Routing.EndpointRoutingMiddleware" />.
	/// </summary>
	internal abstract class Matcher
	{
		/// <summary>
		/// Attempts to asynchronously select an <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> for the current request.
		/// </summary>
		/// <param name="httpContext">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> associated with the current request.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> which represents the asynchronous completion of the operation.</returns>
		public abstract Task MatchAsync(HttpContext httpContext);

		protected Matcher()
		{
			throw null;
		}
	}
}
