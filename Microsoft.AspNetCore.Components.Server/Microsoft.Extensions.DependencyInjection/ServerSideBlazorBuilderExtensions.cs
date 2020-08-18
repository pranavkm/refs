using Microsoft.AspNetCore.Components.Server;
using Microsoft.AspNetCore.SignalR;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// Provides options for configuring Server-Side Blazor.
	/// </summary>
	public static class ServerSideBlazorBuilderExtensions
	{
		/// <summary>
		/// Adds options to configure circuits.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServerSideBlazorBuilder" />.</param>
		/// <param name="configure">A callback to configure <see cref="T:Microsoft.AspNetCore.Components.Server.CircuitOptions" />.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IServerSideBlazorBuilder" />.</returns>
		public static IServerSideBlazorBuilder AddCircuitOptions(this IServerSideBlazorBuilder builder, Action<CircuitOptions> configure)
		{
			throw null;
		}

		/// <summary>
		/// Adds hub options for the configuration of the SignalR Hub used by Server-Side Blazor.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServerSideBlazorBuilder" />.</param>
		/// <param name="configure">A callback to configure the hub options.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IServerSideBlazorBuilder" />.</returns>
		public static IServerSideBlazorBuilder AddHubOptions(this IServerSideBlazorBuilder builder, Action<HubOptions> configure)
		{
			throw null;
		}
	}
}
