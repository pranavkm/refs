using Microsoft.Extensions.Primitives;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.WebUtilities
{
	/// <summary>
	/// Provides methods for parsing and manipulating query strings.
	/// </summary>
	public static class QueryHelpers
	{
		/// <summary>
		/// Append the given query key and value to the URI.
		/// </summary>
		/// <param name="uri">The base URI.</param>
		/// <param name="name">The name of the query key.</param>
		/// <param name="value">The query value.</param>
		/// <returns>The combined result.</returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="uri" /> is <c>null</c>.</exception>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="name" /> is <c>null</c>.</exception>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="value" /> is <c>null</c>.</exception>
		public static string AddQueryString(string uri, string name, string value)
		{
			throw null;
		}

		/// <summary>
		/// Append the given query keys and values to the URI.
		/// </summary>
		/// <param name="uri">The base URI.</param>
		/// <param name="queryString">A dictionary of query keys and values to append.</param>
		/// <returns>The combined result.</returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="uri" /> is <c>null</c>.</exception>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="queryString" /> is <c>null</c>.</exception>
		public static string AddQueryString(string uri, IDictionary<string, string?> queryString)
		{
			throw null;
		}

		/// <summary>
		/// Append the given query keys and values to the URI.
		/// </summary>
		/// <param name="uri">The base URI.</param>
		/// <param name="queryString">A collection of query names and values to append.</param>
		/// <returns>The combined result.</returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="uri" /> is <c>null</c>.</exception>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="queryString" /> is <c>null</c>.</exception>
		public static string AddQueryString(string uri, IEnumerable<KeyValuePair<string, StringValues>> queryString)
		{
			throw null;
		}

		/// <summary>
		/// Append the given query keys and values to the URI.
		/// </summary>
		/// <param name="uri">The base URI.</param>
		/// <param name="queryString">A collection of name value query pairs to append.</param>
		/// <returns>The combined result.</returns>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="uri" /> is <c>null</c>.</exception>
		/// <exception cref="T:System.ArgumentNullException"><paramref name="queryString" /> is <c>null</c>.</exception>
		public static string AddQueryString(string uri, IEnumerable<KeyValuePair<string, string?>> queryString)
		{
			throw null;
		}

		/// <summary>
		/// Parse a query string into its component key and value parts.
		/// </summary>
		/// <param name="queryString">The raw query string value, with or without the leading '?'.</param>
		/// <returns>A collection of parsed keys and values.</returns>
		public static Dictionary<string, StringValues> ParseQuery(string queryString)
		{
			throw null;
		}

		/// <summary>
		/// Parse a query string into its component key and value parts.
		/// </summary>
		/// <param name="queryString">The raw query string value, with or without the leading '?'.</param>
		/// <returns>A collection of parsed keys and values, null if there are no entries.</returns>
		public static Dictionary<string, StringValues>? ParseNullableQuery(string queryString)
		{
			throw null;
		}
	}
}
