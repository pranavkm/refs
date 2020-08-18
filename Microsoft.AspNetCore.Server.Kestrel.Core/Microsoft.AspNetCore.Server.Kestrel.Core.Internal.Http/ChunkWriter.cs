using System;
using System.Buffers;
using System.IO.Pipelines;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	internal static class ChunkWriter
	{
		public static int BeginChunkBytes(int dataCount, Span<byte> span)
		{
			throw null;
		}

		internal static int GetPrefixBytesForChunk(int length, out bool sliceOneByte)
		{
			throw null;
		}

		internal static int WriteBeginChunkBytes(this ref BufferWriter<PipeWriter> start, int dataCount)
		{
			throw null;
		}

		internal static void WriteEndChunkBytes(this ref BufferWriter<PipeWriter> start)
		{
			throw null;
		}
	}
}
