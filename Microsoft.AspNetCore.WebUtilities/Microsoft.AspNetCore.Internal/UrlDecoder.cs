using System;

namespace Microsoft.AspNetCore.Internal
{
	internal class UrlDecoder
	{
		/// <summary>
		/// Unescape a URL path
		/// </summary>
		/// <param name="source">The byte span represents a UTF8 encoding url path.</param>
		/// <param name="destination">The byte span where unescaped url path is copied to.</param>
		/// <param name="isFormEncoding">Whether we are doing form encoding or not.</param>
		/// <returns>The length of the byte sequence of the unescaped url path.</returns>
		public static int DecodeRequestLine(ReadOnlySpan<byte> source, Span<byte> destination, bool isFormEncoding)
		{
			throw null;
		}

		/// <summary>
		/// Unescape a URL path in place.
		/// </summary>
		/// <param name="buffer">The byte span represents a UTF8 encoding url path.</param>
		/// <param name="isFormEncoding">Whether we are doing form encoding or not.</param>
		/// <returns>The number of the bytes representing the result.</returns>
		/// <remarks>
		/// The unescape is done in place, which means after decoding the result is the subset of
		/// the input span.
		/// </remarks>
		public static int DecodeInPlace(Span<byte> buffer, bool isFormEncoding)
		{
			throw null;
		}

		public UrlDecoder()
		{
			throw null;
		}
	}
}
