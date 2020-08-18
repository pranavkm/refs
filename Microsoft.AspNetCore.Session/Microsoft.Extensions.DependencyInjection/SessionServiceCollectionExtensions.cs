using Microsoft.AspNetCore.Builder;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// Extension methods for adding session services to the DI container.
	/// </summary>
	public static class SessionServiceCollectionExtensions
	{
		/// <summary>
		/// Adds services required for application session state.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> to add the services to.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> so that additional calls can be chained.</returns>
		public static IServiceCollection AddSession(this IServiceCollection services)
		{
			throw null;
		}

		/// <summary>
		/// Adds services required for application session state.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> to add the services to.</param>
		/// <param name="configure">The session options to configure the middleware with.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> so that additional calls can be chained.</returns>
		public static IServiceCollection AddSession(this IServiceCollection services, Action<SessionOptions> configure)
		{
			throw null;
		}
	}
}
