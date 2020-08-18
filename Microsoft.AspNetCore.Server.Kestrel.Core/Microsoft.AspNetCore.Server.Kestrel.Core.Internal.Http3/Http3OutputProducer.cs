using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure;
using System;
using System.Buffers;
using System.IO.Pipelines;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http3
{
	internal class Http3OutputProducer : IHttpOutputProducer, IHttpOutputAborter
	{
		public Http3OutputProducer(Http3FrameWriter frameWriter, MemoryPool<byte> pool, Http3Stream stream, IKestrelTrace log)
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}

		void IHttpOutputAborter.Abort(ConnectionAbortedException abortReason)
		{
			throw null;
		}

		void IHttpOutputAborter.OnInputOrOutputCompleted()
		{
			throw null;
		}

		public void Advance(int bytes)
		{
			throw null;
		}

		public void CancelPendingFlush()
		{
			throw null;
		}

		public ValueTask<FlushResult> FirstWriteAsync(int statusCode, string reasonPhrase, HttpResponseHeaders responseHeaders, bool autoChunk, ReadOnlySpan<byte> data, CancellationToken cancellationToken)
		{
			throw null;
		}

		public ValueTask<FlushResult> FirstWriteChunkedAsync(int statusCode, string reasonPhrase, HttpResponseHeaders responseHeaders, bool autoChunk, ReadOnlySpan<byte> data, CancellationToken cancellationToken)
		{
			throw null;
		}

		public ValueTask<FlushResult> FlushAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		public Memory<byte> GetMemory(int sizeHint = 0)
		{
			throw null;
		}

		public Span<byte> GetSpan(int sizeHint = 0)
		{
			throw null;
		}

		public void Reset()
		{
			throw null;
		}

		public void Stop()
		{
			throw null;
		}

		public ValueTask<FlushResult> Write100ContinueAsync()
		{
			throw null;
		}

		public ValueTask<FlushResult> WriteChunkAsync(ReadOnlySpan<byte> data, CancellationToken cancellationToken)
		{
			throw null;
		}

		public Task WriteDataAsync(ReadOnlySpan<byte> data, CancellationToken cancellationToken)
		{
			throw null;
		}

		public ValueTask<FlushResult> WriteDataToPipeAsync(ReadOnlySpan<byte> data, CancellationToken cancellationToken)
		{
			throw null;
		}

		public void WriteResponseHeaders(int statusCode, string reasonPhrase, HttpResponseHeaders responseHeaders, bool autoChunk, bool appCompleted)
		{
			throw null;
		}

		public ValueTask<FlushResult> WriteStreamSuffixAsync()
		{
			throw null;
		}
	}
}
