using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Internal
{
	internal class TimerAwaitable : IDisposable, ICriticalNotifyCompletion, INotifyCompletion
	{
		public bool IsCompleted
		{
			get
			{
				throw null;
			}
		}

		public TimerAwaitable(TimeSpan dueTime, TimeSpan period)
		{
			throw null;
		}

		public void Start()
		{
			throw null;
		}

		public TimerAwaitable GetAwaiter()
		{
			throw null;
		}

		public bool GetResult()
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

		public void Stop()
		{
			throw null;
		}

		void IDisposable.Dispose()
		{
			throw null;
		}
	}
}
