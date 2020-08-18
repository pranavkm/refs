using System.Buffers;
using System.IO;
using System.Text;

namespace Microsoft.AspNetCore.Internal
{
	internal sealed class Utf8BufferTextWriter : TextWriter
	{
		public override Encoding Encoding
		{
			get
			{
				throw null;
			}
		}

		public Utf8BufferTextWriter()
		{
			throw null;
		}

		public static Utf8BufferTextWriter Get(IBufferWriter<byte> bufferWriter)
		{
			throw null;
		}

		public static void Return(Utf8BufferTextWriter writer)
		{
			throw null;
		}

		public void SetWriter(IBufferWriter<byte> bufferWriter)
		{
			throw null;
		}

		public override void Write(char[] buffer, int index, int count)
		{
			throw null;
		}

		public override void Write(char[] buffer)
		{
			throw null;
		}

		public override void Write(char value)
		{
			throw null;
		}

		public override void Write(string value)
		{
			throw null;
		}

		public override void Flush()
		{
			throw null;
		}

		protected override void Dispose(bool disposing)
		{
			throw null;
		}
	}
}
