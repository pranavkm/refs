using System.Collections.Generic;
using System.Text;

namespace System.Net.Http.QPack
{
	internal class QPackEncoder
	{
		public static bool EncodeStaticIndexedHeaderField(int index, Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		public static byte[] EncodeStaticIndexedHeaderFieldToArray(int index)
		{
			throw null;
		}

		public static bool EncodeLiteralHeaderFieldWithStaticNameReference(int index, string value, Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		public static bool EncodeLiteralHeaderFieldWithStaticNameReference(int index, string value, Encoding? valueEncoding, Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		/// <summary>
		/// Encodes just the name part of a Literal Header Field With Static Name Reference. Must call <see cref="M:System.Net.Http.QPack.QPackEncoder.EncodeValueString(System.String,System.Text.Encoding,System.Span{System.Byte},System.Int32@)" /> after to encode the header's value.
		/// </summary>
		public static byte[] EncodeLiteralHeaderFieldWithStaticNameReferenceToArray(int index)
		{
			throw null;
		}

		public static byte[] EncodeLiteralHeaderFieldWithStaticNameReferenceToArray(int index, string value)
		{
			throw null;
		}

		public static bool EncodeLiteralHeaderFieldWithoutNameReference(string name, string value, Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		public static bool EncodeLiteralHeaderFieldWithoutNameReference(string name, string value, Encoding? valueEncoding, Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		/// <summary>
		/// Encodes a Literal Header Field Without Name Reference, building the value by concatenating a collection of strings with separators.
		/// </summary>
		public static bool EncodeLiteralHeaderFieldWithoutNameReference(string name, ReadOnlySpan<string> values, string valueSeparator, Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		public static bool EncodeLiteralHeaderFieldWithoutNameReference(string name, ReadOnlySpan<string> values, string valueSeparator, Encoding? valueEncoding, Span<byte> destination, out int bytesWritten)
		{
			throw null;
		}

		/// <summary>
		/// Encodes just the value part of a Literawl Header Field Without Static Name Reference. Must call <see cref="M:System.Net.Http.QPack.QPackEncoder.EncodeValueString(System.String,System.Text.Encoding,System.Span{System.Byte},System.Int32@)" /> after to encode the header's value.
		/// </summary>
		public static byte[] EncodeLiteralHeaderFieldWithoutNameReferenceToArray(string name)
		{
			throw null;
		}

		public static byte[] EncodeLiteralHeaderFieldWithoutNameReferenceToArray(string name, string value)
		{
			throw null;
		}

		/// <summary>
		/// Encodes a value by concatenating a collection of strings, separated by a separator string.
		/// </summary>
		public static bool EncodeValueString(ReadOnlySpan<string> values, string? separator, Span<byte> buffer, out int length)
		{
			throw null;
		}

		public static bool EncodeValueString(ReadOnlySpan<string> values, string? separator, Encoding? valueEncoding, Span<byte> buffer, out int length)
		{
			throw null;
		}

		public bool BeginEncode(IEnumerable<KeyValuePair<string, string>> headers, Span<byte> buffer, out int length)
		{
			throw null;
		}

		public bool BeginEncode(int statusCode, IEnumerable<KeyValuePair<string, string>> headers, Span<byte> buffer, out int length)
		{
			throw null;
		}

		public bool Encode(Span<byte> buffer, out int length)
		{
			throw null;
		}

		public QPackEncoder()
		{
			throw null;
		}
	}
}
