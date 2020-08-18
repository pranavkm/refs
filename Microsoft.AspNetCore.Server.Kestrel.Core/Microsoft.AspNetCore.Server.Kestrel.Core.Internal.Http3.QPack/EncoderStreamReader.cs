using System.Buffers;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http3.QPack
{
	internal class EncoderStreamReader
	{
		private enum State
		{
			Ready,
			DynamicTableCapcity,
			NameIndex,
			NameLength,
			Name,
			ValueLength,
			ValueLengthContinue,
			Value,
			Duplicate
		}

		public EncoderStreamReader(int maxRequestHeaderFieldSize)
		{
			throw null;
		}

		public void Read(ReadOnlySequence<byte> data)
		{
			throw null;
		}
	}
}
