using Microsoft.Extensions.Localization;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// Extension methods for setting up localization services in an <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
	/// </summary>
	public static class LocalizationServiceCollectionExtensions
	{
		/// <summary>
		/// Adds services required for application localization.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> to add the services to.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> so that additional calls can be chained.</returns>
		public static IServiceCollection AddLocalization(this IServiceCollection services)
		{
			throw null;
		}

		/// <summary>
		/// Adds services required for application localization.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> to add the services to.</param>
		/// <param name="setupAction">
		/// An <see cref="T:System.Action`1" /> to configure the <see cref="T:Microsoft.Extensions.Localization.LocalizationOptions" />.
		/// </param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> so that additional calls can be chained.</returns>
		public static IServiceCollection AddLocalization(this IServiceCollection services, Action<LocalizationOptions> setupAction)
		{
			throw null;
		}

		internal static void AddLocalizationServices(IServiceCollection services)
		{
			throw null;
		}

		internal static void AddLocalizationServices(IServiceCollection services, Action<LocalizationOptions> setupAction)
		{
			throw null;
		}
	}
}
