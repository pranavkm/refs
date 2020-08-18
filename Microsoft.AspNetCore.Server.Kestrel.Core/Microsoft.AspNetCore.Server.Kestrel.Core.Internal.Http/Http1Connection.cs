using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Hosting.Server.Abstractions;
using Microsoft.AspNetCore.Server.Kestrel.Core.Features;
using System;
using System.Buffers;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	internal class Http1Connection : HttpProtocol, IRequestProcessor, IHttpOutputAborter, IHttpMinRequestBodyDataRateFeature, IHttpMinResponseDataRateFeature
	{
		protected readonly long _keepAliveTicks;

		public PipeReader Input
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public bool RequestTimedOut
		{
			get
			{
				throw null;
			}
		}

		public MinDataRate MinResponseDataRate
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public MemoryPool<byte> MemoryPool
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		MinDataRate IHttpMinRequestBodyDataRateFeature.MinDataRate
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

		MinDataRate IHttpMinResponseDataRateFeature.MinDataRate
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

		public Http1Connection(HttpConnectionContext context)
		{
			throw null;
		}

		protected override void OnRequestProcessingEnded()
		{
			throw null;
		}

		public void OnInputOrOutputCompleted()
		{
			throw null;
		}

		/// <summary>
		/// Immediately kill the connection and poison the request body stream with an error.
		/// </summary>
		public void Abort(ConnectionAbortedException abortReason)
		{
			throw null;
		}

		protected override void ApplicationAbort()
		{
			throw null;
		}

		/// <summary>
		/// Stops the request processing loop between requests.
		/// Called on all active connections when the server wants to initiate a shutdown
		/// and after a keep-alive timeout.
		/// </summary>
		public void StopProcessingNextRequest()
		{
			throw null;
		}

		public void SendTimeoutResponse()
		{
			throw null;
		}

		public void HandleRequestHeadersTimeout()
		{
			throw null;
		}

		public void HandleReadDataRateTimeout()
		{
			throw null;
		}

		public bool ParseRequest(ref SequenceReader<byte> reader)
		{
			throw null;
		}

		public bool TakeStartLine(ref SequenceReader<byte> reader)
		{
			throw null;
		}

		public bool TakeMessageHeaders(ref SequenceReader<byte> reader, bool trailers)
		{
			throw null;
		}

		public void OnStartLine(HttpVersionAndMethod versionAndMethod, TargetOffsetPathLength targetPath, Span<byte> startLine)
		{
			throw null;
		}

		internal void EnsureHostHeaderExists()
		{
			throw null;
		}

		protected override void OnReset()
		{
			throw null;
		}

		protected override void OnRequestProcessingEnding()
		{
			throw null;
		}

		protected override string CreateRequestId()
		{
			throw null;
		}

		protected override MessageBody CreateMessageBody()
		{
			throw null;
		}

		protected override void BeginRequestProcessing()
		{
			throw null;
		}

		protected override bool BeginRead(out ValueTask<ReadResult> awaitable)
		{
			throw null;
		}

		protected override bool TryParseRequest(ReadResult result, out bool endConnection)
		{
			throw null;
		}

		void IRequestProcessor.Tick(DateTimeOffset now)
		{
			throw null;
		}
	}
	internal sealed class Http1Connection<TContext> : Http1Connection, IHostContextContainer<TContext>
	{
		TContext IHostContextContainer<TContext>.HostContext
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public Http1Connection(HttpConnectionContext context)
		{
			throw null;
		}
	}
}
