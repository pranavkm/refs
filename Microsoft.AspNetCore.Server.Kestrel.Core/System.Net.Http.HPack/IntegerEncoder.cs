namespace System.Net.Http.HPack
{
	internal static class IntegerEncoder
	{
		/// <summary>
		/// The maximum bytes required to encode a 32-bit int, regardless of prefix length.
		/// </summary>
		public const int MaxInt32EncodedLength = 6;

		/// <summary>
		/// Encodes an integer into one or more bytes.
		/// </summary>
		/// <param name="value">The value to encode. Must not be negative.</param>
		/// <param name="numBits">The length of the prefix, in bits, to encode <paramref name="value" /> within. Must be between 1 and 8.</param>
		/// <param name="destination">The destination span to encode <paramref name="value" /> to.</param>
		/// <param name="bytesWritten">The number of bytes used to encode <paramref name="value" />.</param>
		/// <returns>If <paramref name="destination" /> had enough storage to encode <paramref name="value" />, true. Otherwise, false.</returns>
		public static bool Encode(int value, int numBits, Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}
	}
}
