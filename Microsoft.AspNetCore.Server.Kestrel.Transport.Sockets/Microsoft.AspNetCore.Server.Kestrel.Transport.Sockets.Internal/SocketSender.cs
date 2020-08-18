using System.Buffers;
using System.IO.Pipelines;
using System.Net.Sockets;

namespace Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.Internal
{
	internal sealed class SocketSender : SocketSenderReceiverBase
	{
		public SocketSender(Socket socket, PipeScheduler scheduler)
		{
			throw null;
		}

		public SocketAwaitableEventArgs SendAsync(in ReadOnlySequence<byte> buffers)
		{
			throw null;
		}
	}
}
