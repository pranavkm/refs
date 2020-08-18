using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http.Connections.Internal.Transports
{
	internal class LongPollingServerTransport : IHttpTransport
	{
		private static class Log
		{
			public static void LongPolling204(ILogger logger)
			{
				throw null;
			}

			public static void PollTimedOut(ILogger logger)
			{
				throw null;
			}

			public static void LongPollingWritingMessage(ILogger logger, long count)
			{
				throw null;
			}

			public static void LongPollingDisconnected(ILogger logger)
			{
				throw null;
			}

			public static void LongPollingTerminated(ILogger logger, Exception ex)
			{
				throw null;
			}
		}

		public LongPollingServerTransport(CancellationToken timeoutToken, PipeReader application, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		public LongPollingServerTransport(CancellationToken timeoutToken, PipeReader application, ILoggerFactory loggerFactory, HttpConnectionContext? connection)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CProcessRequestAsync_003Ed__6))]
		[DebuggerStepThrough]
		public Task ProcessRequestAsync(HttpContext context, CancellationToken token)
		{
			throw null;
		}
	}
}
