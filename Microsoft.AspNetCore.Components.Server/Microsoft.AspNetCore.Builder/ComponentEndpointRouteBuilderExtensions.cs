using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Routing;
using System;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Extensions for <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" />.
	/// </summary>
	public static class ComponentEndpointRouteBuilderExtensions
	{
		/// <summary>
		/// Maps the Blazor <see cref="T:Microsoft.AspNetCore.SignalR.Hub" /> to the default path.
		/// </summary>
		/// <param name="endpoints">The <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" />.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Builder.ComponentEndpointConventionBuilder" />.</returns>
		public static ComponentEndpointConventionBuilder MapBlazorHub(this IEndpointRouteBuilder endpoints)
		{
			throw null;
		}

		/// <summary>
		/// Maps the Blazor <see cref="T:Microsoft.AspNetCore.SignalR.Hub" /> to the path <paramref name="path" />.
		/// </summary>
		/// <param name="endpoints">The <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" />.</param>
		/// <param name="path">The path to map the Blazor <see cref="T:Microsoft.AspNetCore.SignalR.Hub" />.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Builder.ComponentEndpointConventionBuilder" />.</returns>
		public static ComponentEndpointConventionBuilder MapBlazorHub(this IEndpointRouteBuilder endpoints, string path)
		{
			throw null;
		}

		/// <summary>
		///             Maps the Blazor <see cref="T:Microsoft.AspNetCore.SignalR.Hub" /> to the default path.
		/// </summary>
		/// <param name="endpoints">The <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" />.</param>
		/// <param name="configureOptions">A callback to configure dispatcher options.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Builder.ComponentEndpointConventionBuilder" />.</returns>
		public static ComponentEndpointConventionBuilder MapBlazorHub(this IEndpointRouteBuilder endpoints, Action<HttpConnectionDispatcherOptions> configureOptions)
		{
			throw null;
		}

		/// <summary>
		/// Maps the Blazor <see cref="T:Microsoft.AspNetCore.SignalR.Hub" /> to the path <paramref name="path" />.
		/// </summary>
		/// <param name="endpoints">The <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" />.</param>
		/// <param name="path">The path to map the Blazor <see cref="T:Microsoft.AspNetCore.SignalR.Hub" />.</param>
		/// <param name="configureOptions">A callback to configure dispatcher options.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Builder.ComponentEndpointConventionBuilder" />.</returns>
		public static ComponentEndpointConventionBuilder MapBlazorHub(this IEndpointRouteBuilder endpoints, string path, Action<HttpConnectionDispatcherOptions> configureOptions)
		{
			throw null;
		}
	}
}
