using Microsoft.AspNetCore.Cors.Infrastructure;
using System;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> extensions for adding CORS middleware support.
	/// </summary>
	public static class CorsMiddlewareExtensions
	{
		/// <summary>
		/// Adds a CORS middleware to your web application pipeline to allow cross domain requests.
		/// </summary>
		/// <param name="app">The IApplicationBuilder passed to your Configure method</param>
		/// <returns>The original app parameter</returns>
		public static IApplicationBuilder UseCors(this IApplicationBuilder app)
		{
			throw null;
		}

		/// <summary>
		/// Adds a CORS middleware to your web application pipeline to allow cross domain requests.
		/// </summary>
		/// <param name="app">The IApplicationBuilder passed to your Configure method</param>
		/// <param name="policyName">The policy name of a configured policy.</param>
		/// <returns>The original app parameter</returns>
		public static IApplicationBuilder UseCors(this IApplicationBuilder app, string policyName)
		{
			throw null;
		}

		/// <summary>
		/// Adds a CORS middleware to your web application pipeline to allow cross domain requests.
		/// </summary>
		/// <param name="app">The IApplicationBuilder passed to your Configure method.</param>
		/// <param name="configurePolicy">A delegate which can use a policy builder to build a policy.</param>
		/// <returns>The original app parameter</returns>
		public static IApplicationBuilder UseCors(this IApplicationBuilder app, Action<CorsPolicyBuilder> configurePolicy)
		{
			throw null;
		}
	}
}
