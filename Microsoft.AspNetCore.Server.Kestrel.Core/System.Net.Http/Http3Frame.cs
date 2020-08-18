namespace System.Net.Http
{
	internal static class Http3Frame
	{
		public const int MaximumEncodedFrameEnvelopeLength = 9;

		/// <summary>
		/// Reads two variable-length integers.
		/// </summary>
		public static bool TryReadIntegerPair(ReadOnlySpan<byte> buffer, out long a, out long b, out int bytesRead)
		{
			throw null;
		}

		public static bool TryWriteFrameEnvelope(Http3FrameType frameType, long payloadLength, Span<byte> buffer, out int bytesWritten)
		{
			throw null;
		}
	}
}
