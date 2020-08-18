using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Routing.Matching
{
	/// <summary>
	/// A <see cref="T:Microsoft.AspNetCore.Routing.MatcherPolicy" /> interface that can be implemented to sort
	/// endpoints. Implementations of <see cref="T:Microsoft.AspNetCore.Routing.Matching.IEndpointComparerPolicy" /> must
	/// inherit from <see cref="T:Microsoft.AspNetCore.Routing.MatcherPolicy" /> and should be registered in
	/// the dependency injection container as singleton services of type <see cref="T:Microsoft.AspNetCore.Routing.MatcherPolicy" />.
	/// </summary>
	/// <remarks>
	/// <para>
	/// Candidates in a <see cref="T:Microsoft.AspNetCore.Routing.Matching.CandidateSet" /> are sorted based on their priority. Defining
	/// a <see cref="T:Microsoft.AspNetCore.Routing.Matching.IEndpointComparerPolicy" /> adds an additional criterion to the sorting
	/// operation used to order candidates.
	/// </para>
	/// <para>
	/// As an example, the implementation of <see cref="T:Microsoft.AspNetCore.Routing.Matching.HttpMethodMatcherPolicy" /> implements
	/// <see cref="T:Microsoft.AspNetCore.Routing.Matching.IEndpointComparerPolicy" /> to ensure that endpoints matching specific HTTP
	/// methods are sorted with a higher priority than endpoints without a specific HTTP method
	/// requirement.
	/// </para>
	/// </remarks>
	public interface IEndpointComparerPolicy
	{
		/// <summary>
		/// Gets an <see cref="T:System.Collections.Generic.IComparer`1" /> that will be used to sort the endpoints.
		/// </summary>
		IComparer<Endpoint> Comparer
		{
			get;
		}
	}
}
