using System;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Builds conventions that will be used for customization of Connection <see cref="T:Microsoft.AspNetCore.Builder.EndpointBuilder" /> instances.
	/// </summary>
	public sealed class ConnectionEndpointRouteBuilder : IEndpointConventionBuilder
	{
		internal ConnectionEndpointRouteBuilder(IEndpointConventionBuilder endpointConventionBuilder)
		{
			throw null;
		}

		/// <summary>
		/// Adds the specified convention to the builder. Conventions are used to customize <see cref="T:Microsoft.AspNetCore.Builder.EndpointBuilder" /> instances.
		/// </summary>
		/// <param name="convention">The convention to add to the builder.</param>
		public void Add(Action<EndpointBuilder> convention)
		{
			throw null;
		}
	}
}
