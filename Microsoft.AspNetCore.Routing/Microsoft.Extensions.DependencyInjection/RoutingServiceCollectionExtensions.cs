using Microsoft.AspNetCore.Routing;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// Contains extension methods to <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
	/// </summary>
	public static class RoutingServiceCollectionExtensions
	{
		/// <summary>
		/// Adds services required for routing requests.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> to add the services to.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> so that additional calls can be chained.</returns>
		public static IServiceCollection AddRouting(this IServiceCollection services)
		{
			throw null;
		}

		/// <summary>
		/// Adds services required for routing requests.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> to add the services to.</param>
		/// <param name="configureOptions">The routing options to configure the middleware with.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> so that additional calls can be chained.</returns>
		public static IServiceCollection AddRouting(this IServiceCollection services, Action<RouteOptions> configureOptions)
		{
			throw null;
		}
	}
}
