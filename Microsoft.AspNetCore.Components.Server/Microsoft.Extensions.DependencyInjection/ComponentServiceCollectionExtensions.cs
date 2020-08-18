using Microsoft.AspNetCore.Components.Server;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// Extension methods to configure an <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> for components.
	/// </summary>
	public static class ComponentServiceCollectionExtensions
	{
		private class DefaultServerSideBlazorBuilder : IServerSideBlazorBuilder
		{
			public IServiceCollection Services
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public DefaultServerSideBlazorBuilder(IServiceCollection services)
			{
				throw null;
			}
		}

		/// <summary>
		/// Adds Server-Side Blazor services to the service collection.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <param name="configure">A callback to configure <see cref="T:Microsoft.AspNetCore.Components.Server.CircuitOptions" />.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IServerSideBlazorBuilder" /> that can be used to further customize the configuration.</returns>
		public static IServerSideBlazorBuilder AddServerSideBlazor(this IServiceCollection services, Action<CircuitOptions>? configure = null)
		{
			throw null;
		}
	}
}
