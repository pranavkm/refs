using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Server.Kestrel.Core.Features;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure;
using System;
using System.Buffers;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	internal class Http1OutputProducer : IHttpOutputProducer, IDisposable
	{
		/// <summary>
		/// Holds a byte[] from the pool and a size value. Basically a Memory but guaranteed to be backed by an ArrayPool byte[], so that we know we can return it.
		/// </summary>
		private readonly struct CompletedBuffer
		{
			private readonly IMemoryOwner<byte> _memoryOwner;

			public Memory<byte> Buffer
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public int Length
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public ReadOnlySpan<byte> Span
			{
				get
				{
					throw null;
				}
			}

			public CompletedBuffer(IMemoryOwner<byte> owner, Memory<byte> buffer, int length)
			{
				throw null;
			}

			public void Return()
			{
				throw null;
			}
		}

		public Http1OutputProducer(PipeWriter pipeWriter, string connectionId, ConnectionContext connectionContext, MemoryPool<byte> memoryPool, IKestrelTrace log, ITimeoutControl timeoutControl, IHttpMinResponseDataRateFeature minResponseDataRateFeature, IHttpOutputAborter outputAborter)
		{
			throw null;
		}

		public Task WriteDataAsync(ReadOnlySpan<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		public ValueTask<FlushResult> WriteDataToPipeAsync(ReadOnlySpan<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		public ValueTask<FlushResult> WriteStreamSuffixAsync()
		{
			throw null;
		}

		public ValueTask<FlushResult> FlushAsync(CancellationToken cancellationToken = default(CancellationToken))
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

		public void Advance(int bytes)
		{
			throw null;
		}

		public void CancelPendingFlush()
		{
			throw null;
		}

		public ValueTask<FlushResult> WriteChunkAsync(ReadOnlySpan<byte> buffer, CancellationToken cancellationToken)
		{
			throw null;
		}

		public void WriteResponseHeaders(int statusCode, string reasonPhrase, HttpResponseHeaders responseHeaders, bool autoChunk, bool appComplete)
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}

		public void Abort(ConnectionAbortedException error)
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

		public ValueTask<FlushResult> FirstWriteAsync(int statusCode, string reasonPhrase, HttpResponseHeaders responseHeaders, bool autoChunk, ReadOnlySpan<byte> buffer, CancellationToken cancellationToken)
		{
			throw null;
		}

		public ValueTask<FlushResult> FirstWriteChunkedAsync(int statusCode, string reasonPhrase, HttpResponseHeaders responseHeaders, bool autoChunk, ReadOnlySpan<byte> buffer, CancellationToken cancellationToken)
		{
			throw null;
		}

		public void Reset()
		{
			throw null;
		}
	}
}
