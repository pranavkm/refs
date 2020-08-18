using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.AspNetCore.Internal
{
	internal static class AwaitableThreadPool
	{
		[StructLayout(LayoutKind.Sequential, Size = 1)]
		public readonly struct Awaitable : ICriticalNotifyCompletion, INotifyCompletion
		{
			public bool IsCompleted
			{
				get
				{
					throw null;
				}
			}

			public void GetResult()
			{
				throw null;
			}

			public Awaitable GetAwaiter()
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

		public static Awaitable Yield()
		{
			throw null;
		}
	}
}
