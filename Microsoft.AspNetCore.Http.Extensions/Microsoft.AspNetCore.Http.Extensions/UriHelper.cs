using System;

namespace Microsoft.AspNetCore.Http.Extensions
{
	/// <summary>
	/// A helper class for constructing encoded Uris for use in headers and other Uris.
	/// </summary>
	public static class UriHelper
	{
		/// <summary>
		/// Combines the given URI components into a string that is properly encoded for use in HTTP headers.
		/// </summary>
		/// <param name="pathBase">The first portion of the request path associated with application root.</param>
		/// <param name="path">The portion of the request path that identifies the requested resource.</param>
		/// <param name="query">The query, if any.</param>
		/// <param name="fragment">The fragment, if any.</param>
		/// <returns>The combined URI components, properly encoded for use in HTTP headers.</returns>
		public static string BuildRelative(PathString pathBase = default(PathString), PathString path = default(PathString), QueryString query = default(QueryString), FragmentString fragment = default(FragmentString))
		{
			throw null;
		}

		/// <summary>
		/// Combines the given URI components into a string that is properly encoded for use in HTTP headers.
		/// Note that unicode in the HostString will be encoded as punycode.
		/// </summary>
		/// <param name="scheme">http, https, etc.</param>
		/// <param name="host">The host portion of the uri normally included in the Host header. This may include the port.</param>
		/// <param name="pathBase">The first portion of the request path associated with application root.</param>
		/// <param name="path">The portion of the request path that identifies the requested resource.</param>
		/// <param name="query">The query, if any.</param>
		/// <param name="fragment">The fragment, if any.</param>
		/// <returns>The combined URI components, properly encoded for use in HTTP headers.</returns>
		public static string BuildAbsolute(string scheme, HostString host, PathString pathBase = default(PathString), PathString path = default(PathString), QueryString query = default(QueryString), FragmentString fragment = default(FragmentString))
		{
			throw null;
		}

		/// <summary>
		/// Separates the given absolute URI string into components. Assumes no PathBase.
		/// </summary>
		/// <param name="uri">A string representation of the uri.</param>
		/// <param name="scheme">http, https, etc.</param>
		/// <param name="host">The host portion of the uri normally included in the Host header. This may include the port.</param>
		/// <param name="path">The portion of the request path that identifies the requested resource.</param>
		/// <param name="query">The query, if any.</param>
		/// <param name="fragment">The fragment, if any.</param>
		public static void FromAbsolute(string uri, out string scheme, out HostString host, out PathString path, out QueryString query, out FragmentString fragment)
		{
			throw null;
		}

		/// <summary>
		/// Generates a string from the given absolute or relative Uri that is appropriately encoded for use in
		/// HTTP headers. Note that a unicode host name will be encoded as punycode.
		/// </summary>
		/// <param name="uri">The Uri to encode.</param>
		/// <returns>The encoded string version of <paramref name="uri" />.</returns>
		public static string Encode(Uri uri)
		{
			throw null;
		}

		/// <summary>
		/// Returns the combined components of the request URL in a fully escaped form suitable for use in HTTP headers
		/// and other HTTP operations.
		/// </summary>
		/// <param name="request">The request to assemble the uri pieces from.</param>
		/// <returns>The encoded string version of the URL from <paramref name="request" />.</returns>
		public static string GetEncodedUrl(this HttpRequest request)
		{
			throw null;
		}

		/// <summary>
		/// Returns the relative URI.
		/// </summary>
		/// <param name="request">The request to assemble the uri pieces from.</param>
		/// <returns>The path and query off of <paramref name="request" />.</returns>
		public static string GetEncodedPathAndQuery(this HttpRequest request)
		{
			throw null;
		}

		/// <summary>
		/// Returns the combined components of the request URL in a fully un-escaped form (except for the QueryString)
		/// suitable only for display. This format should not be used in HTTP headers or other HTTP operations.
		/// </summary>
		/// <param name="request">The request to assemble the uri pieces from.</param>
		/// <returns>The combined components of the request URL in a fully un-escaped form (except for the QueryString)
		/// suitable only for display.</returns>
		public static string GetDisplayUrl(this HttpRequest request)
		{
			throw null;
		}
	}
}
