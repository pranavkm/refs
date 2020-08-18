using System;
using System.Buffers;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.WebUtilities
{
	/// <summary>
	/// Writes to the <see cref="T:System.IO.Stream" /> using the supplied <see cref="P:Microsoft.AspNetCore.WebUtilities.HttpResponseStreamWriter.Encoding" />.
	/// It does not write the BOM and also does not close the stream.
	/// </summary>
	public class HttpResponseStreamWriter : TextWriter
	{
		internal const int DefaultBufferSize = 16384;

		public override Encoding Encoding
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public HttpResponseStreamWriter(Stream stream, Encoding encoding)
		{
			throw null;
		}

		public HttpResponseStreamWriter(Stream stream, Encoding encoding, int bufferSize)
		{
			throw null;
		}

		public HttpResponseStreamWriter(Stream stream, Encoding encoding, int bufferSize, ArrayPool<byte> bytePool, ArrayPool<char> charPool)
		{
			throw null;
		}

		public override void Write(char value)
		{
			throw null;
		}

		public override void Write(char[] values, int index, int count)
		{
			throw null;
		}

		public override void Write(ReadOnlySpan<char> value)
		{
			throw null;
		}

		public override void Write(string? value)
		{
			throw null;
		}

		public override void WriteLine(ReadOnlySpan<char> value)
		{
			throw null;
		}

		public override Task WriteAsync(char value)
		{
			throw null;
		}

		public override Task WriteAsync(char[] values, int index, int count)
		{
			throw null;
		}

		public override Task WriteAsync(string? value)
		{
			throw null;
		}

		public override Task WriteAsync(ReadOnlyMemory<char> value, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		public override Task WriteLineAsync(ReadOnlyMemory<char> value, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		public override void Flush()
		{
			throw null;
		}

		public override Task FlushAsync()
		{
			throw null;
		}

		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__35))]
		[DebuggerStepThrough]
		public override ValueTask DisposeAsync()
		{
			throw null;
		}
	}
}
