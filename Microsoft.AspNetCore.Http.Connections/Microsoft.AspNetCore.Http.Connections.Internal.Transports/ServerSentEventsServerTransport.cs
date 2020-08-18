using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http.Connections.Internal.Transports
{
	internal class ServerSentEventsServerTransport : IHttpTransport
	{
		private static class Log
		{
			public static void SSEWritingMessage(ILogger logger, long count)
			{
				throw null;
			}
		}

		public ServerSentEventsServerTransport(PipeReader application, string connectionId, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		public ServerSentEventsServerTransport(PipeReader application, string connectionId, HttpConnectionContext? connection, ILoggerFactory loggerFactory)
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
