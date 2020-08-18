using Microsoft.AspNetCore.Routing;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Provides extension methods for <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" /> to add routes.
	/// </summary>
	public static class MapRouteRouteBuilderExtensions
	{
		private class BackCompatInlineConstraintResolver : IInlineConstraintResolver
		{
			public BackCompatInlineConstraintResolver(IInlineConstraintResolver inner, ParameterPolicyFactory parameterPolicyFactory)
			{
				throw null;
			}

			public IRouteConstraint? ResolveConstraint(string inlineConstraint)
			{
				throw null;
			}
		}

		/// <summary>
		/// Adds a route to the <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" /> with the specified name and template.
		/// </summary>
		/// <param name="routeBuilder">The <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" /> to add the route to.</param>
		/// <param name="name">The name of the route.</param>
		/// <param name="template">The URL pattern of the route.</param>
		/// <returns>A reference to this instance after the operation has completed.</returns>
		public static IRouteBuilder MapRoute(this IRouteBuilder routeBuilder, string? name, string? template)
		{
			throw null;
		}

		/// <summary>
		/// Adds a route to the <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" /> with the specified name, template, and default values.
		/// </summary>
		/// <param name="routeBuilder">The <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" /> to add the route to.</param>
		/// <param name="name">The name of the route.</param>
		/// <param name="template">The URL pattern of the route.</param>
		/// <param name="defaults">
		/// An object that contains default values for route parameters. The object's properties represent the names
		/// and values of the default values.
		/// </param>
		/// <returns>A reference to this instance after the operation has completed.</returns>
		public static IRouteBuilder MapRoute(this IRouteBuilder routeBuilder, string? name, string? template, object? defaults)
		{
			throw null;
		}

		/// <summary>
		/// Adds a route to the <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" /> with the specified name, template, default values, and
		/// constraints.
		/// </summary>
		/// <param name="routeBuilder">The <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" /> to add the route to.</param>
		/// <param name="name">The name of the route.</param>
		/// <param name="template">The URL pattern of the route.</param>
		/// <param name="defaults">
		/// An object that contains default values for route parameters. The object's properties represent the names
		/// and values of the default values.
		/// </param>
		/// <param name="constraints">
		/// An object that contains constraints for the route. The object's properties represent the names and values
		/// of the constraints.
		/// </param>
		/// <returns>A reference to this instance after the operation has completed.</returns>
		public static IRouteBuilder MapRoute(this IRouteBuilder routeBuilder, string? name, string? template, object? defaults, object? constraints)
		{
			throw null;
		}

		/// <summary>
		/// Adds a route to the <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" /> with the specified name, template, default values, and
		/// data tokens.
		/// </summary>
		/// <param name="routeBuilder">The <see cref="T:Microsoft.AspNetCore.Routing.IRouteBuilder" /> to add the route to.</param>
		/// <param name="name">The name of the route.</param>
		/// <param name="template">The URL pattern of the route.</param>
		/// <param name="defaults">
		/// An object that contains default values for route parameters. The object's properties represent the names
		/// and values of the default values.
		/// </param>
		/// <param name="constraints">
		/// An object that contains constraints for the route. The object's properties represent the names and values
		/// of the constraints.
		/// </param>
		/// <param name="dataTokens">
		/// An object that contains data tokens for the route. The object's properties represent the names and values
		/// of the data tokens.
		/// </param>
		/// <returns>A reference to this instance after the operation has completed.</returns>
		public static IRouteBuilder MapRoute(this IRouteBuilder routeBuilder, string? name, string? template, object? defaults, object? constraints, object? dataTokens)
		{
			throw null;
		}
	}
}
