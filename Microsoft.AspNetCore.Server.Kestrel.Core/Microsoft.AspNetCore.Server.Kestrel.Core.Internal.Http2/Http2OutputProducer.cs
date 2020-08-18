using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2.FlowControl;
using System;
using System.IO.Pipelines;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2
{
	internal class Http2OutputProducer : IHttpOutputProducer, IHttpOutputAborter, IValueTaskSource<FlushResult>, IDisposable
	{
		internal ValueTask _dataWriteProcessingTask;

		internal bool _disposed;

		ValueTaskSourceStatus IValueTaskSource<FlushResult>.GetStatus(short token)
		{
			throw null;
		}

		void IValueTaskSource<FlushResult>.OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags)
		{
			throw null;
		}

		FlushResult IValueTaskSource<FlushResult>.GetResult(short token)
		{
			throw null;
		}

		public Http2OutputProducer(Http2Stream stream, Http2StreamContext context, StreamOutputFlowControl flowControl)
		{
			throw null;
		}

		public void StreamReset()
		{
			throw null;
		}

		public void Complete()
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

		public ValueTask<FlushResult> FlushAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		public ValueTask<FlushResult> Write100ContinueAsync()
		{
			throw null;
		}

		public void WriteResponseHeaders(int statusCode, string ReasonPhrase, HttpResponseHeaders responseHeaders, bool autoChunk, bool appCompleted)
		{
			throw null;
		}

		public Task WriteDataAsync(ReadOnlySpan<byte> data, CancellationToken cancellationToken)
		{
			throw null;
		}

		public ValueTask<FlushResult> WriteStreamSuffixAsync()
		{
			throw null;
		}

		public ValueTask<FlushResult> WriteRstStreamAsync(Http2ErrorCode error)
		{
			throw null;
		}

		public void Advance(int bytes)
		{
			throw null;
		}

		public Span<byte> GetSpan(int sizeHint = 0)
		{
			throw null;
		}

		public Memory<byte> GetMemory(int sizeHint = 0)
		{
			throw null;
		}

		public void CancelPendingFlush()
		{
			throw null;
		}

		public ValueTask<FlushResult> WriteDataToPipeAsync(ReadOnlySpan<byte> data, CancellationToken cancellationToken)
		{
			throw null;
		}

		public ValueTask<FlushResult> FirstWriteAsync(int statusCode, string reasonPhrase, HttpResponseHeaders responseHeaders, bool autoChunk, ReadOnlySpan<byte> data, CancellationToken cancellationToken)
		{
			throw null;
		}

		ValueTask<FlushResult> IHttpOutputProducer.WriteChunkAsync(ReadOnlySpan<byte> data, CancellationToken cancellationToken)
		{
			throw null;
		}

		public ValueTask<FlushResult> FirstWriteChunkedAsync(int statusCode, string reasonPhrase, HttpResponseHeaders responseHeaders, bool autoChunk, ReadOnlySpan<byte> data, CancellationToken cancellationToken)
		{
			throw null;
		}

		public void Stop()
		{
			throw null;
		}

		public void Reset()
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}
	}
}
