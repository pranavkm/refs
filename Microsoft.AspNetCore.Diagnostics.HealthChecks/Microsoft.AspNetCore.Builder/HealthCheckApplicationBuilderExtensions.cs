using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" /> extension methods for the <see cref="T:Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckMiddleware" />.
	/// </summary>
	public static class HealthCheckApplicationBuilderExtensions
	{
		/// <summary>
		/// Adds a middleware that provides health check status.
		/// </summary>
		/// <param name="app">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</param>
		/// <param name="path">The path on which to provide health check status.</param>
		/// <returns>A reference to the <paramref name="app" /> after the operation has completed.</returns>
		/// <remarks>
		/// <para>
		/// If <paramref name="path" /> is set to <c>null</c> or the empty string then the health check middleware
		/// will ignore the URL path and process all requests. If <paramref name="path" /> is set to a non-empty
		/// value, the health check middleware will process requests with a URL that matches the provided value
		/// of <paramref name="path" /> case-insensitively, allowing for an extra trailing slash ('/') character.
		/// </para>
		/// <para>
		/// The health check middleware will use default settings from <see cref="T:Microsoft.Extensions.Options.IOptions`1" />.
		/// </para>
		/// </remarks>
		public static IApplicationBuilder UseHealthChecks(this IApplicationBuilder app, PathString path)
		{
			throw null;
		}

		/// <summary>
		/// Adds a middleware that provides health check status.
		/// </summary>
		/// <param name="app">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</param>
		/// <param name="path">The path on which to provide health check status.</param>
		/// <param name="options">A <see cref="T:Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckOptions" /> used to configure the middleware.</param>
		/// <returns>A reference to the <paramref name="app" /> after the operation has completed.</returns>
		/// <remarks>
		/// <para>
		/// If <paramref name="path" /> is set to <c>null</c> or the empty string then the health check middleware
		/// will ignore the URL path and process all requests. If <paramref name="path" /> is set to a non-empty
		/// value, the health check middleware will process requests with a URL that matches the provided value
		/// of <paramref name="path" /> case-insensitively, allowing for an extra trailing slash ('/') character.
		/// </para>
		/// </remarks>
		public static IApplicationBuilder UseHealthChecks(this IApplicationBuilder app, PathString path, HealthCheckOptions options)
		{
			throw null;
		}

		/// <summary>
		/// Adds a middleware that provides health check status.
		/// </summary>
		/// <param name="app">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</param>
		/// <param name="path">The path on which to provide health check status.</param>
		/// <param name="port">The port to listen on. Must be a local port on which the server is listening.</param>
		/// <returns>A reference to the <paramref name="app" /> after the operation has completed.</returns>
		/// <remarks>
		/// <para>
		/// If <paramref name="path" /> is set to <c>null</c> or the empty string then the health check middleware
		/// will ignore the URL path and process all requests on the specified port. If <paramref name="path" /> is
		/// set to a non-empty value, the health check middleware will process requests with a URL that matches the
		/// provided value of <paramref name="path" /> case-insensitively, allowing for an extra trailing slash ('/')
		/// character.
		/// </para>
		/// <para>
		/// The health check middleware will use default settings from <see cref="T:Microsoft.Extensions.Options.IOptions`1" />.
		/// </para>
		/// </remarks>
		public static IApplicationBuilder UseHealthChecks(this IApplicationBuilder app, PathString path, int port)
		{
			throw null;
		}

		/// <summary>
		/// Adds a middleware that provides health check status.
		/// </summary>
		/// <param name="app">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</param>
		/// <param name="path">The path on which to provide health check status.</param>
		/// <param name="port">The port to listen on. Must be a local port on which the server is listening.</param>
		/// <returns>A reference to the <paramref name="app" /> after the operation has completed.</returns>
		/// <remarks>
		/// <para>
		/// If <paramref name="path" /> is set to <c>null</c> or the empty string then the health check middleware
		/// will ignore the URL path and process all requests on the specified port. If <paramref name="path" /> is
		/// set to a non-empty value, the health check middleware will process requests with a URL that matches the
		/// provided value of <paramref name="path" /> case-insensitively, allowing for an extra trailing slash ('/')
		/// character.
		/// </para>
		/// <para>
		/// The health check middleware will use default settings from <see cref="T:Microsoft.Extensions.Options.IOptions`1" />.
		/// </para>
		/// </remarks>
		public static IApplicationBuilder UseHealthChecks(this IApplicationBuilder app, PathString path, string port)
		{
			throw null;
		}

		/// <summary>
		/// Adds a middleware that provides health check status.
		/// </summary>
		/// <param name="app">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</param>
		/// <param name="path">The path on which to provide health check status.</param>
		/// <param name="port">The port to listen on. Must be a local port on which the server is listening.</param>
		/// <param name="options">A <see cref="T:Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckOptions" /> used to configure the middleware.</param>
		/// <returns>A reference to the <paramref name="app" /> after the operation has completed.</returns>
		/// <remarks>
		/// <para>
		/// If <paramref name="path" /> is set to <c>null</c> or the empty string then the health check middleware
		/// will ignore the URL path and process all requests on the specified port. If <paramref name="path" /> is
		/// set to a non-empty value, the health check middleware will process requests with a URL that matches the
		/// provided value of <paramref name="path" /> case-insensitively, allowing for an extra trailing slash ('/')
		/// character.
		/// </para>
		/// </remarks>
		public static IApplicationBuilder UseHealthChecks(this IApplicationBuilder app, PathString path, int port, HealthCheckOptions options)
		{
			throw null;
		}

		/// <summary>
		/// Adds a middleware that provides health check status.
		/// </summary>
		/// <param name="app">The <see cref="T:Microsoft.AspNetCore.Builder.IApplicationBuilder" />.</param>
		/// <param name="path">The path on which to provide health check status.</param>
		/// <param name="port">The port to listen on. Must be a local port on which the server is listening.</param>
		/// <param name="options">A <see cref="T:Microsoft.AspNetCore.Diagnostics.HealthChecks.HealthCheckOptions" /> used to configure the middleware.</param>
		/// <returns>A reference to the <paramref name="app" /> after the operation has completed.</returns>
		/// <remarks>
		/// <para>
		/// If <paramref name="path" /> is set to <c>null</c> or the empty string then the health check middleware
		/// will ignore the URL path and process all requests on the specified port. If <paramref name="path" /> is
		/// set to a non-empty value, the health check middleware will process requests with a URL that matches the
		/// provided value of <paramref name="path" /> case-insensitively, allowing for an extra trailing slash ('/')
		/// character.
		/// </para>
		/// </remarks>
		public static IApplicationBuilder UseHealthChecks(this IApplicationBuilder app, PathString path, string port, HealthCheckOptions options)
		{
			throw null;
		}
	}
}
