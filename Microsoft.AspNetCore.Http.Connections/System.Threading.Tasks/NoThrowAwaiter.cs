using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	internal readonly struct NoThrowAwaiter : ICriticalNotifyCompletion, INotifyCompletion
	{
		private readonly Task _task;

		public bool IsCompleted
		{
			get
			{
				throw null;
			}
		}

		public NoThrowAwaiter(Task task)
		{
			throw null;
		}

		public NoThrowAwaiter GetAwaiter()
		{
			throw null;
		}

		public void GetResult()
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
	}
}
