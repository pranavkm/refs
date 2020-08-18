using System;

namespace Microsoft.AspNetCore.Cors.Infrastructure
{
	/// <summary>
	/// Exposes methods to build a policy.
	/// </summary>
	public class CorsPolicyBuilder
	{
		/// <summary>
		/// Creates a new instance of the <see cref="T:Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicyBuilder" />.
		/// </summary>
		/// <param name="origins">list of origins which can be added.</param>
		/// <remarks> <see cref="M:Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicyBuilder.WithOrigins(System.String[])" /> for details on normalizing the origin value.</remarks>
		public CorsPolicyBuilder(params string[] origins)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new instance of the <see cref="T:Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicyBuilder" />.
		/// </summary>
		/// <param name="policy">The policy which will be used to intialize the builder.</param>
		public CorsPolicyBuilder(CorsPolicy policy)
		{
			throw null;
		}

		/// <summary>
		/// Adds the specified <paramref name="origins" /> to the policy.
		/// </summary>
		/// <param name="origins">The origins that are allowed.</param>
		/// <returns>The current policy builder.</returns>
		/// <remarks>
		/// This method normalizes the origin value prior to adding it to <see cref="P:Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy.Origins" /> to match
		/// the normalization performed by the browser on the value sent in the <c>ORIGIN</c> header.
		/// <list type="bullet">
		/// <item>
		/// If the specified origin has an internationalized domain name (IDN), the punycoded value is used. If the origin
		/// specifies a default port (e.g. 443 for HTTPS or 80 for HTTP), this will be dropped as part of normalization.
		/// Finally, the scheme and punycoded host name are culture invariant lower cased before being added to the <see cref="P:Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy.Origins" />
		/// collection.
		/// </item>
		/// <item>
		/// For all other origins, normalization involves performing a culture invariant lower casing of the host name.
		/// </item>
		/// </list>
		/// </remarks>
		public CorsPolicyBuilder WithOrigins(params string[] origins)
		{
			throw null;
		}

		internal static string GetNormalizedOrigin(string origin)
		{
			throw null;
		}

		/// <summary>
		/// Adds the specified <paramref name="headers" /> to the policy.
		/// </summary>
		/// <param name="headers">The headers which need to be allowed in the request.</param>
		/// <returns>The current policy builder.</returns>
		public CorsPolicyBuilder WithHeaders(params string[] headers)
		{
			throw null;
		}

		/// <summary>
		/// Adds the specified <paramref name="exposedHeaders" /> to the policy.
		/// </summary>
		/// <param name="exposedHeaders">The headers which need to be exposed to the client.</param>
		/// <returns>The current policy builder.</returns>
		public CorsPolicyBuilder WithExposedHeaders(params string[] exposedHeaders)
		{
			throw null;
		}

		/// <summary>
		/// Adds the specified <paramref name="methods" /> to the policy.
		/// </summary>
		/// <param name="methods">The methods which need to be added to the policy.</param>
		/// <returns>The current policy builder.</returns>
		public CorsPolicyBuilder WithMethods(params string[] methods)
		{
			throw null;
		}

		/// <summary>
		/// Sets the policy to allow credentials.
		/// </summary>
		/// <returns>The current policy builder.</returns>
		public CorsPolicyBuilder AllowCredentials()
		{
			throw null;
		}

		/// <summary>
		/// Sets the policy to not allow credentials.
		/// </summary>
		/// <returns>The current policy builder.</returns>
		public CorsPolicyBuilder DisallowCredentials()
		{
			throw null;
		}

		/// <summary>
		/// Ensures that the policy allows any origin.
		/// </summary>
		/// <returns>The current policy builder.</returns>
		public CorsPolicyBuilder AllowAnyOrigin()
		{
			throw null;
		}

		/// <summary>
		/// Ensures that the policy allows any method.
		/// </summary>
		/// <returns>The current policy builder.</returns>
		public CorsPolicyBuilder AllowAnyMethod()
		{
			throw null;
		}

		/// <summary>
		/// Ensures that the policy allows any header.
		/// </summary>
		/// <returns>The current policy builder.</returns>
		public CorsPolicyBuilder AllowAnyHeader()
		{
			throw null;
		}

		/// <summary>
		/// Sets the preflightMaxAge for the underlying policy.
		/// </summary>
		/// <param name="preflightMaxAge">A positive <see cref="T:System.TimeSpan" /> indicating the time a preflight
		/// request can be cached.</param>
		/// <returns>The current policy builder.</returns>
		public CorsPolicyBuilder SetPreflightMaxAge(TimeSpan preflightMaxAge)
		{
			throw null;
		}

		/// <summary>
		/// Sets the specified <paramref name="isOriginAllowed" /> for the underlying policy.
		/// </summary>
		/// <param name="isOriginAllowed">The function used by the policy to evaluate if an origin is allowed.</param>
		/// <returns>The current policy builder.</returns>
		public CorsPolicyBuilder SetIsOriginAllowed(Func<string, bool> isOriginAllowed)
		{
			throw null;
		}

		/// <summary>
		/// Sets the <see cref="P:Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy.IsOriginAllowed" /> property of the policy to be a function
		/// that allows origins to match a configured wildcarded domain when evaluating if the
		/// origin is allowed.
		/// </summary>
		/// <returns>The current policy builder.</returns>
		public CorsPolicyBuilder SetIsOriginAllowedToAllowWildcardSubdomains()
		{
			throw null;
		}

		/// <summary>
		/// Builds a new <see cref="T:Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy" /> using the entries added.
		/// </summary>
		/// <returns>The constructed <see cref="T:Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy" />.</returns>
		public CorsPolicy Build()
		{
			throw null;
		}
	}
}
