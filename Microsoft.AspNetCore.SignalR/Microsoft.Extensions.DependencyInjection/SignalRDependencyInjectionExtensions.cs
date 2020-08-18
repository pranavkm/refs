using Microsoft.AspNetCore.SignalR;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// Extension methods for setting up SignalR services in an <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
	/// </summary>
	public static class SignalRDependencyInjectionExtensions
	{
		/// <summary>
		/// Adds hub specific options to an <see cref="T:Microsoft.AspNetCore.SignalR.ISignalRServerBuilder" />.
		/// </summary>
		/// <typeparam name="THub">The hub type to configure.</typeparam>
		/// <param name="signalrBuilder">The <see cref="T:Microsoft.AspNetCore.SignalR.ISignalRServerBuilder" />.</param>
		/// <param name="configure">A callback to configure the hub options.</param>
		/// <returns>The same instance of the <see cref="T:Microsoft.AspNetCore.SignalR.ISignalRServerBuilder" /> for chaining.</returns>
		public static ISignalRServerBuilder AddHubOptions<THub>(this ISignalRServerBuilder signalrBuilder, Action<HubOptions<THub>> configure) where THub : Hub
		{
			throw null;
		}

		/// <summary>
		/// Adds SignalR services to the specified <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> to add services to.</param>
		/// <returns>An <see cref="T:Microsoft.AspNetCore.SignalR.ISignalRServerBuilder" /> that can be used to further configure the SignalR services.</returns>
		public static ISignalRServerBuilder AddSignalR(this IServiceCollection services)
		{
			throw null;
		}

		/// <summary>
		/// Adds SignalR services to the specified <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> to add services to.</param>
		/// <param name="configure">An <see cref="T:System.Action`1" /> to configure the provided <see cref="T:Microsoft.AspNetCore.SignalR.HubOptions" />.</param>
		/// <returns>An <see cref="T:Microsoft.AspNetCore.SignalR.ISignalRServerBuilder" /> that can be used to further configure the SignalR services.</returns>
		public static ISignalRServerBuilder AddSignalR(this IServiceCollection services, Action<HubOptions> configure)
		{
			throw null;
		}
	}
}
