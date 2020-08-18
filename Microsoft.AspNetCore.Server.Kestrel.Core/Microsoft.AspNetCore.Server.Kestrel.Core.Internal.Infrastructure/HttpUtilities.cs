using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
	internal static class HttpUtilities
	{
		private sealed class UTF8EncodingSealed : UTF8Encoding
		{
			public UTF8EncodingSealed()
			{
				throw null;
			}

			public override byte[] GetPreamble()
			{
				throw null;
			}
		}

		public const string HttpUriScheme = "http://";

		public const string HttpsUriScheme = "https://";

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static string GetHeaderName(this ReadOnlySpan<byte> span)
		{
			throw null;
		}

		public static string GetAsciiStringNonNullCharacters(this Span<byte> span)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static string GetAsciiStringNonNullCharacters(this ReadOnlySpan<byte> span)
		{
			throw null;
		}

		public static string GetAsciiOrUTF8StringNonNullCharacters(this ReadOnlySpan<byte> span)
		{
			throw null;
		}

		public static string GetRequestHeaderString(this ReadOnlySpan<byte> span, string name, Func<string, Encoding> encodingSelector)
		{
			throw null;
		}

		public static string GetAsciiStringEscaped(this ReadOnlySpan<byte> span, int maxChars)
		{
			throw null;
		}

		/// <summary>
		/// Checks that up to 8 bytes from <paramref name="span" /> correspond to a known HTTP method.
		/// </summary>
		/// <remarks>
		/// A "known HTTP method" can be an HTTP method name defined in the HTTP/1.1 RFC.
		/// Since all of those fit in at most 8 bytes, they can be optimally looked up by reading those bytes as a long. Once
		/// in that format, it can be checked against the known method.
		/// The Known Methods (CONNECT, DELETE, GET, HEAD, PATCH, POST, PUT, OPTIONS, TRACE) are all less than 8 bytes
		/// and will be compared with the required space. A mask is used if the Known method is less than 8 bytes.
		/// To optimize performance the GET method will be checked first.
		/// </remarks>
		/// <returns><c>true</c> if the input matches a known string, <c>false</c> otherwise.</returns>
		public static bool GetKnownMethod(this ReadOnlySpan<byte> span, out HttpMethod method, out int length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static HttpMethod GetKnownMethod(this ReadOnlySpan<byte> span, out int methodLength)
		{
			throw null;
		}

		/// <summary>
		/// Parses string <paramref name="value" /> for a known HTTP method.
		/// </summary>
		/// <remarks>
		/// A "known HTTP method" can be an HTTP method name defined in the HTTP/1.1 RFC.
		/// The Known Methods (CONNECT, DELETE, GET, HEAD, PATCH, POST, PUT, OPTIONS, TRACE)
		/// </remarks>
		/// <returns><see cref="T:Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpMethod" /></returns>
		public static HttpMethod GetKnownMethod(string value)
		{
			throw null;
		}

		/// <summary>
		/// Checks 9 bytes from <paramref name="span" />  correspond to a known HTTP version.
		/// </summary>
		/// <remarks>
		/// A "known HTTP version" Is is either HTTP/1.0 or HTTP/1.1.
		/// Since those fit in 8 bytes, they can be optimally looked up by reading those bytes as a long. Once
		/// in that format, it can be checked against the known versions.
		/// The Known versions will be checked with the required '\r'.
		/// To optimize performance the HTTP/1.1 will be checked first.
		/// </remarks>
		/// <returns><c>true</c> if the input matches a known string, <c>false</c> otherwise.</returns>
		public static bool GetKnownVersion(this ReadOnlySpan<byte> span, out HttpVersion knownVersion, out byte length)
		{
			throw null;
		}

		/// <summary>
		/// Checks 9 bytes from <paramref name="location" />  correspond to a known HTTP version.
		/// </summary>
		/// <remarks>
		/// A "known HTTP version" Is is either HTTP/1.0 or HTTP/1.1.
		/// Since those fit in 8 bytes, they can be optimally looked up by reading those bytes as a long. Once
		/// in that format, it can be checked against the known versions.
		/// The Known versions will be checked with the required '\r'.
		/// To optimize performance the HTTP/1.1 will be checked first.
		/// </remarks>
		/// <returns><c>true</c> if the input matches a known string, <c>false</c> otherwise.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static HttpVersion GetKnownVersionAndConfirmCR(this ReadOnlySpan<byte> location)
		{
			throw null;
		}

		/// <summary>
		/// Checks 8 bytes from <paramref name="span" /> that correspond to 'http://' or 'https://'
		/// </summary>
		/// <param name="span">The span</param>
		/// <param name="knownScheme">A reference to the known scheme, if the input matches any</param>
		/// <returns>True when memory starts with known http or https schema</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool GetKnownHttpScheme(this Span<byte> span, out HttpScheme knownScheme)
		{
			throw null;
		}

		public static string VersionToString(HttpVersion httpVersion)
		{
			throw null;
		}

		public static string MethodToString(HttpMethod method)
		{
			throw null;
		}

		public static string SchemeToString(HttpScheme scheme)
		{
			throw null;
		}

		public static bool IsHostHeaderValid(string hostText)
		{
			throw null;
		}
	}
}
