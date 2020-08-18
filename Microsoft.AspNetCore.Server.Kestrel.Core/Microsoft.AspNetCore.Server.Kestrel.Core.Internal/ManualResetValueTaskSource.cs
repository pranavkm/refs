using System;
using System.Threading.Tasks.Sources;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal
{
	internal sealed class ManualResetValueTaskSource<T> : IValueTaskSource<T>, IValueTaskSource
	{
		public bool RunContinuationsAsynchronously
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public short Version
		{
			get
			{
				throw null;
			}
		}

		public void Reset()
		{
			throw null;
		}

		public void SetResult(T result)
		{
			throw null;
		}

		public void SetException(Exception error)
		{
			throw null;
		}

		public T GetResult(short token)
		{
			throw null;
		}

		void IValueTaskSource.GetResult(short token)
		{
			throw null;
		}

		public ValueTaskSourceStatus GetStatus(short token)
		{
			throw null;
		}

		public void OnCompleted(Action<object> continuation, object state, short token, ValueTaskSourceOnCompletedFlags flags)
		{
			throw null;
		}

		public ValueTaskSourceStatus GetStatus()
		{
			throw null;
		}

		public void TrySetResult(T result)
		{
			throw null;
		}

		public ManualResetValueTaskSource()
		{
			throw null;
		}
	}
}
