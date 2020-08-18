using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2
{
	internal class ThreadPoolAwaitable : ICriticalNotifyCompletion, INotifyCompletion
	{
		public static readonly ThreadPoolAwaitable Instance;

		public bool IsCompleted
		{
			get
			{
				throw null;
			}
		}

		public ThreadPoolAwaitable GetAwaiter()
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
