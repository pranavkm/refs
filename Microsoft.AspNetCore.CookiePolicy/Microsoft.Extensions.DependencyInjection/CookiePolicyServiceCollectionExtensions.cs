using Microsoft.AspNetCore.Builder;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// Extension methods for the cookie policy middleware.
	/// </summary>
	public static class CookiePolicyServiceCollectionExtensions
	{
		/// <summary>
		/// Adds services and options for the cookie policy middleware.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> for adding services.</param>
		/// <param name="configureOptions">A delegate to configure the <see cref="T:Microsoft.AspNetCore.Builder.CookiePolicyOptions" />.</param>
		/// <returns></returns>
		public static IServiceCollection AddCookiePolicy(this IServiceCollection services, Action<CookiePolicyOptions> configureOptions)
		{
			throw null;
		}

		/// <summary>
		/// Adds services and options for the cookie policy middleware.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> for adding services.</param>
		/// <param name="configureOptions">A delegate to configure the <see cref="T:Microsoft.AspNetCore.Builder.CookiePolicyOptions" />.</param>
		/// <returns></returns>
		public static IServiceCollection AddCookiePolicy<TService>(this IServiceCollection services, Action<CookiePolicyOptions, TService> configureOptions) where TService : class
		{
			throw null;
		}
	}
}
