using System;
using System.IO.Pipelines;
using System.Net.Sockets;

namespace Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.Internal
{
	internal sealed class SocketReceiver : SocketSenderReceiverBase
	{
		public SocketReceiver(Socket socket, PipeScheduler scheduler)
		{
			throw null;
		}

		public SocketAwaitableEventArgs WaitForDataAsync()
		{
			throw null;
		}

		public SocketAwaitableEventArgs ReceiveAsync(Memory<byte> buffer)
		{
			throw null;
		}
	}
}
