using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Connections.Features;
using Microsoft.AspNetCore.Http.Connections.Features;
using Microsoft.AspNetCore.Http.Connections.Internal.Transports;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http.Connections.Internal
{
	internal class HttpConnectionContext : ConnectionContext, IConnectionIdFeature, IConnectionItemsFeature, IConnectionTransportFeature, IConnectionUserFeature, IConnectionHeartbeatFeature, ITransferFormatFeature, IHttpContextFeature, IHttpTransportFeature, IConnectionInherentKeepAliveFeature, IConnectionLifetimeFeature
	{
		private static class Log
		{
			public static void DisposingConnection(ILogger logger, string connectionId)
			{
				throw null;
			}

			public static void WaitingForApplication(ILogger logger)
			{
				throw null;
			}

			public static void ApplicationComplete(ILogger logger)
			{
				throw null;
			}

			public static void WaitingForTransport(ILogger logger, HttpTransportType transportType)
			{
				throw null;
			}

			public static void TransportComplete(ILogger logger, HttpTransportType transportType)
			{
				throw null;
			}

			public static void ShuttingDownTransportAndApplication(ILogger logger, HttpTransportType transportType)
			{
				throw null;
			}

			public static void WaitingForTransportAndApplication(ILogger logger, HttpTransportType transportType)
			{
				throw null;
			}

			public static void TransportAndApplicationComplete(ILogger logger, HttpTransportType transportType)
			{
				throw null;
			}
		}

		internal CancellationToken SendingToken
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public CancellationTokenSource Cancellation
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

		public HttpTransportType TransportType
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

		public SemaphoreSlim WriteLock
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal Task DisposeAndRemoveTask
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

		internal IServiceScope ServiceScope
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

		public Task TransportTask
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

		public Task PreviousPollTask
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

		public Task ApplicationTask
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

		public DateTime LastSeenUtc
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

		public DateTime? LastSeenUtcIfInactive
		{
			get
			{
				throw null;
			}
		}

		public HttpConnectionStatus Status
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

		public override string ConnectionId
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

		internal string ConnectionToken
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

		public override IFeatureCollection Features
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public ClaimsPrincipal User
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

		public bool HasInherentKeepAlive
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

		public override IDictionary<object, object> Items
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

		public IDuplexPipe Application
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

		internal PipeWriterStream ApplicationStream
		{
			get
			{
				throw null;
			}
		}

		public override IDuplexPipe Transport
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

		public TransferFormat SupportedFormats
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

		public TransferFormat ActiveFormat
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

		public HttpContext HttpContext
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

		public override CancellationToken ConnectionClosed
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

		/// <summary>
		/// Creates the DefaultConnectionContext without Pipes to avoid upfront allocations.
		/// The caller is expected to set the <see cref="P:Microsoft.AspNetCore.Http.Connections.Internal.HttpConnectionContext.Transport" /> and <see cref="P:Microsoft.AspNetCore.Http.Connections.Internal.HttpConnectionContext.Application" /> pipes manually.
		/// </summary>
		/// <param name="connectionId"></param>
		/// <param name="connectionToken"></param>
		/// <param name="logger"></param>
		public HttpConnectionContext(string connectionId, string connectionToken, ILogger logger)
		{
			throw null;
		}

		public override void Abort()
		{
			throw null;
		}

		public void OnHeartbeat(Action<object> action, object state)
		{
			throw null;
		}

		public void TickHeartbeat()
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__111))]
		[DebuggerStepThrough]
		public Task DisposeAsync(bool closeGracefully = false)
		{
			throw null;
		}

		internal bool TryActivatePersistentConnection(ConnectionDelegate connectionDelegate, IHttpTransport transport, ILogger dispatcherLogger)
		{
			throw null;
		}

		public bool TryActivateLongPollingConnection(ConnectionDelegate connectionDelegate, HttpContext nonClonedContext, TimeSpan pollTimeout, Task currentRequestTask, ILoggerFactory loggerFactory, ILogger dispatcherLogger)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CCancelPreviousPoll_003Ed__116))]
		[DebuggerStepThrough]
		internal Task<bool> CancelPreviousPoll(HttpContext context)
		{
			throw null;
		}

		public void MarkInactive()
		{
			throw null;
		}

		internal void StartSendCancellation()
		{
			throw null;
		}

		internal void TryCancelSend(long currentTicks)
		{
			throw null;
		}

		internal void StopSendCancellation()
		{
			throw null;
		}
	}
}
