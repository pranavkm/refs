using Microsoft.AspNetCore.Connections;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http.Connections.Internal
{
	internal class HttpConnectionDispatcher
	{
		private class EmptyServiceProvider : IServiceProvider
		{
			public static EmptyServiceProvider Instance
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public object GetService(Type serviceType)
			{
				throw null;
			}

			public EmptyServiceProvider()
			{
				throw null;
			}
		}

		internal static class Log
		{
			public static void ConnectionDisposed(ILogger logger, string connectionId)
			{
				throw null;
			}

			public static void ConnectionAlreadyActive(ILogger logger, string connectionId, string requestId)
			{
				throw null;
			}

			public static void PollCanceled(ILogger logger, string connectionId, string requestId)
			{
				throw null;
			}

			public static void EstablishedConnection(ILogger logger)
			{
				throw null;
			}

			public static void ResumingConnection(ILogger logger)
			{
				throw null;
			}

			public static void ReceivedBytes(ILogger logger, long count)
			{
				throw null;
			}

			public static void TransportNotSupported(ILogger logger, HttpTransportType transport)
			{
				throw null;
			}

			public static void CannotChangeTransport(ILogger logger, HttpTransportType transport, HttpTransportType requestTransport)
			{
				throw null;
			}

			public static void PostNotAllowedForWebSockets(ILogger logger)
			{
				throw null;
			}

			public static void NegotiationRequest(ILogger logger)
			{
				throw null;
			}

			public static void ReceivedDeleteRequestForUnsupportedTransport(ILogger logger, HttpTransportType transportType)
			{
				throw null;
			}

			public static void TerminatingConnection(ILogger logger)
			{
				throw null;
			}

			public static void ConnectionDisposedWhileWriteInProgress(ILogger logger, string connectionId, Exception ex)
			{
				throw null;
			}

			public static void FailedToReadHttpRequestBody(ILogger logger, string connectionId, Exception ex)
			{
				throw null;
			}

			public static void NegotiateProtocolVersionMismatch(ILogger logger, int clientProtocolVersion)
			{
				throw null;
			}

			public static void InvalidNegotiateProtocolVersion(ILogger logger, string requestedProtocolVersion)
			{
				throw null;
			}
		}

		public HttpConnectionDispatcher(HttpConnectionManager manager, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CExecuteAsync_003Ed__8))]
		[DebuggerStepThrough]
		public Task ExecuteAsync(HttpContext context, HttpConnectionDispatcherOptions options, ConnectionDelegate connectionDelegate)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CExecuteNegotiateAsync_003Ed__9))]
		[DebuggerStepThrough]
		public Task ExecuteNegotiateAsync(HttpContext context, HttpConnectionDispatcherOptions options)
		{
			throw null;
		}
	}
}
