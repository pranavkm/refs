using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Extension methods for using <see cref="T:Microsoft.AspNetCore.Routing.LinkParser" /> with an endpoint name.
	/// </summary>
	public static class LinkParserEndpointNameAddressExtensions
	{
		/// <summary>
		/// Attempts to parse the provided <paramref name="path" /> using the route pattern
		/// specified by the <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> matching <paramref name="endpointName" />.
		/// </summary>
		/// <param name="parser">The <see cref="T:Microsoft.AspNetCore.Routing.LinkParser" />.</param>
		/// <param name="endpointName">The endpoint name. Used to resolve endpoints.</param>
		/// <param name="path">The URI path to parse.</param>
		/// <returns>
		/// A <see cref="T:Microsoft.AspNetCore.Routing.RouteValueDictionary" /> with the parsed values if parsing is successful; 
		/// otherwise <c>null</c>.
		/// </returns>
		/// <remarks>
		/// <para>
		/// <see cref="M:Microsoft.AspNetCore.Routing.LinkParserEndpointNameAddressExtensions.ParsePathByEndpointName(Microsoft.AspNetCore.Routing.LinkParser,System.String,Microsoft.AspNetCore.Http.PathString)" /> will attempt to first resolve
		/// <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> instances that match <paramref name="endpointName" /> and then use the route
		/// pattern associated with each endpoint to parse the URL path. 
		/// </para>
		/// <para>
		/// The parsing operation will fail and return <c>null</c> if either no endpoints are found or none
		/// of the route patterns match the provided URI path.
		/// </para>
		/// </remarks>
		public static RouteValueDictionary? ParsePathByEndpointName(this LinkParser parser, string endpointName, PathString path)
		{
			throw null;
		}
	}
}
