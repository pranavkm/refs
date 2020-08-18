using System;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// Contains methods to verify the request protocol version of an HTTP request. 
	/// </summary>
	public static class HttpProtocol
	{
		public static readonly string Http10;

		public static readonly string Http11;

		public static readonly string Http2;

		public static readonly string Http3;

		/// <summary>
		/// Returns a value that indicates if the HTTP request protocol is HTTP/1.0. 
		/// </summary>
		/// <param name="protocol">The HTTP request protocol.</param>
		/// <returns>
		/// <see langword="true" /> if the protocol is HTTP/1.0; otherwise, <see langword="false" />.
		/// </returns>
		public static bool IsHttp10(string protocol)
		{
			throw null;
		}

		/// <summary>
		/// Returns a value that indicates if the HTTP request protocol is HTTP/1.1. 
		/// </summary>
		/// <param name="protocol">The HTTP request protocol.</param>
		/// <returns>
		/// <see langword="true" /> if the protocol is HTTP/1.1; otherwise, <see langword="false" />.
		/// </returns>
		public static bool IsHttp11(string protocol)
		{
			throw null;
		}

		/// <summary>
		/// Returns a value that indicates if the HTTP request protocol is HTTP/2. 
		/// </summary>
		/// <param name="protocol">The HTTP request protocol.</param>
		/// <returns>
		/// <see langword="true" /> if the protocol is HTTP/2; otherwise, <see langword="false" />.
		/// </returns>
		public static bool IsHttp2(string protocol)
		{
			throw null;
		}

		/// <summary>
		/// Returns a value that indicates if the HTTP request protocol is HTTP/3. 
		/// </summary>
		/// <param name="protocol">The HTTP request protocol.</param>
		/// <returns>
		/// <see langword="true" /> if the protocol is HTTP/3; otherwise, <see langword="false" />.
		/// </returns>
		public static bool IsHttp3(string protocol)
		{
			throw null;
		}

		/// <summary>
		/// Gets the HTTP request protocol for the specified <see cref="T:System.Version" />.
		/// </summary>
		/// <param name="version">The version.</param>
		/// <returns>A HTTP request protocol.</returns>
		public static string GetHttpProtocol(Version version)
		{
			throw null;
		}
	}
}
