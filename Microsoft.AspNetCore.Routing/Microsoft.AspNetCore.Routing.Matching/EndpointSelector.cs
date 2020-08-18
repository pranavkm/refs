using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Routing.Matching
{
	/// <summary>
	/// A service that is responsible for the final <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> selection
	/// decision. To use a custom <see cref="T:Microsoft.AspNetCore.Routing.Matching.EndpointSelector" /> register an implementation
	/// of <see cref="T:Microsoft.AspNetCore.Routing.Matching.EndpointSelector" /> in the dependency injection container as a singleton.
	/// </summary>
	public abstract class EndpointSelector
	{
		/// <summary>
		/// Asynchronously selects an <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> from the <see cref="T:Microsoft.AspNetCore.Routing.Matching.CandidateSet" />.
		/// </summary>
		/// <param name="httpContext">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> associated with the current request.</param>
		/// <param name="candidates">The <see cref="T:Microsoft.AspNetCore.Routing.Matching.CandidateSet" />.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that completes asynchronously once endpoint selection is complete.</returns>
		/// <remarks>
		/// An <see cref="T:Microsoft.AspNetCore.Routing.Matching.EndpointSelector" /> should assign the endpoint by calling
		/// <see cref="M:Microsoft.AspNetCore.Http.EndpointHttpContextExtensions.SetEndpoint(Microsoft.AspNetCore.Http.HttpContext,Microsoft.AspNetCore.Http.Endpoint)" />
		/// and setting <see cref="P:Microsoft.AspNetCore.Http.HttpRequest.RouteValues" /> once an endpoint is selected.
		/// </remarks>
		public abstract Task SelectAsync(HttpContext httpContext, CandidateSet candidates);

		protected EndpointSelector()
		{
			throw null;
		}
	}
}
