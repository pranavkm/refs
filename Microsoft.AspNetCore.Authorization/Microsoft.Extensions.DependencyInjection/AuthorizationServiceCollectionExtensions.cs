using Microsoft.AspNetCore.Authorization;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// Extension methods for setting up authorization services in an <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
	/// </summary>
	public static class AuthorizationServiceCollectionExtensions
	{
		/// <summary>
		/// Adds authorization services to the specified <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> to add services to.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> so that additional calls can be chained.</returns>
		public static IServiceCollection AddAuthorizationCore(this IServiceCollection services)
		{
			throw null;
		}

		/// <summary>
		/// Adds authorization services to the specified <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> to add services to.</param>
		/// <param name="configure">An action delegate to configure the provided <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizationOptions" />.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> so that additional calls can be chained.</returns>
		public static IServiceCollection AddAuthorizationCore(this IServiceCollection services, Action<AuthorizationOptions> configure)
		{
			throw null;
		}
	}
}
