using System.Buffers;
using System.Net.Http;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http3
{
	internal class Http3FrameReader
	{
		internal static bool TryReadFrame(ref ReadOnlySequence<byte> readableBuffer, Http3RawFrame frame, uint maxFrameSize, out ReadOnlySequence<byte> framePayload)
		{
			throw null;
		}

		public Http3FrameReader()
		{
			throw null;
		}
	}
}
