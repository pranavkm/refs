using System.Buffers;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http.Connections
{
	internal static class ServerSentEventsMessageFormatter
	{
		[AsyncStateMachine(typeof(_003CWriteMessageAsync_003Ed__3))]
		[DebuggerStepThrough]
		public static Task WriteMessageAsync(ReadOnlySequence<byte> payload, Stream output, CancellationToken token)
		{
			throw null;
		}
	}
}
