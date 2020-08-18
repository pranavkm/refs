using Microsoft.AspNetCore.Routing;
using System;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Extension methods for adding the <see cref="T:Microsoft.AspNetCore.Builder.RouterMiddleware" /> middleware to an <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.
	/// </summary>
	public static class RoutingBuilderExtensions
	{
		/// <summary>
		/// Adds a <see cref="T:Microsoft.AspNetCore.Builder.RouterMiddleware" /> middleware to the specified <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> with the specified <see cref="T:Microsoft.AspNetCore.Routing.IRouter" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> to add the middleware to.</param>
		/// <param name="router">The <see cref="T:Microsoft.AspNetCore.Routing.IRouter" /> to use for routing requests.</param>
		/// <returns>A reference to this instance after the operation has completed.</returns>
		public static IApplicationBuilder UseRouter(this IApplicationBuilder builder, IRouter router)
		{
			throw null;
		}

		/// <summary>
		/// Adds a <see cref="T:Microsoft.AspNetCore.Builder.RouterMiddleware" /> middleware to the specified <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />
		/// with the <see cref="T:Microsoft.AspNetCore.Routing.IRouter" /> built from configured <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> to add the middleware to.</param>
		/// <param name="action">An <see cref="T:System.Action`1" /> to configure the provided <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" />.</param>
		/// <returns>A reference to this instance after the operation has completed.</returns>
		public static IApplicationBuilder UseRouter(this IApplicationBuilder builder, Action<IRouteBuilder> action)
		{
			throw null;
		}
	}
}
