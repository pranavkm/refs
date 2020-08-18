using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Extension methods for using <see cref="T:Microsoft.AspNetCore.Routing.LinkGenerator" /> with and endpoint name.
	/// </summary>
	public static class LinkGeneratorEndpointNameAddressExtensions
	{
		/// <summary>
		/// Generates a URI with an absolute path based on the provided values.
		/// </summary>
		/// <param name="generator">The <see cref="T:Microsoft.AspNetCore.Routing.LinkGenerator" />.</param>
		/// <param name="httpContext">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> associated with the current request.</param>
		/// <param name="endpointName">The endpoint name. Used to resolve endpoints.</param>
		/// <param name="values">The route values. Used to expand parameters in the route template. Optional.</param>
		/// <param name="pathBase">
		/// An optional URI path base. Prepended to the path in the resulting URI. If not provided, the value of <see cref="P:Microsoft.AspNetCore.Http.HttpRequest.PathBase" /> will be used.
		/// </param>
		/// <param name="fragment">An optional URI fragment. Appended to the resulting URI.</param>
		/// <param name="options">
		/// An optional <see cref="T:Microsoft.AspNetCore.Routing.LinkOptions" />. Settings on provided object override the settings with matching
		/// names from <c>RouteOptions</c>.
		/// </param>
		/// <returns>A URI with an absolute path, or <c>null</c>.</returns>
		public static string? GetPathByName(this LinkGenerator generator, HttpContext httpContext, string endpointName, object? values, PathString? pathBase = null, FragmentString fragment = default(FragmentString), LinkOptions? options = null)
		{
			throw null;
		}

		/// <summary>
		/// Generates a URI with an absolute path based on the provided values.
		/// </summary>
		/// <param name="generator">The <see cref="T:Microsoft.AspNetCore.Routing.LinkGenerator" />.</param>
		/// <param name="endpointName">The endpoint name. Used to resolve endpoints.</param>
		/// <param name="values">The route values. Used to expand parameters in the route template. Optional.</param>
		/// <param name="pathBase">An optional URI path base. Prepended to the path in the resulting URI.</param>
		/// <param name="fragment">An optional URI fragment. Appended to the resulting URI.</param>
		/// <param name="options">
		/// An optional <see cref="T:Microsoft.AspNetCore.Routing.LinkOptions" />. Settings on provided object override the settings with matching
		/// names from <c>RouteOptions</c>.
		/// </param>
		/// <returns>A URI with an absolute path, or <c>null</c>.</returns>
		public static string? GetPathByName(this LinkGenerator generator, string endpointName, object? values, PathString pathBase = default(PathString), FragmentString fragment = default(FragmentString), LinkOptions? options = null)
		{
			throw null;
		}

		/// <summary>
		/// Generates an absolute URI based on the provided values.
		/// </summary>
		/// <param name="generator">The <see cref="T:Microsoft.AspNetCore.Routing.LinkGenerator" />.</param>
		/// <param name="httpContext">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> associated with the current request.</param>
		/// <param name="endpointName">The endpoint name. Used to resolve endpoints.</param>
		/// <param name="values">The route values. Used to expand parameters in the route template. Optional.</param>
		/// <param name="scheme">
		/// The URI scheme, applied to the resulting URI. Optional. If not provided, the value of <see cref="P:Microsoft.AspNetCore.Http.HttpRequest.Scheme" /> will be used.
		/// </param>
		/// <param name="host">
		/// The URI host/authority, applied to the resulting URI. Optional. If not provided, the value <see cref="P:Microsoft.AspNetCore.Http.HttpRequest.Host" /> will be used.
		/// See the remarks section for details about the security implications of the <paramref name="host" />.
		/// </param>
		/// <param name="pathBase">
		/// An optional URI path base. Prepended to the path in the resulting URI. If not provided, the value of <see cref="P:Microsoft.AspNetCore.Http.HttpRequest.PathBase" /> will be used.
		/// </param>
		/// <param name="fragment">An optional URI fragment. Appended to the resulting URI.</param>
		/// <param name="options">
		/// An optional <see cref="T:Microsoft.AspNetCore.Routing.LinkOptions" />. Settings on provided object override the settings with matching
		/// names from <c>RouteOptions</c>.
		/// </param>
		/// <returns>A URI with an absolute path, or <c>null</c>.</returns>
		/// <remarks>
		/// <para>
		/// The value of <paramref name="host" /> should be a trusted value. Relying on the value of the current request
		/// can allow untrusted input to influence the resulting URI unless the <c>Host</c> header has been validated.
		/// See the deployment documentation for instructions on how to properly validate the <c>Host</c> header in
		/// your deployment environment.
		/// </para>
		/// </remarks>
		public static string? GetUriByName(this LinkGenerator generator, HttpContext httpContext, string endpointName, object? values, string? scheme = null, HostString? host = null, PathString? pathBase = null, FragmentString fragment = default(FragmentString), LinkOptions? options = null)
		{
			throw null;
		}

		/// <summary>
		/// Generates an absolute URI based on the provided values.
		/// </summary>
		/// <param name="generator">The <see cref="T:Microsoft.AspNetCore.Routing.LinkGenerator" />.</param>
		/// <param name="endpointName">The endpoint name. Used to resolve endpoints.</param>
		/// <param name="values">The route values. Used to expand parameters in the route template. Optional.</param>
		/// <param name="scheme">The URI scheme, applied to the resulting URI.</param>
		/// <param name="host">
		/// The URI host/authority, applied to the resulting URI.
		/// See the remarks section for details about the security implications of the <paramref name="host" />.
		/// </param>
		/// <param name="pathBase">An optional URI path base. Prepended to the path in the resulting URI.</param>
		/// <param name="fragment">An optional URI fragment. Appended to the resulting URI.</param>
		/// <param name="options">
		/// An optional <see cref="T:Microsoft.AspNetCore.Routing.LinkOptions" />. Settings on provided object override the settings with matching
		/// names from <c>RouteOptions</c>.
		/// </param>
		/// <returns>An absolute URI, or <c>null</c>.</returns>
		/// <remarks>
		/// <para>
		/// The value of <paramref name="host" /> should be a trusted value. Relying on the value of the current request
		/// can allow untrusted input to influence the resulting URI unless the <c>Host</c> header has been validated.
		/// See the deployment documentation for instructions on how to properly validate the <c>Host</c> header in
		/// your deployment environment.
		/// </para>
		/// </remarks>
		public static string? GetUriByName(this LinkGenerator generator, string endpointName, object? values, string scheme, HostString host, PathString pathBase = default(PathString), FragmentString fragment = default(FragmentString), LinkOptions? options = null)
		{
			throw null;
		}
	}
}
