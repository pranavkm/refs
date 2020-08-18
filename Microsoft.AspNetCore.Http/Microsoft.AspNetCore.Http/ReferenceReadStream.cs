using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// A Stream that wraps another stream starting at a certain offset and reading for the given length.
	/// </summary>
	internal sealed class ReferenceReadStream : Stream
	{
		public override bool CanRead
		{
			get
			{
				throw null;
			}
		}

		public override bool CanSeek
		{
			get
			{
				throw null;
			}
		}

		public override bool CanWrite
		{
			get
			{
				throw null;
			}
		}

		public override long Length
		{
			get
			{
				throw null;
			}
		}

		public override long Position
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public ReferenceReadStream(Stream inner, long offset, long length)
		{
			throw null;
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CReadAsync_003Ed__20))]
		[DebuggerStepThrough]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		public override void SetLength(long value)
		{
			throw null;
		}

		public override void Flush()
		{
			throw null;
		}

		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		protected override void Dispose(bool disposing)
		{
			throw null;
		}
	}
}
