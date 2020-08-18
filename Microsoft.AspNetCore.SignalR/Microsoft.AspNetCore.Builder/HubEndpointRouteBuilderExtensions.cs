using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.AspNetCore.Builder
{
	public static class HubEndpointRouteBuilderExtensions
	{
		/// <summary>
		/// Maps incoming requests with the specified path to the specified <see cref="T:Microsoft.AspNetCore.SignalR.Hub" /> type.
		/// </summary>
		/// <typeparam name="THub">The <see cref="T:Microsoft.AspNetCore.SignalR.Hub" /> type to map requests to.</typeparam>
		/// <param name="endpoints">The <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> to add the route to.</param>
		/// <param name="pattern">The route pattern.</param>
		/// <returns>An <see cref="T:Microsoft.AspNetCore.Builder.HubEndpointConventionBuilder" /> for endpoints associated with the connections.</returns>
		public static HubEndpointConventionBuilder MapHub<[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)11)] THub>(this IEndpointRouteBuilder endpoints, string pattern) where THub : Hub
		{
			throw null;
		}

		/// <summary>
		/// Maps incoming requests with the specified path to the specified <see cref="T:Microsoft.AspNetCore.SignalR.Hub" /> type.
		/// </summary>
		/// <typeparam name="THub">The <see cref="T:Microsoft.AspNetCore.SignalR.Hub" /> type to map requests to.</typeparam>
		/// <param name="endpoints">The <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> to add the route to.</param>
		/// <param name="pattern">The route pattern.</param>
		/// <param name="configureOptions">A callback to configure dispatcher options.</param>
		/// <returns>An <see cref="T:Microsoft.AspNetCore.Builder.HubEndpointConventionBuilder" /> for endpoints associated with the connections.</returns>
		public static HubEndpointConventionBuilder MapHub<[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)11)] THub>(this IEndpointRouteBuilder endpoints, string pattern, Action<HttpConnectionDispatcherOptions> configureOptions) where THub : Hub
		{
			throw null;
		}
	}
}
