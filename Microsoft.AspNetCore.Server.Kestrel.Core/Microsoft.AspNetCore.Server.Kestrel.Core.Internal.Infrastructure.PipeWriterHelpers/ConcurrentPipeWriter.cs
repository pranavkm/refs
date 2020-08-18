using System;
using System.Buffers;
using System.IO.Pipelines;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure.PipeWriterHelpers
{
	/// <summary>
	/// Wraps a PipeWriter so you can start appending more data to the pipe prior to the previous flush completing.
	/// </summary>
	internal sealed class ConcurrentPipeWriter : PipeWriter
	{
		public ConcurrentPipeWriter(PipeWriter innerPipeWriter, MemoryPool<byte> pool, object sync)
		{
			throw null;
		}

		public void Reset()
		{
			throw null;
		}

		public override Memory<byte> GetMemory(int sizeHint = 0)
		{
			throw null;
		}

		public override Span<byte> GetSpan(int sizeHint = 0)
		{
			throw null;
		}

		public override void Advance(int bytes)
		{
			throw null;
		}

		public override ValueTask<FlushResult> FlushAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		public override void CancelPendingFlush()
		{
			throw null;
		}

		public override void Complete(Exception exception = null)
		{
			throw null;
		}

		public void Abort()
		{
			throw null;
		}
	}
}
