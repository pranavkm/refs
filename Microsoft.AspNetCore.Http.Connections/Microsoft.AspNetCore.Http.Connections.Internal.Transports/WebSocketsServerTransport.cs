using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http.Connections.Internal.Transports
{
	internal class WebSocketsServerTransport : IHttpTransport
	{
		private static class Log
		{
			public static void SocketOpened(ILogger logger, string? subProtocol)
			{
				throw null;
			}

			public static void SocketClosed(ILogger logger)
			{
				throw null;
			}

			public static void ClientClosed(ILogger logger, WebSocketCloseStatus? closeStatus, string closeDescription)
			{
				throw null;
			}

			public static void WaitingForSend(ILogger logger)
			{
				throw null;
			}

			public static void FailedSending(ILogger logger)
			{
				throw null;
			}

			public static void FinishedSending(ILogger logger)
			{
				throw null;
			}

			public static void WaitingForClose(ILogger logger)
			{
				throw null;
			}

			public static void CloseTimedOut(ILogger logger)
			{
				throw null;
			}

			public static void MessageReceived(ILogger logger, WebSocketMessageType type, int size, bool endOfMessage)
			{
				throw null;
			}

			public static void MessageToApplication(ILogger logger, int size)
			{
				throw null;
			}

			public static void SendPayload(ILogger logger, long size)
			{
				throw null;
			}

			public static void ErrorWritingFrame(ILogger logger, Exception ex)
			{
				throw null;
			}

			public static void ClosedPrematurely(ILogger logger, Exception ex)
			{
				throw null;
			}

			public static void ClosingWebSocketFailed(ILogger logger, Exception ex)
			{
				throw null;
			}
		}

		public WebSocketsServerTransport(WebSocketOptions options, IDuplexPipe application, HttpConnectionContext connection, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CProcessRequestAsync_003Ed__6))]
		[DebuggerStepThrough]
		public Task ProcessRequestAsync(HttpContext context, CancellationToken token)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CProcessSocketAsync_003Ed__7))]
		[DebuggerStepThrough]
		public Task ProcessSocketAsync(WebSocket socket)
		{
			throw null;
		}
	}
}
