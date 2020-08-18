using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Server.Kestrel.Core.Features;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using System;
using System.Buffers;
using System.IO;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2
{
	internal abstract class Http2Stream : Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http.HttpProtocol, IThreadPoolWorkItem, IDisposable, IHttp2StreamIdFeature, IHttpMinRequestBodyDataRateFeature, IHttpResetFeature, IHttpResponseTrailersFeature
	{
		[Flags]
		private enum StreamCompletionFlags
		{
			None = 0x0,
			RstStreamReceived = 0x1,
			EndStreamReceived = 0x2,
			Aborted = 0x4
		}

		public Pipe RequestBodyPipe
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

		internal long DrainExpirationTicks
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

		public int StreamId
		{
			get
			{
				throw null;
			}
		}

		public long? InputRemaining
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			internal set
			{
				throw null;
			}
		}

		public bool RequestBodyStarted
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public bool EndStreamReceived
		{
			get
			{
				throw null;
			}
		}

		internal bool RstStreamReceived
		{
			get
			{
				throw null;
			}
		}

		public bool ReceivedEmptyRequestBody
		{
			get
			{
				throw null;
			}
		}

		public bool CanReuse
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		IHeaderDictionary IHttpResponseTrailersFeature.Trailers
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

		int IHttp2StreamIdFeature.StreamId
		{
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

		public void Initialize(Http2StreamContext context)
		{
			throw null;
		}

		public void InitializeWithExistingContext(int streamId)
		{
			throw null;
		}

		protected override void OnReset()
		{
			throw null;
		}

		protected override void OnRequestProcessingEnded()
		{
			throw null;
		}

		public void CompleteStream(bool errored)
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

		protected override bool TryParseRequest(ReadResult result, out bool endConnection)
		{
			throw null;
		}

		public Task OnDataAsync(Http2Frame dataFrame, in ReadOnlySequence<byte> payload)
		{
			throw null;
		}

		public void OnEndStreamReceived()
		{
			throw null;
		}

		public void OnDataRead(int bytesRead)
		{
			throw null;
		}

		public bool TryUpdateOutputWindow(int bytes)
		{
			throw null;
		}

		public void AbortRstStreamReceived()
		{
			throw null;
		}

		public void Abort(IOException abortReason)
		{
			throw null;
		}

		protected override void OnErrorAfterResponseStarted()
		{
			throw null;
		}

		protected override void ApplicationAbort()
		{
			throw null;
		}

		internal void ResetAndAbort(ConnectionAbortedException abortReason, Http2ErrorCode error)
		{
			throw null;
		}

		public void DecrementActiveClientStreamCount()
		{
			throw null;
		}

		/// <summary>
		/// Used to kick off the request processing loop by derived classes.
		/// </summary>
		public abstract void Execute();

		public void Dispose()
		{
			throw null;
		}

		public override void OnHeader(int index, bool indexedValue, ReadOnlySpan<byte> name, ReadOnlySpan<byte> value)
		{
			throw null;
		}

		void IHttpResetFeature.Reset(int errorCode)
		{
			throw null;
		}

		protected Http2Stream()
		{
			throw null;
		}
	}
	internal sealed class Http2Stream<TContext> : Http2Stream, IHostContextContainer<TContext>
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

		public Http2Stream(IHttpApplication<TContext> application, Http2StreamContext context)
		{
			throw null;
		}

		public override void Execute()
		{
			throw null;
		}
	}
}
