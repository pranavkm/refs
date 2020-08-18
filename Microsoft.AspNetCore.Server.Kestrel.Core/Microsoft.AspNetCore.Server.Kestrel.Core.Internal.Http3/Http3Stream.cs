using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Abstractions;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure;
using System;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Net.Http;
using System.Net.Http.QPack;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http3
{
	internal abstract class Http3Stream : HttpProtocol, IHttpHeadersHandler, IThreadPoolWorkItem
	{
		protected enum RequestHeaderParsingState
		{
			Ready,
			PseudoHeaderFields,
			Headers,
			Trailers
		}

		[Flags]
		private enum PseudoHeaderFields
		{
			None = 0x0,
			Authority = 0x1,
			Method = 0x2,
			Path = 0x4,
			Scheme = 0x8,
			Status = 0x10,
			Unknown = 0x40000000
		}

		private static class GracefulCloseInitiator
		{
			public const int None = 0;

			public const int Server = 1;

			public const int Client = 2;
		}

		protected RequestHeaderParsingState _requestHeaderParsingState;

		public Pipe RequestBodyPipe
		{
			[CompilerGenerated]
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

		public System.Net.Http.QPack.QPackDecoder QPackDecoder
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public PipeReader Input
		{
			get
			{
				throw null;
			}
		}

		public ISystemClock SystemClock
		{
			get
			{
				throw null;
			}
		}

		public KestrelServerLimits Limits
		{
			get
			{
				throw null;
			}
		}

		public Http3Stream(Http3Connection http3Connection, Http3StreamContext context)
		{
			throw null;
		}

		public void Abort(ConnectionAbortedException ex)
		{
			throw null;
		}

		public void Abort(ConnectionAbortedException ex, System.Net.Http.Http3ErrorCode errorCode)
		{
			throw null;
		}

		public void OnHeadersComplete(bool endStream)
		{
			throw null;
		}

		public void OnStaticIndexedHeader(int index)
		{
			throw null;
		}

		public void OnStaticIndexedHeader(int index, ReadOnlySpan<byte> value)
		{
			throw null;
		}

		public override void OnHeader(ReadOnlySpan<byte> name, ReadOnlySpan<byte> value)
		{
			throw null;
		}

		public void HandleReadDataRateTimeout()
		{
			throw null;
		}

		public void HandleRequestHeadersTimeout()
		{
			throw null;
		}

		public void OnInputOrOutputCompleted()
		{
			throw null;
		}

		protected override void OnRequestProcessingEnded()
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CProcessRequestAsync_003Ed__63<>))]
		[DebuggerStepThrough]
		public Task ProcessRequestAsync<TContext>(IHttpApplication<TContext> application)
		{
			throw null;
		}

		public void StopProcessingNextRequest()
		{
			throw null;
		}

		public void StopProcessingNextRequest(bool serverInitiated)
		{
			throw null;
		}

		public void Tick(DateTimeOffset now)
		{
			throw null;
		}

		protected override void OnReset()
		{
			throw null;
		}

		protected override void ApplicationAbort()
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

		/// <summary>
		/// Used to kick off the request processing loop by derived classes.
		/// </summary>
		public abstract void Execute();
	}
	internal class Http3Stream<TContext> : Http3Stream, IHostContextContainer<TContext>
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

		public Http3Stream(IHttpApplication<TContext> application, Http3Connection connection, Http3StreamContext context)
		{
			throw null;
		}

		public override void Execute()
		{
			throw null;
		}
	}
}
