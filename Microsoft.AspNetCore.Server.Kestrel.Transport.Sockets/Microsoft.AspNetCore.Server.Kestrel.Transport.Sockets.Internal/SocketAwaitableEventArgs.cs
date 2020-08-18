using System;
using System.IO.Pipelines;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.Internal
{
	internal sealed class SocketAwaitableEventArgs : SocketAsyncEventArgs, ICriticalNotifyCompletion, INotifyCompletion
	{
		public bool IsCompleted
		{
			get
			{
				throw null;
			}
		}

		public SocketAwaitableEventArgs(PipeScheduler ioScheduler)
		{
			throw null;
		}

		public SocketAwaitableEventArgs GetAwaiter()
		{
			throw null;
		}

		public int GetResult()
		{
			throw null;
		}

		public void OnCompleted(Action continuation)
		{
			throw null;
		}

		public void UnsafeOnCompleted(Action continuation)
		{
			throw null;
		}

		public void Complete()
		{
			throw null;
		}

		protected override void OnCompleted(SocketAsyncEventArgs _)
		{
			throw null;
		}
	}
}
