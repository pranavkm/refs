using Microsoft.AspNetCore.Routing;
using System;

namespace Microsoft.AspNetCore.Builder
{
	public static class EndpointRoutingApplicationBuilderExtensions
	{
		/// <summary>
		/// Adds a <see cref="T:Microsoft.AspNetCore.Routing.EndpointRoutingMiddleware" /> middleware to the specified <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> to add the middleware to.</param>
		/// <returns>A reference to this instance after the operation has completed.</returns>
		/// <remarks>
		/// <para>
		/// A call to <see cref="M:Microsoft.AspNetCore.Builder.EndpointRoutingApplicationBuilderExtensions.UseRouting(Microsoft.AspNetCore.Builder.IApplicationBuilder)" /> must be followed by a call to
		/// <see cref="M:Microsoft.AspNetCore.Builder.EndpointRoutingApplicationBuilderExtensions.UseEndpoints(Microsoft.AspNetCore.Builder.IApplicationBuilder,System.Action{Microsoft.AspNetCore.Routing.IEndpointRouteBuilder})" /> for the same <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />
		/// instance.
		/// </para>
		/// <para>
		/// The <see cref="T:Microsoft.AspNetCore.Routing.EndpointRoutingMiddleware" /> defines a point in the middleware pipeline where routing decisions are
		/// made, and an <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> is associated with the <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />. The <see cref="T:Microsoft.AspNetCore.Routing.EndpointMiddleware" />
		/// defines a point in the middleware pipeline where the current <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> is executed. Middleware between
		/// the <see cref="T:Microsoft.AspNetCore.Routing.EndpointRoutingMiddleware" /> and <see cref="T:Microsoft.AspNetCore.Routing.EndpointMiddleware" /> may observe or change the
		/// <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> associated with the <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />.
		/// </para>
		/// </remarks>
		public static IApplicationBuilder UseRouting(this IApplicationBuilder builder)
		{
			throw null;
		}

		/// <summary>
		/// Adds a <see cref="T:Microsoft.AspNetCore.Routing.EndpointMiddleware" /> middleware to the specified <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />
		/// with the <see cref="T:Microsoft.AspNetCore.Routing.EndpointDataSource" /> instances built from configured <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" />.
		/// The <see cref="T:Microsoft.AspNetCore.Routing.EndpointMiddleware" /> will execute the <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> associated with the current
		/// request.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> to add the middleware to.</param>
		/// <param name="configure">An <see cref="T:System.Action`1" /> to configure the provided <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" />.</param>
		/// <returns>A reference to this instance after the operation has completed.</returns>
		/// <remarks>
		/// <para>
		/// A call to <see cref="M:Microsoft.AspNetCore.Builder.EndpointRoutingApplicationBuilderExtensions.UseEndpoints(Microsoft.AspNetCore.Builder.IApplicationBuilder,System.Action{Microsoft.AspNetCore.Routing.IEndpointRouteBuilder})" /> must be preceded by a call to
		/// <see cref="M:Microsoft.AspNetCore.Builder.EndpointRoutingApplicationBuilderExtensions.UseRouting(Microsoft.AspNetCore.Builder.IApplicationBuilder)" /> for the same <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />
		/// instance.
		/// </para>
		/// <para>
		/// The <see cref="T:Microsoft.AspNetCore.Routing.EndpointRoutingMiddleware" /> defines a point in the middleware pipeline where routing decisions are
		/// made, and an <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> is associated with the <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />. The <see cref="T:Microsoft.AspNetCore.Routing.EndpointMiddleware" />
		/// defines a point in the middleware pipeline where the current <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> is executed. Middleware between
		/// the <see cref="T:Microsoft.AspNetCore.Routing.EndpointRoutingMiddleware" /> and <see cref="T:Microsoft.AspNetCore.Routing.EndpointMiddleware" /> may observe or change the
		/// <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> associated with the <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />.
		/// </para>
		/// </remarks>
		public static IApplicationBuilder UseEndpoints(this IApplicationBuilder builder, Action<IEndpointRouteBuilder> configure)
		{
			throw null;
		}
	}
}
