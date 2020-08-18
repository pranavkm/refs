using System;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Builds conventions that will be used for customization of <see cref="T:Microsoft.AspNetCore.Builder.EndpointBuilder" /> instances.
	/// </summary>
	/// <remarks>
	/// This interface is used at application startup to customize endpoints for the application.
	/// </remarks>
	public interface IEndpointConventionBuilder
	{
		/// <summary>
		/// Adds the specified convention to the builder. Conventions are used to customize <see cref="T:Microsoft.AspNetCore.Builder.EndpointBuilder" /> instances.
		/// </summary>
		/// <param name="convention">The convention to add to the builder.</param>
		void Add(Action<EndpointBuilder> convention);
	}
}
