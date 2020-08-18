using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2
{
	internal class Http2Connection : IHttp2StreamLifetimeHandler, IHttpHeadersHandler, IRequestProcessor
	{
		private class StreamCloseAwaitable : ICriticalNotifyCompletion, INotifyCompletion
		{
			public bool IsCompleted
			{
				get
				{
					throw null;
				}
			}

			public StreamCloseAwaitable GetAwaiter()
			{
				throw null;
			}

			public void GetResult()
			{
				throw null;
			}

			public void OnCompleted(Action continuation)
			{
				throw null;
			}

			public void UnsafeOnCompleted(Action continuation)
			{
				throw null;
			}

			public void Complete()
			{
				throw null;
			}

			public StreamCloseAwaitable()
			{
				throw null;
			}
		}

		private enum RequestHeaderParsingState
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

		internal readonly Http2KeepAlive _keepAlive;

		internal readonly Dictionary<int, Http2Stream> _streams;

		internal Http2StreamStack StreamPool;

		internal const int InitialStreamPoolSize = 5;

		internal const int MaxStreamPoolSize = 100;

		internal const long StreamPoolExpiryTicks = 50000000L;

		public static ReadOnlySpan<byte> ClientPreface
		{
			get
			{
				throw null;
			}
		}

		internal uint MaxTrackedStreams
		{
			get
			{
				throw null;
			}
		}

		public string ConnectionId
		{
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

		public IKestrelTrace Log
		{
			get
			{
				throw null;
			}
		}

		public IFeatureCollection ConnectionFeatures
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

		public ITimeoutControl TimeoutControl
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

		internal Http2PeerSettings ServerSettings
		{
			get
			{
				throw null;
			}
		}

		public Http2Connection(HttpConnectionContext context)
		{
			throw null;
		}

		public void OnInputOrOutputCompleted()
		{
			throw null;
		}

		public void Abort(ConnectionAbortedException ex)
		{
			throw null;
		}

		public void StopProcessingNextRequest()
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

		public void StopProcessingNextRequest(bool serverInitiated)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CProcessRequestsAsync_003Ed__59<>))]
		[DebuggerStepThrough]
		public Task ProcessRequestsAsync<TContext>(IHttpApplication<TContext> application)
		{
			throw null;
		}

		void IRequestProcessor.Tick(DateTimeOffset now)
		{
			throw null;
		}

		void IHttp2StreamLifetimeHandler.OnStreamCompleted(Http2Stream stream)
		{
			throw null;
		}

		public void OnHeader(ReadOnlySpan<byte> name, ReadOnlySpan<byte> value)
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

		public void OnHeadersComplete(bool endStream)
		{
			throw null;
		}

		public void IncrementActiveClientStreamCount()
		{
			throw null;
		}

		public void DecrementActiveClientStreamCount()
		{
			throw null;
		}
	}
}
