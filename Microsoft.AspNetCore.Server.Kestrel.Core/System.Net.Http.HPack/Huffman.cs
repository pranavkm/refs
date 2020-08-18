namespace System.Net.Http.HPack
{
	internal class Huffman
	{
		public static (uint encoded, int bitLength) Encode(int data)
		{
			throw null;
		}

		/// <summary>
		/// Decodes a Huffman encoded string from a byte array.
		/// </summary>
		/// <param name="src">The source byte array containing the encoded data.</param>
		/// <param name="dstArray">The destination byte array to store the decoded data.  This may grow if its size is insufficient.</param>
		/// <returns>The number of decoded symbols.</returns>
		public static int Decode(ReadOnlySpan<byte> src, ref byte[] dstArray)
		{
			throw null;
		}

		/// <summary>
		/// Decodes a single symbol from a 32-bit word.
		/// </summary>
		/// <param name="data">A 32-bit word containing a Huffman encoded symbol.</param>
		/// <param name="validBits">
		/// The number of bits in <paramref name="data" /> that may contain an encoded symbol.
		/// This is not the exact number of bits that encode the symbol. Instead, it prevents
		/// decoding the lower bits of <paramref name="data" /> if they don't contain any
		/// encoded data.
		/// </param>
		/// <param name="decodedBits">The number of bits decoded from <paramref name="data" />.</param>
		/// <returns>The decoded symbol.</returns>
		internal static int DecodeValue(uint data, int validBits, out int decodedBits)
		{
			throw null;
		}

		public Huffman()
		{
			throw null;
		}
	}
}
