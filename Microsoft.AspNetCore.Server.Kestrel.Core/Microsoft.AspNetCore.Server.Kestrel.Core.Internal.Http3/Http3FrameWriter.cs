using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure;
using System.Buffers;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http3
{
	internal class Http3FrameWriter
	{
		public Http3FrameWriter(PipeWriter output, ConnectionContext connectionContext, ITimeoutControl timeoutControl, MinDataRate minResponseDataRate, string connectionId, MemoryPool<byte> memoryPool, IKestrelTrace log)
		{
			throw null;
		}

		public void UpdateMaxFrameSize(uint maxFrameSize)
		{
			throw null;
		}

		internal Task WriteSettingsAsync(IList<Http3PeerSettings> settings)
		{
			throw null;
		}

		internal Task WriteStreamIdAsync(long id)
		{
			throw null;
		}

		public ValueTask<FlushResult> WriteDataAsync(in ReadOnlySequence<byte> data)
		{
			throw null;
		}

		internal Task WriteGoAway(long id)
		{
			throw null;
		}

		internal static int WriteHeader(Http3RawFrame frame, PipeWriter output)
		{
			throw null;
		}

		public ValueTask<FlushResult> WriteResponseTrailers(HttpResponseTrailers headers)
		{
			throw null;
		}

		public ValueTask<FlushResult> FlushAsync(IHttpOutputAborter outputAborter, CancellationToken cancellationToken)
		{
			throw null;
		}

		internal void WriteResponseHeaders(int statusCode, IHeaderDictionary headers)
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
	}
}
