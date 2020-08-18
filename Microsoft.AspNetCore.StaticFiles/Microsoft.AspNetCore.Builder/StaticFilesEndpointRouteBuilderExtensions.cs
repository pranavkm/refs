using Microsoft.AspNetCore.Routing;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// Contains extension methods for using static files with endpoint routing.
	/// </summary>
	public static class StaticFilesEndpointRouteBuilderExtensions
	{
		/// <summary>
		/// Adds a specialized <see cref="T:Microsoft.AspNetCore.Routing.RouteEndpoint" /> to the <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> that will match
		/// requests for non-filenames with the lowest possible priority. The request will be routed to a
		/// <see cref="T:Microsoft.AspNetCore.StaticFiles.StaticFileMiddleware" /> that attempts to serve the file specified by <paramref name="filePath" />.
		/// </summary>
		/// <param name="endpoints">The <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" />.</param>
		/// <param name="filePath">The file path of the file to serve.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /></returns>
		/// <remarks>
		/// <para>
		/// <see cref="M:Microsoft.AspNetCore.Builder.StaticFilesEndpointRouteBuilderExtensions.MapFallbackToFile(Microsoft.AspNetCore.Routing.IEndpointRouteBuilder,System.String)" /> is intended to handle cases where URL path of
		/// the request does not contain a filename, and no other endpoint has matched. This is convenient for routing
		/// requests for dynamic content to a SPA framework, while also allowing requests for non-existent files to
		/// result in an HTTP 404.
		/// </para>
		/// <para>
		/// The default <see cref="T:Microsoft.AspNetCore.Builder.StaticFileOptions" /> for the <see cref="T:Microsoft.AspNetCore.StaticFiles.StaticFileMiddleware" /> will be used.
		/// </para>
		/// <para>
		/// <see cref="M:Microsoft.AspNetCore.Builder.StaticFilesEndpointRouteBuilderExtensions.MapFallbackToFile(Microsoft.AspNetCore.Routing.IEndpointRouteBuilder,System.String)" /> registers an endpoint using the pattern
		/// <c>{*path:nonfile}</c>. The order of the registered endpoint will be <c>int.MaxValue</c>.
		/// </para>
		/// </remarks>
		public static IEndpointConventionBuilder MapFallbackToFile(this IEndpointRouteBuilder endpoints, string filePath)
		{
			throw null;
		}

		/// <summary>
		/// Adds a specialized <see cref="T:Microsoft.AspNetCore.Routing.RouteEndpoint" /> to the <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> that will match
		/// requests for non-filenames with the lowest possible priority. The request will be routed to a
		/// <see cref="T:Microsoft.AspNetCore.StaticFiles.StaticFileMiddleware" /> that attempts to serve the file specified by <paramref name="filePath" />.
		/// </summary>
		/// <param name="endpoints">The <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" />.</param>
		/// <param name="filePath">The file path of the file to serve.</param>
		/// <param name="options"><see cref="T:Microsoft.AspNetCore.Builder.StaticFileOptions" /> for the <see cref="T:Microsoft.AspNetCore.StaticFiles.StaticFileMiddleware" />.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /></returns>
		/// <remarks>
		/// <para>
		/// <see cref="M:Microsoft.AspNetCore.Builder.StaticFilesEndpointRouteBuilderExtensions.MapFallbackToFile(Microsoft.AspNetCore.Routing.IEndpointRouteBuilder,System.String,Microsoft.AspNetCore.Builder.StaticFileOptions)" /> is intended to handle cases
		/// where URL path of the request does not contain a file name, and no other endpoint has matched. This is convenient
		/// for routing requests for dynamic content to a SPA framework, while also allowing requests for non-existent files to
		/// result in an HTTP 404.
		/// </para>
		/// <para>
		/// <see cref="M:Microsoft.AspNetCore.Builder.StaticFilesEndpointRouteBuilderExtensions.MapFallbackToFile(Microsoft.AspNetCore.Routing.IEndpointRouteBuilder,System.String,Microsoft.AspNetCore.Builder.StaticFileOptions)" /> registers an endpoint using the pattern
		/// <c>{*path:nonfile}</c>. The order of the registered endpoint will be <c>int.MaxValue</c>.
		/// </para>
		/// </remarks>
		public static IEndpointConventionBuilder MapFallbackToFile(this IEndpointRouteBuilder endpoints, string filePath, StaticFileOptions options)
		{
			throw null;
		}

		/// <summary>
		/// Adds a specialized <see cref="T:Microsoft.AspNetCore.Routing.RouteEndpoint" /> to the <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> that will match
		/// requests for non-filenames with the lowest possible priority. The request will be routed to a
		/// <see cref="T:Microsoft.AspNetCore.StaticFiles.StaticFileMiddleware" /> that attempts to serve the file specified by <paramref name="filePath" />.
		/// </summary>
		/// <param name="endpoints">The <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" />.</param>
		/// <param name="pattern">The route pattern.</param>
		/// <param name="filePath">The file path of the file to serve.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /></returns>
		/// <remarks>
		/// <para>
		/// <see cref="M:Microsoft.AspNetCore.Builder.StaticFilesEndpointRouteBuilderExtensions.MapFallbackToFile(Microsoft.AspNetCore.Routing.IEndpointRouteBuilder,System.String,System.String)" /> is intended to handle
		/// cases where URL path of the request does not contain a filename, and no other endpoint has matched. This is
		/// convenient for routing requests for dynamic content to a SPA framework, while also allowing requests for
		/// non-existent files to result in an HTTP 404.
		/// </para>
		/// <para>
		/// The default <see cref="T:Microsoft.AspNetCore.Builder.StaticFileOptions" /> for the <see cref="T:Microsoft.AspNetCore.StaticFiles.StaticFileMiddleware" /> will be used.
		/// </para>
		/// <para>
		/// The order of the registered endpoint will be <c>int.MaxValue</c>.
		/// </para>
		/// <para>
		/// This overload will use the provided <paramref name="pattern" /> verbatim. Use the <c>:nonfile</c> route contraint
		/// to exclude requests for static files.
		/// </para>
		/// </remarks>
		public static IEndpointConventionBuilder MapFallbackToFile(this IEndpointRouteBuilder endpoints, string pattern, string filePath)
		{
			throw null;
		}

		/// <summary>
		/// Adds a specialized <see cref="T:Microsoft.AspNetCore.Routing.RouteEndpoint" /> to the <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /> that will match
		/// requests for non-filenames with the lowest possible priority. The request will be routed to a
		/// <see cref="T:Microsoft.AspNetCore.StaticFiles.StaticFileMiddleware" /> that attempts to serve the file specified by <paramref name="filePath" />.
		/// </summary>
		/// <param name="endpoints">The <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" />.</param>\
		/// <param name="pattern">The route pattern.</param>
		/// <param name="filePath">The file path of the file to serve.</param>
		/// <param name="options"><see cref="T:Microsoft.AspNetCore.Builder.StaticFileOptions" /> for the <see cref="T:Microsoft.AspNetCore.StaticFiles.StaticFileMiddleware" />.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Routing.IEndpointRouteBuilder" /></returns>
		/// <remarks>
		/// <para>
		/// <see cref="M:Microsoft.AspNetCore.Builder.StaticFilesEndpointRouteBuilderExtensions.MapFallbackToFile(Microsoft.AspNetCore.Routing.IEndpointRouteBuilder,System.String,System.String,Microsoft.AspNetCore.Builder.StaticFileOptions)" /> is intended to handle
		/// cases where URL path of the request does not contain a filename, and no other endpoint has matched. This is
		/// convenient for routing requests for dynamic content to a SPA framework, while also allowing requests for
		/// non-existent files to result in an HTTP 404.
		/// </para>
		/// <para>
		/// The order of the registered endpoint will be <c>int.MaxValue</c>.
		/// </para>
		/// <para>
		/// This overload will use the provided <paramref name="pattern" /> verbatim. Use the <c>:nonfile</c> route contraint
		/// to exclude requests for static files.
		/// </para>
		/// </remarks>
		public static IEndpointConventionBuilder MapFallbackToFile(this IEndpointRouteBuilder endpoints, string pattern, string filePath, StaticFileOptions options)
		{
			throw null;
		}
	}
}
