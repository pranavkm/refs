using Microsoft.AspNetCore.Antiforgery;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// Extension methods for setting up antiforgery services in an <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
	/// </summary>
	public static class AntiforgeryServiceCollectionExtensions
	{
		/// <summary>
		/// Adds antiforgery services to the specified <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> to add services to.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> so that additional calls can be chained.</returns>
		public static IServiceCollection AddAntiforgery(this IServiceCollection services)
		{
			throw null;
		}

		/// <summary>
		/// Adds antiforgery services to the specified <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> to add services to.</param>
		/// <param name="setupAction">An <see cref="T:System.Action`1" /> to configure the provided <see cref="T:Microsoft.AspNetCore.Antiforgery.AntiforgeryOptions" />.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> so that additional calls can be chained.</returns>
		public static IServiceCollection AddAntiforgery(this IServiceCollection services, Action<AntiforgeryOptions> setupAction)
		{
			throw null;
		}
	}
}
