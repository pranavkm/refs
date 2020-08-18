using Microsoft.AspNetCore.Builder;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// Extension methods for the request localization middleware.
	/// </summary>
	public static class RequestLocalizationServiceCollectionExtensions
	{
		/// <summary>
		/// Adds services and options for the request localization middleware.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> for adding services.</param>
		/// <param name="configureOptions">A delegate to configure the <see cref="T:Microsoft.AspNetCore.Builder.RequestLocalizationOptions" />.</param>
		/// <returns></returns>
		public static IServiceCollection AddRequestLocalization(this IServiceCollection services, Action<RequestLocalizationOptions> configureOptions)
		{
			throw null;
		}

		/// <summary>
		/// Adds services and options for the request localization middleware.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> for adding services.</param>
		/// <param name="configureOptions">A delegate to configure the <see cref="T:Microsoft.AspNetCore.Builder.RequestLocalizationOptions" />.</param>
		/// <returns></returns>
		public static IServiceCollection AddRequestLocalization<TService>(this IServiceCollection services, Action<RequestLocalizationOptions, TService> configureOptions) where TService : class
		{
			throw null;
		}
	}
}
