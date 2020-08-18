using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Sources;

namespace Microsoft.AspNetCore.Server.IIS.Core.IO
{
	internal abstract class AsyncIOOperation : IValueTaskSource<int>, IValueTaskSource
	{
		public readonly struct AsyncContinuation
		{
			public Action<object> Continuation
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public object State
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public AsyncContinuation(Action<object> continuation, object state)
			{
				throw null;
			}

			public void Invoke()
			{
				throw null;
			}
		}

		public ValueTaskSourceStatus GetStatus(short token)
		{
			throw null;
		}

		public void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags)
		{
			throw null;
		}

		void IValueTaskSource.GetResult(short token)
		{
			throw null;
		}

		public int GetResult(short token)
		{
			throw null;
		}

		public AsyncContinuation? Invoke()
		{
			throw null;
		}

		protected abstract bool InvokeOperation(out int hr, out int bytes);

		public AsyncContinuation Complete(int hr, int bytes)
		{
			throw null;
		}

		protected virtual bool IsSuccessfulResult(int hr)
		{
			throw null;
		}

		public virtual void FreeOperationResources(int hr, int bytes)
		{
			throw null;
		}

		protected virtual void ResetOperation()
		{
			throw null;
		}

		protected AsyncIOOperation()
		{
			throw null;
		}
	}
}
