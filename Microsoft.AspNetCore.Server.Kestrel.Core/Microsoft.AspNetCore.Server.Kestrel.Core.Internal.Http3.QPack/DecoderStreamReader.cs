using System.Buffers;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http3.QPack
{
	internal class DecoderStreamReader
	{
		private enum State
		{
			Ready,
			HeaderAckowledgement,
			StreamCancellation,
			InsertCountIncrement
		}

		public DecoderStreamReader()
		{
			throw null;
		}

		public void Read(ReadOnlySequence<byte> data)
		{
			throw null;
		}
	}
}
