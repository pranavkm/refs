using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Builder
{
	public static class ConnectionEndpointRouteBuilderExtensions
	{
		private class CompositeEndpointConventionBuilder : IEndpointConventionBuilder
		{
			public CompositeEndpointConventionBuilder(List<IEndpointConventionBuilder> endpointConventionBuilders)
			{
				throw null;
			}

			public void Add(Action<EndpointBuilder> convention)
			{
				throw null;
			}
		}

		/// <summary>
		/// Maps incoming requests with the specified path to the provided connection pipeline.
		/// </summary>
		/// <param name="endpoints">The <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> to add the route to.</param>
		/// <param name="pattern">The route pattern.</param>
		/// <param name="configure">A callback to configure the connection.</param>
		/// <returns>An <see cref="T:Microsoft.AspNetCore.Builder.ConnectionEndpointRouteBuilder" /> for endpoints associated with the connections.</returns>
		public static ConnectionEndpointRouteBuilder MapConnections(this IEndpointRouteBuilder endpoints, string pattern, Action<IConnectionBuilder> configure)
		{
			throw null;
		}

		/// <summary>
		/// Maps incoming requests with the specified path to the provided connection pipeline.
		/// </summary>
		/// <typeparam name="TConnectionHandler">The <see cref="T:Microsoft.AspNetCore.Connections.ConnectionHandler" /> type.</typeparam>
		/// <param name="endpoints">The <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> to add the route to.</param>
		/// <param name="pattern">The route pattern.</param>
		/// <returns>An <see cref="T:Microsoft.AspNetCore.Builder.ConnectionEndpointRouteBuilder" /> for endpoints associated with the connections.</returns>
		public static ConnectionEndpointRouteBuilder MapConnectionHandler<TConnectionHandler>(this IEndpointRouteBuilder endpoints, string pattern) where TConnectionHandler : ConnectionHandler
		{
			throw null;
		}

		/// <summary>
		/// Maps incoming requests with the specified path to the provided connection pipeline.
		/// </summary>
		/// <typeparam name="TConnectionHandler">The <see cref="T:Microsoft.AspNetCore.Connections.ConnectionHandler" /> type.</typeparam>
		/// <param name="endpoints">The <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> to add the route to.</param>
		/// <param name="pattern">The route pattern.</param>
		/// <param name="configureOptions">A callback to configure dispatcher options.</param>
		/// <returns>An <see cref="T:Microsoft.AspNetCore.Builder.ConnectionEndpointRouteBuilder" /> for endpoints associated with the connections.</returns>
		public static ConnectionEndpointRouteBuilder MapConnectionHandler<TConnectionHandler>(this IEndpointRouteBuilder endpoints, string pattern, Action<HttpConnectionDispatcherOptions>? configureOptions) where TConnectionHandler : ConnectionHandler
		{
			throw null;
		}

		/// <summary>
		/// Maps incoming requests with the specified path to the provided connection pipeline.
		/// </summary>
		/// <param name="endpoints">The <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> to add the route to.</param>
		/// <param name="pattern">The route pattern.</param>
		/// <param name="options">Options used to configure the connection.</param>
		/// <param name="configure">A callback to configure the connection.</param>
		/// <returns>An <see cref="T:Microsoft.AspNetCore.Builder.ConnectionEndpointRouteBuilder" /> for endpoints associated with the connections.</returns>
		public static ConnectionEndpointRouteBuilder MapConnections(this IEndpointRouteBuilder endpoints, string pattern, HttpConnectionDispatcherOptions options, Action<IConnectionBuilder> configure)
		{
			throw null;
		}
	}
}
