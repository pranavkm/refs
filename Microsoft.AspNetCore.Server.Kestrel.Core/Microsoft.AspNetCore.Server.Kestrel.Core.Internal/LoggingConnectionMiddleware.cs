using Microsoft.AspNetCore.Connections;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal
{
	internal class LoggingConnectionMiddleware
	{
		private class LoggingDuplexPipe : DuplexPipeStreamAdapter<LoggingStream>
		{
			public LoggingDuplexPipe(IDuplexPipe transport, ILogger logger)
			{
				throw null;
			}
		}

		public LoggingConnectionMiddleware(ConnectionDelegate next, ILogger logger)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003COnConnectionAsync_003Ed__3))]
		[DebuggerStepThrough]
		public Task OnConnectionAsync(ConnectionContext context)
		{
			throw null;
		}
	}
}
