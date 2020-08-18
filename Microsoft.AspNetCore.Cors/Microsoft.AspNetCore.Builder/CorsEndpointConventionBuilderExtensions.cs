using Microsoft.AspNetCore.Cors.Infrastructure;
using System;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// CORS extension methods for <see cref="T:Microsoft.AspNetCore.Builder.IEndpointConventionBuilder" />.
	/// </summary>
	public static class CorsEndpointConventionBuilderExtensions
	{
		/// <summary>
		/// Adds a CORS policy with the specified name to the endpoint(s).
		/// </summary>
		/// <param name="builder">The endpoint convention builder.</param>
		/// <param name="policyName">The CORS policy name.</param>
		/// <returns>The original convention builder parameter.</returns>
		public static TBuilder RequireCors<TBuilder>(this TBuilder builder, string policyName) where TBuilder : IEndpointConventionBuilder
		{
			throw null;
		}

		/// <summary>
		/// Adds the specified CORS policy to the endpoint(s).
		/// </summary>
		/// <param name="builder">The endpoint convention builder.</param>
		/// <param name="configurePolicy">A delegate which can use a policy builder to build a policy.</param>
		/// <returns>The original convention builder parameter.</returns>
		public static TBuilder RequireCors<TBuilder>(this TBuilder builder, Action<CorsPolicyBuilder> configurePolicy) where TBuilder : IEndpointConventionBuilder
		{
			throw null;
		}
	}
}
