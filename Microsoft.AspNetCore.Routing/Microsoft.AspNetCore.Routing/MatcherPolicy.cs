using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Defines a policy that applies behaviors to the URL matcher. Implementations
	/// of <see cref="T:Microsoft.AspNetCore.Routing.MatcherPolicy" /> and related interfaces must be registered
	/// in the dependency injection container as singleton services of type
	/// <see cref="T:Microsoft.AspNetCore.Routing.MatcherPolicy" />.
	/// </summary>
	/// <remarks>
	/// <see cref="T:Microsoft.AspNetCore.Routing.MatcherPolicy" /> implementations can implement the following
	/// interfaces <see cref="T:Microsoft.AspNetCore.Routing.Matching.IEndpointComparerPolicy" />, <see cref="T:Microsoft.AspNetCore.Routing.Matching.IEndpointSelectorPolicy" />,
	/// and <see cref="T:Microsoft.AspNetCore.Routing.Matching.INodeBuilderPolicy" />.
	/// </remarks>
	public abstract class MatcherPolicy
	{
		/// <summary>
		/// Gets a value that determines the order the <see cref="T:Microsoft.AspNetCore.Routing.MatcherPolicy" /> should
		/// be applied. Policies are applied in ascending numeric value of the <see cref="P:Microsoft.AspNetCore.Routing.MatcherPolicy.Order" />
		/// property.
		/// </summary>
		public abstract int Order
		{
			get;
		}

		/// <summary>
		/// Returns a value that indicates whether the provided <paramref name="endpoints" /> contains
		/// one or more dynamic endpoints.
		/// </summary>
		/// <param name="endpoints">The set of endpoints.</param>
		/// <returns><c>true</c> if a dynamic endpoint is found; otherwise returns <c>false</c>.</returns>
		/// <remarks>
		/// <para>
		/// The presence of <see cref="T:Microsoft.AspNetCore.Routing.IDynamicEndpointMetadata" /> signifies that an endpoint that may be replaced 
		/// during processing by an <see cref="T:Microsoft.AspNetCore.Routing.Matching.IEndpointSelectorPolicy" />.
		/// </para>
		/// <para>
		/// An implementation of <see cref="T:Microsoft.AspNetCore.Routing.Matching.INodeBuilderPolicy" /> should also implement <see cref="T:Microsoft.AspNetCore.Routing.Matching.IEndpointSelectorPolicy" />
		/// and use its <see cref="T:Microsoft.AspNetCore.Routing.Matching.IEndpointSelectorPolicy" /> implementation when a node contains a dynamic endpoint.
		/// <see cref="T:Microsoft.AspNetCore.Routing.Matching.INodeBuilderPolicy" /> implementations rely on caching of data based on a static set of endpoints. This
		/// is not possible when endpoints are replaced dynamically.
		/// </para>
		/// </remarks>
		protected static bool ContainsDynamicEndpoints(IReadOnlyList<Endpoint> endpoints)
		{
			throw null;
		}

		protected MatcherPolicy()
		{
			throw null;
		}
	}
}
