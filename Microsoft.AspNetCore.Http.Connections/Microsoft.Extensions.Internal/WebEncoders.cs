using System;

namespace Microsoft.Extensions.Internal
{
	/// <summary>
	/// Contains utility APIs to assist with common encoding and decoding operations.
	/// </summary>
	internal static class WebEncoders
	{
		/// <summary>
		/// Decodes a base64url-encoded string.
		/// </summary>
		/// <param name="input">The base64url-encoded input to decode.</param>
		/// <returns>The base64url-decoded form of the input.</returns>
		/// <remarks>
		/// The input must not contain any whitespace or padding characters.
		/// Throws <see cref="T:System.FormatException" /> if the input is malformed.
		/// </remarks>
		public static byte[] Base64UrlDecode(string input)
		{
			throw null;
		}

		/// <summary>
		/// Decodes a base64url-encoded substring of a given string.
		/// </summary>
		/// <param name="input">A string containing the base64url-encoded input to decode.</param>
		/// <param name="offset">The position in <paramref name="input" /> at which decoding should begin.</param>
		/// <param name="count">The number of characters in <paramref name="input" /> to decode.</param>
		/// <returns>The base64url-decoded form of the input.</returns>
		/// <remarks>
		/// The input must not contain any whitespace or padding characters.
		/// Throws <see cref="T:System.FormatException" /> if the input is malformed.
		/// </remarks>
		public static byte[] Base64UrlDecode(string input, int offset, int count)
		{
			throw null;
		}

		/// <summary>
		/// Decodes a base64url-encoded <paramref name="input" /> into a <c>byte[]</c>.
		/// </summary>
		/// <param name="input">A string containing the base64url-encoded input to decode.</param>
		/// <param name="offset">The position in <paramref name="input" /> at which decoding should begin.</param>
		/// <param name="buffer">
		/// Scratch buffer to hold the <see cref="T:System.Char" />s to decode. Array must be large enough to hold
		/// <paramref name="bufferOffset" /> and <paramref name="count" /> characters as well as Base64 padding
		/// characters. Content is not preserved.
		/// </param>
		/// <param name="bufferOffset">
		/// The offset into <paramref name="buffer" /> at which to begin writing the <see cref="T:System.Char" />s to decode.
		/// </param>
		/// <param name="count">The number of characters in <paramref name="input" /> to decode.</param>
		/// <returns>The base64url-decoded form of the <paramref name="input" />.</returns>
		/// <remarks>
		/// The input must not contain any whitespace or padding characters.
		/// Throws <see cref="T:System.FormatException" /> if the input is malformed.
		/// </remarks>
		public static byte[] Base64UrlDecode(string input, int offset, char[] buffer, int bufferOffset, int count)
		{
			throw null;
		}

		/// <summary>
		/// Gets the minimum <c>char[]</c> size required for decoding of <paramref name="count" /> characters
		/// with the <see cref="M:Microsoft.Extensions.Internal.WebEncoders.Base64UrlDecode(System.String,System.Int32,System.Char[],System.Int32,System.Int32)" /> method.
		/// </summary>
		/// <param name="count">The number of characters to decode.</param>
		/// <returns>
		/// The minimum <c>char[]</c> size required for decoding  of <paramref name="count" /> characters.
		/// </returns>
		public static int GetArraySizeRequiredToDecode(int count)
		{
			throw null;
		}

		/// <summary>
		/// Encodes <paramref name="input" /> using base64url encoding.
		/// </summary>
		/// <param name="input">The binary input to encode.</param>
		/// <returns>The base64url-encoded form of <paramref name="input" />.</returns>
		public static string Base64UrlEncode(byte[] input)
		{
			throw null;
		}

		/// <summary>
		/// Encodes <paramref name="input" /> using base64url encoding.
		/// </summary>
		/// <param name="input">The binary input to encode.</param>
		/// <param name="offset">The offset into <paramref name="input" /> at which to begin encoding.</param>
		/// <param name="count">The number of bytes from <paramref name="input" /> to encode.</param>
		/// <returns>The base64url-encoded form of <paramref name="input" />.</returns>
		public static string Base64UrlEncode(byte[] input, int offset, int count)
		{
			throw null;
		}

		/// <summary>
		/// Encodes <paramref name="input" /> using base64url encoding.
		/// </summary>
		/// <param name="input">The binary input to encode.</param>
		/// <param name="offset">The offset into <paramref name="input" /> at which to begin encoding.</param>
		/// <param name="output">
		/// Buffer to receive the base64url-encoded form of <paramref name="input" />. Array must be large enough to
		/// hold <paramref name="outputOffset" /> characters and the full base64-encoded form of
		/// <paramref name="input" />, including padding characters.
		/// </param>
		/// <param name="outputOffset">
		/// The offset into <paramref name="output" /> at which to begin writing the base64url-encoded form of
		/// <paramref name="input" />.
		/// </param>
		/// <param name="count">The number of <c>byte</c>s from <paramref name="input" /> to encode.</param>
		/// <returns>
		/// The number of characters written to <paramref name="output" />, less any padding characters.
		/// </returns>
		public static int Base64UrlEncode(byte[] input, int offset, char[] output, int outputOffset, int count)
		{
			throw null;
		}

		/// <summary>
		/// Get the minimum output <c>char[]</c> size required for encoding <paramref name="count" />
		/// <see cref="T:System.Byte" />s with the <see cref="M:Microsoft.Extensions.Internal.WebEncoders.Base64UrlEncode(System.Byte[],System.Int32,System.Char[],System.Int32,System.Int32)" /> method.
		/// </summary>
		/// <param name="count">The number of characters to encode.</param>
		/// <returns>
		/// The minimum output <c>char[]</c> size required for encoding <paramref name="count" /> <see cref="T:System.Byte" />s.
		/// </returns>
		public static int GetArraySizeRequiredToEncode(int count)
		{
			throw null;
		}

		/// <summary>
		/// Encodes <paramref name="input" /> using base64url encoding.
		/// </summary>
		/// <param name="input">The binary input to encode.</param>
		/// <returns>The base64url-encoded form of <paramref name="input" />.</returns>
		public static string Base64UrlEncode(ReadOnlySpan<byte> input)
		{
			throw null;
		}
	}
}
