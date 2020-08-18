using System;
using System.IO.Pipelines;
using System.Net.Sockets;

namespace Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.Internal
{
	internal abstract class SocketSenderReceiverBase : IDisposable
	{
		protected readonly Socket _socket;

		protected readonly SocketAwaitableEventArgs _awaitableEventArgs;

		protected SocketSenderReceiverBase(Socket socket, PipeScheduler scheduler)
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}
	}
}
