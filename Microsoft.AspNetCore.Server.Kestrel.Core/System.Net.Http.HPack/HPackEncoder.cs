using System.Text;

namespace System.Net.Http.HPack
{
	internal class HPackEncoder
	{
		public const int DefaultHeaderTableSize = 4096;

		internal readonly EncoderHeaderEntry Head;

		/// <summary>Encodes an "Indexed Header Field".</summary>
		public static bool EncodeIndexedHeaderField(int index, Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		/// <summary>Encodes the status code of a response to the :status field.</summary>
		public static bool EncodeStatusHeader(int statusCode, Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		/// <summary>Encodes a "Literal Header Field without Indexing".</summary>
		public static bool EncodeLiteralHeaderFieldWithoutIndexing(int index, string value, Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		/// <summary>Encodes a "Literal Header Field never Indexing".</summary>
		public static bool EncodeLiteralHeaderFieldNeverIndexing(int index, string value, Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		/// <summary>Encodes a "Literal Header Field with Indexing".</summary>
		public static bool EncodeLiteralHeaderFieldIndexing(int index, string value, Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		/// <summary>
		/// Encodes a "Literal Header Field without Indexing", but only the index portion;
		/// a subsequent call to <c>EncodeStringLiteral</c> must be used to encode the associated value.
		/// </summary>
		public static bool EncodeLiteralHeaderFieldWithoutIndexing(int index, Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		/// <summary>Encodes a "Literal Header Field with Indexing - New Name".</summary>
		public static bool EncodeLiteralHeaderFieldIndexingNewName(string name, string value, Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		/// <summary>Encodes a "Literal Header Field without Indexing - New Name".</summary>
		public static bool EncodeLiteralHeaderFieldWithoutIndexingNewName(string name, string value, Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		/// <summary>Encodes a "Literal Header Field never Indexing - New Name".</summary>
		public static bool EncodeLiteralHeaderFieldNeverIndexingNewName(string name, string value, Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		/// <summary>Encodes a "Literal Header Field without Indexing - New Name".</summary>
		public static bool EncodeLiteralHeaderFieldWithoutIndexingNewName(string name, ReadOnlySpan<string> values, string separator, Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		public static bool EncodeLiteralHeaderFieldWithoutIndexingNewName(string name, ReadOnlySpan<string> values, string separator, Encoding? valueEncoding, Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		/// <summary>
		/// Encodes a "Literal Header Field without Indexing - New Name", but only the name portion;
		/// a subsequent call to <c>EncodeStringLiteral</c> must be used to encode the associated value.
		/// </summary>
		public static bool EncodeLiteralHeaderFieldWithoutIndexingNewName(string name, Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		public static bool EncodeStringLiteral(ReadOnlySpan<byte> value, Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		public static bool EncodeStringLiteral(string value, Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		public static bool EncodeStringLiteral(string value, Encoding? valueEncoding, Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		public static bool EncodeDynamicTableSizeUpdate(int value, Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		public static bool EncodeStringLiterals(ReadOnlySpan<string> values, string? separator, Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		public static bool EncodeStringLiterals(ReadOnlySpan<string> values, string? separator, Encoding? valueEncoding, Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		/// <summary>
		/// Encodes a "Literal Header Field without Indexing" to a new array, but only the index portion;
		/// a subsequent call to <c>EncodeStringLiteral</c> must be used to encode the associated value.
		/// </summary>
		public static byte[] EncodeLiteralHeaderFieldWithoutIndexingToAllocatedArray(int index)
		{
			throw null;
		}

		/// <summary>
		/// Encodes a "Literal Header Field without Indexing - New Name" to a new array, but only the name portion;
		/// a subsequent call to <c>EncodeStringLiteral</c> must be used to encode the associated value.
		/// </summary>
		public static byte[] EncodeLiteralHeaderFieldWithoutIndexingNewNameToAllocatedArray(string name)
		{
			throw null;
		}

		/// <summary>Encodes a "Literal Header Field without Indexing" to a new array.</summary>
		public static byte[] EncodeLiteralHeaderFieldWithoutIndexingToAllocatedArray(int index, string value)
		{
			throw null;
		}

		public HPackEncoder(bool allowDynamicCompression = true, uint maxHeaderTableSize = 4096u)
		{
			throw null;
		}

		public void UpdateMaxHeaderTableSize(uint maxHeaderTableSize)
		{
			throw null;
		}

		public bool EnsureDynamicTableSizeUpdate(Span<byte> buffer, out int length)
		{
			throw null;
		}

		public bool EncodeHeader(Span<byte> buffer, int staticTableIndex, HeaderEncodingHint encodingHint, string name, string value, out int bytesWritten)
		{
			throw null;
		}
	}
}
