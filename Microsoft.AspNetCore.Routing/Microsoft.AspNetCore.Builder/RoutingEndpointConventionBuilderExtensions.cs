using System;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Extension methods for adding routing metadata to endpoint instances using <see cref="T:Microsoft.AspNetCore.Builder.IEndpointConventionBuilder" />.
	/// </summary>
	public static class RoutingEndpointConventionBuilderExtensions
	{
		/// <summary>
		/// Requires that endpoints match one of the specified hosts during routing.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Builder.IEndpointConventionBuilder" /> to add the metadata to.</param>
		/// <param name="hosts">
		/// The hosts used during routing.
		/// Hosts should be Unicode rather than punycode, and may have a port.
		/// An empty collection means any host will be accepted.
		/// </param>
		/// <returns>A reference to this instance after the operation has completed.</returns>
		public static TBuilder RequireHost<TBuilder>(this TBuilder builder, params string[] hosts) where TBuilder : IEndpointConventionBuilder
		{
			throw null;
		}

		/// <summary>
		/// Sets the <see cref="P:Microsoft.AspNetCore.Builder.EndpointBuilder.DisplayName" /> to the provided <paramref name="displayName" /> for all
		/// builders created by <paramref name="builder" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Builder.IEndpointConventionBuilder" />.</param>
		/// <param name="displayName">The display name.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Builder.IEndpointConventionBuilder" />.</returns>
		public static TBuilder WithDisplayName<TBuilder>(this TBuilder builder, string displayName) where TBuilder : IEndpointConventionBuilder
		{
			throw null;
		}

		/// <summary>
		/// Sets the <see cref="P:Microsoft.AspNetCore.Builder.EndpointBuilder.DisplayName" /> using the provided <paramref name="func" /> for all
		/// builders created by <paramref name="builder" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Builder.IEndpointConventionBuilder" />.</param>
		/// <param name="func">A delegate that produces the display name for each <see cref="T:Microsoft.AspNetCore.Builder.EndpointBuilder" />.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Builder.IEndpointConventionBuilder" />.</returns>
		public static TBuilder WithDisplayName<TBuilder>(this TBuilder builder, Func<EndpointBuilder, string> func) where TBuilder : IEndpointConventionBuilder
		{
			throw null;
		}

		/// <summary>
		/// Adds the provided metadata <paramref name="items" /> to <see cref="P:Microsoft.AspNetCore.Builder.EndpointBuilder.Metadata" /> for all builders
		/// produced by <paramref name="builder" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Builder.IEndpointConventionBuilder" />.</param>
		/// <param name="items">A collection of metadata items.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Builder.IEndpointConventionBuilder" />.</returns>
		public static TBuilder WithMetadata<TBuilder>(this TBuilder builder, params object[] items) where TBuilder : IEndpointConventionBuilder
		{
			throw null;
		}
	}
}
