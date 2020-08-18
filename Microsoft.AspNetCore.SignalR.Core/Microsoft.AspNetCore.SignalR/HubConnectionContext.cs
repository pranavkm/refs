using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.SignalR.Protocol;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.SignalR
{
	/// <summary>
	/// Encapsulates all information about an individual connection to a SignalR Hub.
	/// </summary>
	public class HubConnectionContext
	{
		private static class Log
		{
			public static void HandshakeComplete(ILogger logger, string hubProtocol)
			{
				throw null;
			}

			public static void HandshakeCanceled(ILogger logger)
			{
				throw null;
			}

			public static void SentPing(ILogger logger)
			{
				throw null;
			}

			public static void TransportBufferFull(ILogger logger)
			{
				throw null;
			}

			public static void HandshakeFailed(ILogger logger, Exception exception)
			{
				throw null;
			}

			public static void FailedWritingMessage(ILogger logger, Exception exception)
			{
				throw null;
			}

			public static void ProtocolVersionFailed(ILogger logger, string protocolName, int version)
			{
				throw null;
			}

			public static void AbortFailed(ILogger logger, Exception exception)
			{
				throw null;
			}

			public static void ClientTimeout(ILogger logger, TimeSpan timeout)
			{
				throw null;
			}

			public static void HandshakeSizeLimitExceeded(ILogger logger, long maxMessageSize)
			{
				throw null;
			}
		}

		internal StreamTracker StreamTracker
		{
			get
			{
				throw null;
			}
		}

		internal HubCallerContext HubCallerContext
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal Exception? CloseException
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets a <see cref="T:System.Threading.CancellationToken" /> that notifies when the connection is aborted.
		/// </summary>
		public virtual CancellationToken ConnectionAborted
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the ID for this connection.
		/// </summary>
		public virtual string ConnectionId
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the user for this connection.
		/// </summary>
		public virtual ClaimsPrincipal? User
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the collection of features available on this connection.
		/// </summary>
		public virtual IFeatureCollection Features
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets a key/value collection that can be used to share data within the scope of this connection.
		/// </summary>
		public virtual IDictionary<object, object?> Items
		{
			get
			{
				throw null;
			}
		}

		internal bool AllowReconnect
		{
			get
			{
				throw null;
			}
		}

		internal PipeReader Input
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the user identifier for this connection.
		/// </summary>
		public string? UserIdentifier
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the protocol used by this connection.
		/// </summary>
		public virtual IHubProtocol Protocol
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

		internal ConcurrentDictionary<string, CancellationTokenSource> ActiveRequestCancellationSources
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.HubConnectionContext" /> class.
		/// </summary>
		/// <param name="connectionContext">The underlying <see cref="T:Microsoft.AspNetCore.Connections.ConnectionContext" />.</param>
		/// <param name="loggerFactory">The logger factory.</param>
		/// <param name="contextOptions">The options to configure the HubConnectionContext.</param>
		public HubConnectionContext(ConnectionContext connectionContext, HubConnectionContextOptions contextOptions, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		public virtual ValueTask WriteAsync(HubMessage message, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <summary>
		/// This method is designed to support the framework and is not intended to be used by application code. Writes a pre-serialized message to the
		/// connection.
		/// </summary>
		/// <param name="message">The serialization cache to use.</param>
		/// <param name="cancellationToken">The token to monitor for cancellation requests. The default value is <see cref="P:System.Threading.CancellationToken.None" />.</param>
		/// <returns></returns>
		public virtual ValueTask WriteAsync(SerializedHubMessage message, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		/// <summary>
		/// Aborts the connection.
		/// </summary>
		public virtual void Abort()
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CHandshakeAsync_003Ed__71))]
		[DebuggerStepThrough]
		internal Task<bool> HandshakeAsync(TimeSpan timeout, IReadOnlyList<string>? supportedProtocols, IHubProtocolResolver protocolResolver, IUserIdProvider userIdProvider, bool enableDetailedErrors)
		{
			throw null;
		}

		internal Task AbortAsync()
		{
			throw null;
		}

		internal void StartClientTimeout()
		{
			throw null;
		}

		internal void BeginClientTimeout()
		{
			throw null;
		}

		internal void StopClientTimeout()
		{
			throw null;
		}

		internal void Cleanup()
		{
			throw null;
		}
	}
}
