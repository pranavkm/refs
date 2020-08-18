using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Routing.Matching
{
	/// <summary>
	/// A <see cref="T:Microsoft.AspNetCore.Routing.MatcherPolicy" /> interface that can implemented to filter endpoints
	/// in a <see cref="T:Microsoft.AspNetCore.Routing.Matching.CandidateSet" />. Implementations of <see cref="T:Microsoft.AspNetCore.Routing.Matching.IEndpointSelectorPolicy" /> must
	/// inherit from <see cref="T:Microsoft.AspNetCore.Routing.MatcherPolicy" /> and should be registered in
	/// the dependency injection container as singleton services of type <see cref="T:Microsoft.AspNetCore.Routing.MatcherPolicy" />.
	/// </summary>
	public interface IEndpointSelectorPolicy
	{
		/// <summary>
		/// Returns a value that indicates whether the <see cref="T:Microsoft.AspNetCore.Routing.Matching.IEndpointSelectorPolicy" /> applies
		/// to any endpoint in <paramref name="endpoints" />.
		/// </summary>
		/// <param name="endpoints">The set of candidate <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> values.</param>
		/// <returns>
		/// <c>true</c> if the policy applies to any endpoint in <paramref name="endpoints" />, otherwise <c>false</c>.
		/// </returns>
		bool AppliesToEndpoints(IReadOnlyList<Endpoint> endpoints);

		/// <summary>
		/// Applies the policy to the <see cref="T:Microsoft.AspNetCore.Routing.Matching.CandidateSet" />.
		/// </summary>
		/// <param name="httpContext">
		/// The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> associated with the current request.
		/// </param>
		/// <param name="candidates">The <see cref="T:Microsoft.AspNetCore.Routing.Matching.CandidateSet" />.</param>
		/// <remarks>
		/// <para>
		/// Implementations of <see cref="T:Microsoft.AspNetCore.Routing.Matching.IEndpointSelectorPolicy" /> should implement this method
		/// and filter the set of candidates in the <paramref name="candidates" /> by setting
		/// <see cref="M:Microsoft.AspNetCore.Routing.Matching.CandidateSet.SetValidity(System.Int32,System.Boolean)" /> to <c>false</c> where desired.
		/// </para>
		/// <para>
		/// To signal an error condition, the <see cref="T:Microsoft.AspNetCore.Routing.Matching.IEndpointSelectorPolicy" /> should assign the endpoint by
		/// calling <see cref="M:Microsoft.AspNetCore.Http.EndpointHttpContextExtensions.SetEndpoint(Microsoft.AspNetCore.Http.HttpContext,Microsoft.AspNetCore.Http.Endpoint)" />
		/// and setting <see cref="P:Microsoft.AspNetCore.Http.HttpRequest.RouteValues" /> to an
		/// <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> value that will produce the desired error when executed.
		/// </para>
		/// </remarks>
		Task ApplyAsync(HttpContext httpContext, CandidateSet candidates);
	}
}
