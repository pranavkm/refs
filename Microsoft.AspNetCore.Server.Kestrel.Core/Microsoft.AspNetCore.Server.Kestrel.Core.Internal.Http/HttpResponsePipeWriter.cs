using System;
using System.IO.Pipelines;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	internal sealed class HttpResponsePipeWriter : PipeWriter
	{
		public HttpResponsePipeWriter(IHttpResponseControl pipeControl)
		{
			throw null;
		}

		public override void Advance(int bytes)
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

		public override ValueTask<FlushResult> FlushAsync(CancellationToken cancellationToken = default(CancellationToken))
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

		public override ValueTask<FlushResult> WriteAsync(ReadOnlyMemory<byte> source, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		public void StartAcceptingWrites()
		{
			throw null;
		}

		public Task StopAcceptingWritesAsync()
		{
			throw null;
		}

		public void Abort()
		{
			throw null;
		}
	}
}
