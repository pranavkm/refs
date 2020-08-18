using System.Buffers;

namespace System.Net.Http
{
	/// <summary>
	/// Variable length integer encoding and decoding methods. Based on https://tools.ietf.org/html/draft-ietf-quic-transport-24#section-16.
	/// A variable-length integer can use 1, 2, 4, or 8 bytes.
	/// </summary>
	internal static class VariableLengthIntegerHelper
	{
		public const int MaximumEncodedLength = 8;

		public const uint OneByteLimit = 63u;

		public static bool TryRead(ReadOnlySpan<byte> buffer, out long value, out int bytesRead)
		{
			throw null;
		}

		public static bool TryRead(ref SequenceReader<byte> reader, out long value)
		{
			throw null;
		}

		public static long GetInteger(in ReadOnlySequence<byte> buffer, out SequencePosition consumed, out SequencePosition examined)
		{
			throw null;
		}

		public static bool TryWrite(Span<byte> buffer, long longToEncode, out int bytesWritten)
		{
			throw null;
		}

		public static int WriteInteger(Span<byte> buffer, long longToEncode)
		{
			throw null;
		}

		public static int GetByteCount(long value)
		{
			throw null;
		}
	}
}
