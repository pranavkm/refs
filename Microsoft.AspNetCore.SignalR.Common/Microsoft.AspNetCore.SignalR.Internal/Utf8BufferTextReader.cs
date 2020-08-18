using System.Buffers;
using System.IO;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	internal sealed class Utf8BufferTextReader : TextReader
	{
		public Utf8BufferTextReader()
		{
			throw null;
		}

		public static Utf8BufferTextReader Get(in ReadOnlySequence<byte> utf8Buffer)
		{
			throw null;
		}

		public static void Return(Utf8BufferTextReader reader)
		{
			throw null;
		}

		public void SetBuffer(in ReadOnlySequence<byte> utf8Buffer)
		{
			throw null;
		}

		public override int Read(char[] buffer, int index, int count)
		{
			throw null;
		}
	}
}
