using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2.FlowControl;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2
{
	internal class Http2FrameWriter
	{
		public Http2FrameWriter(PipeWriter outputPipeWriter, ConnectionContext connectionContext, Http2Connection http2Connection, OutputFlowControl connectionOutputFlowControl, ITimeoutControl timeoutControl, MinDataRate minResponseDataRate, string connectionId, MemoryPool<byte> memoryPool, ServiceContext serviceContext)
		{
			throw null;
		}

		public void UpdateMaxHeaderTableSize(uint maxHeaderTableSize)
		{
			throw null;
		}

		public void UpdateMaxFrameSize(uint maxFrameSize)
		{
			throw null;
		}

		public void Complete()
		{
			throw null;
		}

		public void Abort(ConnectionAbortedException error)
		{
			throw null;
		}

		public ValueTask<FlushResult> FlushAsync(IHttpOutputAborter outputAborter, CancellationToken cancellationToken)
		{
			throw null;
		}

		public ValueTask<FlushResult> Write100ContinueAsync(int streamId)
		{
			throw null;
		}

		public void WriteResponseHeaders(int streamId, int statusCode, Http2HeadersFrameFlags headerFrameFlags, HttpResponseHeaders headers)
		{
			throw null;
		}

		public ValueTask<FlushResult> WriteResponseTrailersAsync(int streamId, HttpResponseTrailers headers)
		{
			throw null;
		}

		public ValueTask<FlushResult> WriteDataAsync(int streamId, StreamOutputFlowControl flowControl, in ReadOnlySequence<byte> data, bool endStream, bool firstWrite, bool forceFlush)
		{
			throw null;
		}

		public ValueTask<FlushResult> WriteDataAndTrailersAsync(int streamId, StreamOutputFlowControl flowControl, in ReadOnlySequence<byte> data, bool firstWrite, HttpResponseTrailers headers)
		{
			throw null;
		}

		public ValueTask<FlushResult> WriteWindowUpdateAsync(int streamId, int sizeIncrement)
		{
			throw null;
		}

		public ValueTask<FlushResult> WriteRstStreamAsync(int streamId, Http2ErrorCode errorCode)
		{
			throw null;
		}

		public ValueTask<FlushResult> WriteSettingsAsync(IList<Http2PeerSetting> settings)
		{
			throw null;
		}

		internal static void WriteSettings(IList<Http2PeerSetting> settings, Span<byte> destination)
		{
			throw null;
		}

		public ValueTask<FlushResult> WriteSettingsAckAsync()
		{
			throw null;
		}

		public ValueTask<FlushResult> WritePingAsync(Http2PingFrameFlags flags, in ReadOnlySequence<byte> payload)
		{
			throw null;
		}

		public ValueTask<FlushResult> WriteGoAwayAsync(int lastStreamId, Http2ErrorCode errorCode)
		{
			throw null;
		}

		internal static void WriteHeader(Http2Frame frame, PipeWriter output)
		{
			throw null;
		}

		public bool TryUpdateConnectionWindow(int bytes)
		{
			throw null;
		}

		public bool TryUpdateStreamWindow(StreamOutputFlowControl flowControl, int bytes)
		{
			throw null;
		}

		public void AbortPendingStreamDataWrites(StreamOutputFlowControl flowControl)
		{
			throw null;
		}
	}
}
