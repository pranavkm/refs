using Microsoft.AspNetCore.Authorization;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Authorization extension methods for <see cref="T:Microsoft.AspNetCore.Builder.IEndpointConventionBuilder" />.
	/// </summary>
	public static class AuthorizationEndpointConventionBuilderExtensions
	{
		/// <summary>
		/// Adds the default authorization policy to the endpoint(s).
		/// </summary>
		/// <param name="builder">The endpoint convention builder.</param>
		/// <returns>The original convention builder parameter.</returns>
		public static TBuilder RequireAuthorization<TBuilder>(this TBuilder builder) where TBuilder : IEndpointConventionBuilder
		{
			throw null;
		}

		/// <summary>
		/// Adds authorization policies with the specified names to the endpoint(s).
		/// </summary>
		/// <param name="builder">The endpoint convention builder.</param>
		/// <param name="policyNames">A collection of policy names. If empty, the default authorization policy will be used.</param>
		/// <returns>The original convention builder parameter.</returns>
		public static TBuilder RequireAuthorization<TBuilder>(this TBuilder builder, params string[] policyNames) where TBuilder : IEndpointConventionBuilder
		{
			throw null;
		}

		/// <summary>
		/// Adds authorization policies with the specified <see cref="T:Microsoft.AspNetCore.Authorization.IAuthorizeData" /> to the endpoint(s).
		/// </summary>
		/// <param name="builder">The endpoint convention builder.</param>
		/// <param name="authorizeData">
		/// A collection of <paramref name="authorizeData" />. If empty, the default authorization policy will be used.
		/// </param>
		/// <returns>The original convention builder parameter.</returns>
		public static TBuilder RequireAuthorization<TBuilder>(this TBuilder builder, params IAuthorizeData[] authorizeData) where TBuilder : IEndpointConventionBuilder
		{
			throw null;
		}

		/// <summary>
		/// Allows anonymous access to the endpoint by adding <see cref="T:Microsoft.AspNetCore.Authorization.AllowAnonymousAttribute" /> to the endpoint metadata. This will bypass
		/// all authorization checks for the endpoint including the default authorization policy and fallback authorization policy.
		/// </summary>
		/// <param name="builder">The endpoint convention builder.</param>
		/// <returns>The original convention builder parameter.</returns>
		public static TBuilder AllowAnonymous<TBuilder>(this TBuilder builder) where TBuilder : IEndpointConventionBuilder
		{
			throw null;
		}
	}
}
