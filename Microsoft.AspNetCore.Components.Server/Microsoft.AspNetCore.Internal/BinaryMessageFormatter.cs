using System;
using System.Buffers;

namespace Microsoft.AspNetCore.Internal
{
	internal static class BinaryMessageFormatter
	{
		public static void WriteLengthPrefix(long length, IBufferWriter<byte> output)
		{
			throw null;
		}

		public static int WriteLengthPrefix(long length, Span<byte> output)
		{
			throw null;
		}

		public static int LengthPrefixLength(long length)
		{
			throw null;
		}
	}
}
