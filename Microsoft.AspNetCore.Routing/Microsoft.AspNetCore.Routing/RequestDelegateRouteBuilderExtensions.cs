using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Routing
{
	public static class RequestDelegateRouteBuilderExtensions
	{
		/// <summary>
		/// Adds a route to the <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" /> for the given <paramref name="template" />, and
		/// <paramref name="handler" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" />.</param>
		/// <param name="template">The route template.</param>
		/// <param name="handler">The <see cref="T:Microsoft.AspNetCore.Http.RequestDelegate" /> route handler.</param>
		/// <returns>A reference to the <paramref name="builder" /> after this operation has completed.</returns>
		public static IRouteBuilder MapRoute(this IRouteBuilder builder, string template, RequestDelegate handler)
		{
			throw null;
		}

		/// <summary>
		/// Adds a route to the <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" /> for the given <paramref name="template" />, and
		/// <paramref name="action" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" />.</param>
		/// <param name="template">The route template.</param>
		/// <param name="action">The action to apply to the <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</param>
		/// <returns>A reference to the <paramref name="builder" /> after this operation has completed.</returns>
		public static IRouteBuilder MapMiddlewareRoute(this IRouteBuilder builder, string template, Action<IApplicationBuilder> action)
		{
			throw null;
		}

		/// <summary>
		/// Adds a route to the <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" /> that only matches HTTP DELETE requests for the given
		/// <paramref name="template" />, and <paramref name="handler" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" />.</param>
		/// <param name="template">The route template.</param>
		/// <param name="handler">The <see cref="T:Microsoft.AspNetCore.Http.RequestDelegate" /> route handler.</param>
		/// <returns>A reference to the <paramref name="builder" /> after this operation has completed.</returns>
		public static IRouteBuilder MapDelete(this IRouteBuilder builder, string template, RequestDelegate handler)
		{
			throw null;
		}

		/// <summary>
		/// Adds a route to the <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" /> that only matches HTTP DELETE requests for the given
		/// <paramref name="template" />, and <paramref name="action" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" />.</param>
		/// <param name="template">The route template.</param>
		/// <param name="action">The action to apply to the <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</param>
		/// <returns>A reference to the <paramref name="builder" /> after this operation has completed.</returns>
		public static IRouteBuilder MapMiddlewareDelete(this IRouteBuilder builder, string template, Action<IApplicationBuilder> action)
		{
			throw null;
		}

		/// <summary>
		/// Adds a route to the <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" /> that only matches HTTP DELETE requests for the given
		/// <paramref name="template" />, and <paramref name="handler" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" />.</param>
		/// <param name="template">The route template.</param>
		/// <param name="handler">The route handler.</param>
		/// <returns>A reference to the <paramref name="builder" /> after this operation has completed.</returns>
		public static IRouteBuilder MapDelete(this IRouteBuilder builder, string template, Func<HttpRequest, HttpResponse, RouteData, Task> handler)
		{
			throw null;
		}

		/// <summary>
		/// Adds a route to the <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" /> that only matches HTTP GET requests for the given
		/// <paramref name="template" />, and <paramref name="handler" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" />.</param>
		/// <param name="template">The route template.</param>
		/// <param name="handler">The <see cref="T:Microsoft.AspNetCore.Http.RequestDelegate" /> route handler.</param>
		/// <returns>A reference to the <paramref name="builder" /> after this operation has completed.</returns>
		public static IRouteBuilder MapGet(this IRouteBuilder builder, string template, RequestDelegate handler)
		{
			throw null;
		}

		/// <summary>
		/// Adds a route to the <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" /> that only matches HTTP GET requests for the given
		/// <paramref name="template" />, and <paramref name="action" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" />.</param>
		/// <param name="template">The route template.</param>
		/// <param name="action">The action to apply to the <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</param>
		/// <returns>A reference to the <paramref name="builder" /> after this operation has completed.</returns>
		public static IRouteBuilder MapMiddlewareGet(this IRouteBuilder builder, string template, Action<IApplicationBuilder> action)
		{
			throw null;
		}

		/// <summary>
		/// Adds a route to the <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" /> that only matches HTTP GET requests for the given
		/// <paramref name="template" />, and <paramref name="handler" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" />.</param>
		/// <param name="template">The route template.</param>
		/// <param name="handler">The route handler.</param>
		/// <returns>A reference to the <paramref name="builder" /> after this operation has completed.</returns>
		public static IRouteBuilder MapGet(this IRouteBuilder builder, string template, Func<HttpRequest, HttpResponse, RouteData, Task> handler)
		{
			throw null;
		}

		/// <summary>
		/// Adds a route to the <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" /> that only matches HTTP POST requests for the given
		/// <paramref name="template" />, and <paramref name="handler" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" />.</param>
		/// <param name="template">The route template.</param>
		/// <param name="handler">The <see cref="T:Microsoft.AspNetCore.Http.RequestDelegate" /> route handler.</param>
		/// <returns>A reference to the <paramref name="builder" /> after this operation has completed.</returns>
		public static IRouteBuilder MapPost(this IRouteBuilder builder, string template, RequestDelegate handler)
		{
			throw null;
		}

		/// <summary>
		/// Adds a route to the <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" /> that only matches HTTP POST requests for the given
		/// <paramref name="template" />, and <paramref name="action" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" />.</param>
		/// <param name="template">The route template.</param>
		/// <param name="action">The action to apply to the <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</param>
		/// <returns>A reference to the <paramref name="builder" /> after this operation has completed.</returns>
		public static IRouteBuilder MapMiddlewarePost(this IRouteBuilder builder, string template, Action<IApplicationBuilder> action)
		{
			throw null;
		}

		/// <summary>
		/// Adds a route to the <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" /> that only matches HTTP POST requests for the given
		/// <paramref name="template" />, and <paramref name="handler" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" />.</param>
		/// <param name="template">The route template.</param>
		/// <param name="handler">The route handler.</param>
		/// <returns>A reference to the <paramref name="builder" /> after this operation has completed.</returns>
		public static IRouteBuilder MapPost(this IRouteBuilder builder, string template, Func<HttpRequest, HttpResponse, RouteData, Task> handler)
		{
			throw null;
		}

		/// <summary>
		/// Adds a route to the <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" /> that only matches HTTP PUT requests for the given
		/// <paramref name="template" />, and <paramref name="handler" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" />.</param>
		/// <param name="template">The route template.</param>
		/// <param name="handler">The <see cref="T:Microsoft.AspNetCore.Http.RequestDelegate" /> route handler.</param>
		/// <returns>A reference to the <paramref name="builder" /> after this operation has completed.</returns>
		public static IRouteBuilder MapPut(this IRouteBuilder builder, string template, RequestDelegate handler)
		{
			throw null;
		}

		/// <summary>
		/// Adds a route to the <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" /> that only matches HTTP PUT requests for the given
		/// <paramref name="template" />, and <paramref name="action" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" />.</param>
		/// <param name="template">The route template.</param>
		/// <param name="action">The action to apply to the <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</param>
		/// <returns>A reference to the <paramref name="builder" /> after this operation has completed.</returns>
		public static IRouteBuilder MapMiddlewarePut(this IRouteBuilder builder, string template, Action<IApplicationBuilder> action)
		{
			throw null;
		}

		/// <summary>
		/// Adds a route to the <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" /> that only matches HTTP PUT requests for the given
		/// <paramref name="template" />, and <paramref name="handler" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" />.</param>
		/// <param name="template">The route template.</param>
		/// <param name="handler">The route handler.</param>
		/// <returns>A reference to the <paramref name="builder" /> after this operation has completed.</returns>
		public static IRouteBuilder MapPut(this IRouteBuilder builder, string template, Func<HttpRequest, HttpResponse, RouteData, Task> handler)
		{
			throw null;
		}

		/// <summary>
		/// Adds a route to the <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" /> that only matches HTTP requests for the given
		/// <paramref name="verb" />, <paramref name="template" />, and <paramref name="handler" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" />.</param>
		/// <param name="verb">The HTTP verb allowed by the route.</param>
		/// <param name="template">The route template.</param>
		/// <param name="handler">The route handler.</param>
		/// <returns>A reference to the <paramref name="builder" /> after this operation has completed.</returns>
		public static IRouteBuilder MapVerb(this IRouteBuilder builder, string verb, string template, Func<HttpRequest, HttpResponse, RouteData, Task> handler)
		{
			throw null;
		}

		/// <summary>
		/// Adds a route to the <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" /> that only matches HTTP requests for the given
		/// <paramref name="verb" />, <paramref name="template" />, and <paramref name="handler" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" />.</param>
		/// <param name="verb">The HTTP verb allowed by the route.</param>
		/// <param name="template">The route template.</param>
		/// <param name="handler">The <see cref="T:Microsoft.AspNetCore.Http.RequestDelegate" /> route handler.</param>
		/// <returns>A reference to the <paramref name="builder" /> after this operation has completed.</returns>
		public static IRouteBuilder MapVerb(this IRouteBuilder builder, string verb, string template, RequestDelegate handler)
		{
			throw null;
		}

		/// <summary>
		/// Adds a route to the <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" /> that only matches HTTP requests for the given
		/// <paramref name="verb" />, <paramref name="template" />, and <paramref name="action" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" />.</param>
		/// <param name="verb">The HTTP verb allowed by the route.</param>
		/// <param name="template">The route template.</param>
		/// <param name="action">The action to apply to the <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</param>
		/// <returns>A reference to the <paramref name="builder" /> after this operation has completed.</returns>
		public static IRouteBuilder MapMiddlewareVerb(this IRouteBuilder builder, string verb, string template, Action<IApplicationBuilder> action)
		{
			throw null;
		}
	}
}
