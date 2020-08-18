using System;
using System.IO.Pipelines;
using System.Threading;

namespace Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.Internal
{
	internal class IOQueue : PipeScheduler, IThreadPoolWorkItem
	{
		private readonly struct Work
		{
			public readonly Action<object> Callback;

			public readonly object State;

			public Work(Action<object> callback, object state)
			{
				throw null;
			}
		}

		public override void Schedule(Action<object> action, object state)
		{
			throw null;
		}

		void IThreadPoolWorkItem.Execute()
		{
			throw null;
		}

		public IOQueue()
		{
			throw null;
		}
	}
}
