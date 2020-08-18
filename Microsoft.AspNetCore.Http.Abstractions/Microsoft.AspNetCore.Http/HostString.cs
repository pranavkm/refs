using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// Represents the host portion of a URI can be used to construct URI's properly formatted and encoded for use in
	/// HTTP headers.
	/// </summary>
	public readonly struct HostString : IEquatable<HostString>
	{
		private readonly string _value;

		/// <summary>
		/// Returns the original value from the constructor.
		/// </summary>
		public string Value
		{
			get
			{
				throw null;
			}
		}

		public bool HasValue
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Returns the value of the host part of the value. The port is removed if it was present.
		/// IPv6 addresses will have brackets added if they are missing.
		/// </summary>
		/// <returns>The host portion of the value.</returns>
		public string Host
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Returns the value of the port part of the host, or <value>null</value> if none is found.
		/// </summary>
		/// <returns>The port portion of the value.</returns>
		public int? Port
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new HostString without modification. The value should be Unicode rather than punycode, and may have a port.
		/// IPv4 and IPv6 addresses are also allowed, and also may have ports.
		/// </summary>
		/// <param name="value"></param>
		public HostString(string value)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new HostString from its host and port parts.
		/// </summary>
		/// <param name="host">The value should be Unicode rather than punycode. IPv6 addresses must use square braces.</param>
		/// <param name="port">A positive, greater than 0 value representing the port in the host string.</param>
		public HostString(string host, int port)
		{
			throw null;
		}

		/// <summary>
		/// Returns the value as normalized by ToUriComponent().
		/// </summary>
		/// <returns>The value as normalized by <see cref="M:Microsoft.AspNetCore.Http.HostString.ToUriComponent" />.</returns>
		public override string ToString()
		{
			throw null;
		}

		/// <summary>
		/// Returns the value properly formatted and encoded for use in a URI in a HTTP header.
		/// Any Unicode is converted to punycode. IPv6 addresses will have brackets added if they are missing.
		/// </summary>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Http.HostString" /> value formated for use in a URI or HTTP header.</returns>
		public string ToUriComponent()
		{
			throw null;
		}

		/// <summary>
		/// Creates a new HostString from the given URI component.
		/// Any punycode will be converted to Unicode.
		/// </summary>
		/// <param name="uriComponent">The URI component string to create a <see cref="T:Microsoft.AspNetCore.Http.HostString" /> from.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Http.HostString" /> that was created.</returns>
		public static HostString FromUriComponent(string uriComponent)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new HostString from the host and port of the give Uri instance.
		/// Punycode will be converted to Unicode.
		/// </summary>
		/// <param name="uri">The <see cref="T:System.Uri" /> to create a <see cref="T:Microsoft.AspNetCore.Http.HostString" /> from.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Http.HostString" /> that was created.</returns>
		public static HostString FromUriComponent(Uri uri)
		{
			throw null;
		}

		/// <summary>
		/// Matches the host portion of a host header value against a list of patterns.
		/// The host may be the encoded punycode or decoded unicode form so long as the pattern
		/// uses the same format.
		/// </summary>
		/// <param name="value">Host header value with or without a port.</param>
		/// <param name="patterns">A set of pattern to match, without ports.</param>
		/// <remarks>
		/// The port on the given value is ignored. The patterns should not have ports.
		/// The patterns may be exact matches like "example.com", a top level wildcard "*"
		/// that matches all hosts, or a subdomain wildcard like "*.example.com" that matches
		/// "abc.example.com:443" but not "example.com:443".
		/// Matching is case insensitive.
		/// </remarks>
		/// <returns><see langword="true" /> if <paramref name="value" /> matches any of the patterns.</returns>
		public static bool MatchesAny(StringSegment value, IList<StringSegment> patterns)
		{
			throw null;
		}

		/// <summary>
		/// Compares the equality of the Value property, ignoring case.
		/// </summary>
		/// <param name="other">The <see cref="T:Microsoft.AspNetCore.Http.HostString" /> to compare against.</param>
		/// <returns><see langword="true" /> if they have the same value.</returns>
		public bool Equals(HostString other)
		{
			throw null;
		}

		/// <summary>
		/// Compares against the given object only if it is a HostString.
		/// </summary>
		/// <param name="obj">The <see cref="T:System.Object" /> to compare against.</param>
		/// <returns><see langword="true" /> if they have the same value.</returns>
		public override bool Equals(object? obj)
		{
			throw null;
		}

		/// <summary>
		/// Gets a hash code for the value.
		/// </summary>
		/// <returns>The hash code as an <see cref="T:System.Int32" />.</returns>
		public override int GetHashCode()
		{
			throw null;
		}

		/// <summary>
		/// Compares the two instances for equality.
		/// </summary>
		/// <param name="left">The left parameter.</param>
		/// <param name="right">The right parameter.</param>
		/// <returns><see langword="true" /> if both <see cref="T:Microsoft.AspNetCore.Http.HostString" />'s have the same value.</returns>
		public static bool operator ==(HostString left, HostString right)
		{
			throw null;
		}

		/// <summary>
		/// Compares the two instances for inequality.
		/// </summary>
		/// <param name="left">The left parameter.</param>
		/// <param name="right">The right parameter.</param>
		/// <returns><see langword="true" /> if both <see cref="T:Microsoft.AspNetCore.Http.HostString" />'s values are not equal.</returns>
		public static bool operator !=(HostString left, HostString right)
		{
			throw null;
		}
	}
}
