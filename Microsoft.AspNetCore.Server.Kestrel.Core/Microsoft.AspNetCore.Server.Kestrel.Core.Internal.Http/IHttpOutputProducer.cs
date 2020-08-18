using System;
using System.IO.Pipelines;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	internal interface IHttpOutputProducer
	{
		ValueTask<FlushResult> WriteChunkAsync(ReadOnlySpan<byte> data, CancellationToken cancellationToken);

		ValueTask<FlushResult> FlushAsync(CancellationToken cancellationToken);

		ValueTask<FlushResult> Write100ContinueAsync();

		void WriteResponseHeaders(int statusCode, string reasonPhrase, HttpResponseHeaders responseHeaders, bool autoChunk, bool appCompleted);

		ValueTask<FlushResult> WriteDataToPipeAsync(ReadOnlySpan<byte> data, CancellationToken cancellationToken);

		Task WriteDataAsync(ReadOnlySpan<byte> data, CancellationToken cancellationToken);

		ValueTask<FlushResult> WriteStreamSuffixAsync();

		void Advance(int bytes);

		Span<byte> GetSpan(int sizeHint = 0);

		Memory<byte> GetMemory(int sizeHint = 0);

		void CancelPendingFlush();

		void Stop();

		ValueTask<FlushResult> FirstWriteAsync(int statusCode, string reasonPhrase, HttpResponseHeaders responseHeaders, bool autoChunk, ReadOnlySpan<byte> data, CancellationToken cancellationToken);

		ValueTask<FlushResult> FirstWriteChunkedAsync(int statusCode, string reasonPhrase, HttpResponseHeaders responseHeaders, bool autoChunk, ReadOnlySpan<byte> data, CancellationToken cancellationToken);

		void Reset();
	}
}
