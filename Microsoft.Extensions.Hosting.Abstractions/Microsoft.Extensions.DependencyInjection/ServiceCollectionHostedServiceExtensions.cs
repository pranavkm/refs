using Microsoft.Extensions.Hosting;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Extensions.DependencyInjection
{
	public static class ServiceCollectionHostedServiceExtensions
	{
		/// <summary>
		/// Add an <see cref="T:Microsoft.Extensions.Hosting.IHostedService" /> registration for the given type.
		/// </summary>
		/// <typeparam name="THostedService">An <see cref="T:Microsoft.Extensions.Hosting.IHostedService" /> to register.</typeparam>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> to register with.</param>
		/// <returns>The original <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</returns>
		public static IServiceCollection AddHostedService<[System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicConstructors)] THostedService>(this IServiceCollection services) where THostedService : class, IHostedService
		{
			throw null;
		}

		/// <summary>
		/// Add an <see cref="T:Microsoft.Extensions.Hosting.IHostedService" /> registration for the given type.
		/// </summary>
		/// <typeparam name="THostedService">An <see cref="T:Microsoft.Extensions.Hosting.IHostedService" /> to register.</typeparam>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> to register with.</param>
		/// <param name="implementationFactory">A factory to create new instances of the service implementation.</param>
		/// <returns>The original <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</returns>
		public static IServiceCollection AddHostedService<THostedService>(this IServiceCollection services, Func<IServiceProvider, THostedService> implementationFactory) where THostedService : class, IHostedService
		{
			throw null;
		}
	}
}
