using System;
using System.Diagnostics;
using System.IO;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal
{
	internal class DuplexPipeStream : Stream
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

		public DuplexPipeStream(PipeReader input, PipeWriter output, bool throwOnCancelled = false)
		{
			throw null;
		}

		public void CancelPendingRead()
		{
			throw null;
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		public override void SetLength(long value)
		{
			throw null;
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		public override ValueTask<int> ReadAsync(Memory<byte> destination, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CWriteAsync_003Ed__23))]
		[DebuggerStepThrough]
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CWriteAsync_003Ed__24))]
		[DebuggerStepThrough]
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> source, CancellationToken cancellationToken = default(CancellationToken))
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

		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			throw null;
		}

		public override int EndRead(IAsyncResult asyncResult)
		{
			throw null;
		}

		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			throw null;
		}

		public override void EndWrite(IAsyncResult asyncResult)
		{
			throw null;
		}
	}
}
