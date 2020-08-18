using Microsoft.AspNetCore.Cors.Infrastructure;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// Extension methods for setting up cross-origin resource sharing services in an <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
	/// </summary>
	public static class CorsServiceCollectionExtensions
	{
		/// <summary>
		/// Adds cross-origin resource sharing services to the specified <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> to add services to.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> so that additional calls can be chained.</returns>
		public static IServiceCollection AddCors(this IServiceCollection services)
		{
			throw null;
		}

		/// <summary>
		/// Adds cross-origin resource sharing services to the specified <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> to add services to.</param>
		/// <param name="setupAction">An <see cref="T:System.Action`1" /> to configure the provided <see cref="T:Microsoft.AspNetCore.Cors.Infrastructure.CorsOptions" />.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> so that additional calls can be chained.</returns>
		public static IServiceCollection AddCors(this IServiceCollection services, Action<CorsOptions> setupAction)
		{
			throw null;
		}
	}
}
