using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// Provides correct handling for QueryString value when needed to reconstruct a request or redirect URI string
	/// </summary>
	public readonly struct QueryString : IEquatable<QueryString>
	{
		/// <summary>
		/// Represents the empty query string. This field is read-only.
		/// </summary>
		public static readonly QueryString Empty;

		/// <summary>
		/// The escaped query string with the leading '?' character
		/// </summary>
		public string? Value
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// True if the query string is not empty
		/// </summary>
		public bool HasValue
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initialize the query string with a given value. This value must be in escaped and delimited format with
		/// a leading '?' character. 
		/// </summary>
		/// <param name="value">The query string to be assigned to the Value property.</param>
		[System.Runtime.CompilerServices.NullableContext(2)]
		public QueryString(string? value)
		{
			throw null;
		}

		/// <summary>
		/// Provides the query string escaped in a way which is correct for combining into the URI representation. 
		/// A leading '?' character will be included unless the Value is null or empty. Characters which are potentially
		/// dangerous are escaped.
		/// </summary>
		/// <returns>The query string value</returns>
		public override string ToString()
		{
			throw null;
		}

		/// <summary>
		/// Provides the query string escaped in a way which is correct for combining into the URI representation. 
		/// A leading '?' character will be included unless the Value is null or empty. Characters which are potentially
		/// dangerous are escaped.
		/// </summary>
		/// <returns>The query string value</returns>
		public string ToUriComponent()
		{
			throw null;
		}

		/// <summary>
		/// Returns an QueryString given the query as it is escaped in the URI format. The string MUST NOT contain any
		/// value that is not a query.
		/// </summary>
		/// <param name="uriComponent">The escaped query as it appears in the URI format.</param>
		/// <returns>The resulting QueryString</returns>
		public static QueryString FromUriComponent(string uriComponent)
		{
			throw null;
		}

		/// <summary>
		/// Returns an QueryString given the query as from a Uri object. Relative Uri objects are not supported.
		/// </summary>
		/// <param name="uri">The Uri object</param>
		/// <returns>The resulting QueryString</returns>
		public static QueryString FromUriComponent(Uri uri)
		{
			throw null;
		}

		/// <summary>
		/// Create a query string with a single given parameter name and value.
		/// </summary>
		/// <param name="name">The un-encoded parameter name</param>
		/// <param name="value">The un-encoded parameter value</param>
		/// <returns>The resulting QueryString</returns>
		public static QueryString Create(string name, string value)
		{
			throw null;
		}

		/// <summary>
		/// Creates a query string composed from the given name value pairs.
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns>The resulting QueryString</returns>
		public static QueryString Create(IEnumerable<KeyValuePair<string, string?>> parameters)
		{
			throw null;
		}

		/// <summary>
		/// Creates a query string composed from the given name value pairs.
		/// </summary>
		/// <param name="parameters"></param>
		/// <returns>The resulting QueryString</returns>
		public static QueryString Create(IEnumerable<KeyValuePair<string, StringValues>> parameters)
		{
			throw null;
		}

		public QueryString Add(QueryString other)
		{
			throw null;
		}

		public QueryString Add(string name, string value)
		{
			throw null;
		}

		public bool Equals(QueryString other)
		{
			throw null;
		}

		public override bool Equals(object? obj)
		{
			throw null;
		}

		public override int GetHashCode()
		{
			throw null;
		}

		public static bool operator ==(QueryString left, QueryString right)
		{
			throw null;
		}

		public static bool operator !=(QueryString left, QueryString right)
		{
			throw null;
		}

		public static QueryString operator +(QueryString left, QueryString right)
		{
			throw null;
		}
	}
}
