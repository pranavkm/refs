using System;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Internal
{
	/// <summary>
	/// Provides a common awaitable structure that <see cref="M:Microsoft.Extensions.Internal.ObjectMethodExecutor.ExecuteAsync(System.Object,System.Object[])" /> can
	/// return, regardless of whether the underlying value is a System.Task, an FSharpAsync, or an
	/// application-defined custom awaitable.
	/// </summary>
	internal readonly struct ObjectMethodExecutorAwaitable
	{
		public readonly struct Awaiter : ICriticalNotifyCompletion, INotifyCompletion
		{
			private readonly object _customAwaiter;

			private readonly Func<object, bool> _isCompletedMethod;

			private readonly Func<object, object> _getResultMethod;

			private readonly Action<object, Action> _onCompletedMethod;

			private readonly Action<object, Action> _unsafeOnCompletedMethod;

			public bool IsCompleted
			{
				get
				{
					throw null;
				}
			}

			public Awaiter(object customAwaiter, Func<object, bool> isCompletedMethod, Func<object, object> getResultMethod, Action<object, Action> onCompletedMethod, Action<object, Action> unsafeOnCompletedMethod)
			{
				throw null;
			}

			public object GetResult()
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

		private readonly object _customAwaitable;

		private readonly Func<object, object> _getAwaiterMethod;

		private readonly Func<object, bool> _isCompletedMethod;

		private readonly Func<object, object> _getResultMethod;

		private readonly Action<object, Action> _onCompletedMethod;

		private readonly Action<object, Action> _unsafeOnCompletedMethod;

		public ObjectMethodExecutorAwaitable(object customAwaitable, Func<object, object> getAwaiterMethod, Func<object, bool> isCompletedMethod, Func<object, object> getResultMethod, Action<object, Action> onCompletedMethod, Action<object, Action> unsafeOnCompletedMethod)
		{
			throw null;
		}

		public Awaiter GetAwaiter()
		{
			throw null;
		}
	}
}
