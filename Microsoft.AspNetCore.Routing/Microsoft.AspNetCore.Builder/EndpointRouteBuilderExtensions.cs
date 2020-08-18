using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Routing.Patterns;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Provides extension methods for <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> to add endpoints.
	/// </summary>
	public static class EndpointRouteBuilderExtensions
	{
		/// <summary>
		/// Adds a <see cref="T:Microsoft.AspNetCore.Routing.RouteEndpoint" /> to the <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> that matches HTTP GET requests
		/// for the specified pattern.
		/// </summary>
		/// <param name="endpoints">The <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> to add the route to.</param>
		/// <param name="pattern">The route pattern.</param>
		/// <param name="requestDelegate">The delegate executed when the endpoint is matched.</param>
		/// <returns>A <see cref="T:Microsoft.AspNetCore.Builder.IEndpointConventionBuilder" /> that can be used to further customize the endpoint.</returns>
		public static IEndpointConventionBuilder MapGet(this IEndpointRouteBuilder endpoints, string pattern, RequestDelegate requestDelegate)
		{
			throw null;
		}

		/// <summary>
		/// Adds a <see cref="T:Microsoft.AspNetCore.Routing.RouteEndpoint" /> to the <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> that matches HTTP POST requests
		/// for the specified pattern.
		/// </summary>
		/// <param name="endpoints">The <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> to add the route to.</param>
		/// <param name="pattern">The route pattern.</param>
		/// <param name="requestDelegate">The delegate executed when the endpoint is matched.</param>
		/// <returns>A <see cref="T:Microsoft.AspNetCore.Builder.IEndpointConventionBuilder" /> that can be used to further customize the endpoint.</returns>
		public static IEndpointConventionBuilder MapPost(this IEndpointRouteBuilder endpoints, string pattern, RequestDelegate requestDelegate)
		{
			throw null;
		}

		/// <summary>
		/// Adds a <see cref="T:Microsoft.AspNetCore.Routing.RouteEndpoint" /> to the <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> that matches HTTP PUT requests
		/// for the specified pattern.
		/// </summary>
		/// <param name="endpoints">The <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> to add the route to.</param>
		/// <param name="pattern">The route pattern.</param>
		/// <param name="requestDelegate">The delegate executed when the endpoint is matched.</param>
		/// <returns>A <see cref="T:Microsoft.AspNetCore.Builder.IEndpointConventionBuilder" /> that can be used to further customize the endpoint.</returns>
		public static IEndpointConventionBuilder MapPut(this IEndpointRouteBuilder endpoints, string pattern, RequestDelegate requestDelegate)
		{
			throw null;
		}

		/// <summary>
		/// Adds a <see cref="T:Microsoft.AspNetCore.Routing.RouteEndpoint" /> to the <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> that matches HTTP DELETE requests
		/// for the specified pattern.
		/// </summary>
		/// <param name="endpoints">The <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> to add the route to.</param>
		/// <param name="pattern">The route pattern.</param>
		/// <param name="requestDelegate">The delegate executed when the endpoint is matched.</param>
		/// <returns>A <see cref="T:Microsoft.AspNetCore.Builder.IEndpointConventionBuilder" /> that can be used to further customize the endpoint.</returns>
		public static IEndpointConventionBuilder MapDelete(this IEndpointRouteBuilder endpoints, string pattern, RequestDelegate requestDelegate)
		{
			throw null;
		}

		/// <summary>
		/// Adds a <see cref="T:Microsoft.AspNetCore.Routing.RouteEndpoint" /> to the <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> that matches HTTP requests
		/// for the specified HTTP methods and pattern.
		/// </summary>
		/// <param name="endpoints">The <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> to add the route to.</param>
		/// <param name="pattern">The route pattern.</param>
		/// <param name="requestDelegate">The delegate executed when the endpoint is matched.</param>
		/// <param name="httpMethods">HTTP methods that the endpoint will match.</param>
		/// <returns>A <see cref="T:Microsoft.AspNetCore.Builder.IEndpointConventionBuilder" /> that can be used to further customize the endpoint.</returns>
		public static IEndpointConventionBuilder MapMethods(this IEndpointRouteBuilder endpoints, string pattern, IEnumerable<string> httpMethods, RequestDelegate requestDelegate)
		{
			throw null;
		}

		/// <summary>
		/// Adds a <see cref="T:Microsoft.AspNetCore.Routing.RouteEndpoint" /> to the <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> that matches HTTP requests
		/// for the specified pattern.
		/// </summary>
		/// <param name="endpoints">The <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> to add the route to.</param>
		/// <param name="pattern">The route pattern.</param>
		/// <param name="requestDelegate">The delegate executed when the endpoint is matched.</param>
		/// <returns>A <see cref="T:Microsoft.AspNetCore.Builder.IEndpointConventionBuilder" /> that can be used to further customize the endpoint.</returns>
		public static IEndpointConventionBuilder Map(this IEndpointRouteBuilder endpoints, string pattern, RequestDelegate requestDelegate)
		{
			throw null;
		}

		/// <summary>
		/// Adds a <see cref="T:Microsoft.AspNetCore.Routing.RouteEndpoint" /> to the <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> that matches HTTP requests
		/// for the specified pattern.
		/// </summary>
		/// <param name="endpoints">The <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> to add the route to.</param>
		/// <param name="pattern">The route pattern.</param>
		/// <param name="requestDelegate">The delegate executed when the endpoint is matched.</param>
		/// <returns>A <see cref="T:Microsoft.AspNetCore.Builder.IEndpointConventionBuilder" /> that can be used to further customize the endpoint.</returns>
		public static IEndpointConventionBuilder Map(this IEndpointRouteBuilder endpoints, RoutePattern pattern, RequestDelegate requestDelegate)
		{
			throw null;
		}
	}
}
