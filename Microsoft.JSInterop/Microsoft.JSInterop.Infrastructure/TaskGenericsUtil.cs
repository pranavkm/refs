using System;
using System.Threading.Tasks;

namespace Microsoft.JSInterop.Infrastructure
{
	internal static class TaskGenericsUtil
	{
		private interface ITcsResultSetter
		{
			Type ResultType
			{
				get;
			}

			void SetResult(object taskCompletionSource, object? result);

			void SetException(object taskCompletionSource, Exception exception);
		}

		private interface ITaskResultGetter
		{
			object? GetResult(Task task);
		}

		private class TaskResultGetter<T> : ITaskResultGetter
		{
			public object? GetResult(Task task)
			{
				throw null;
			}

			public TaskResultGetter()
			{
				throw null;
			}
		}

		private class VoidTaskResultGetter : ITaskResultGetter
		{
			public object? GetResult(Task task)
			{
				throw null;
			}

			public VoidTaskResultGetter()
			{
				throw null;
			}
		}

		private class TcsResultSetter<T> : ITcsResultSetter
		{
			public Type ResultType
			{
				get
				{
					throw null;
				}
			}

			public void SetResult(object tcs, object? result)
			{
				throw null;
			}

			public void SetException(object tcs, Exception exception)
			{
				throw null;
			}

			public TcsResultSetter()
			{
				throw null;
			}
		}

		public static void SetTaskCompletionSourceResult(object taskCompletionSource, object? result)
		{
			throw null;
		}

		public static void SetTaskCompletionSourceException(object taskCompletionSource, Exception exception)
		{
			throw null;
		}

		public static Type GetTaskCompletionSourceResultType(object taskCompletionSource)
		{
			throw null;
		}

		public static object? GetTaskResult(Task task)
		{
			throw null;
		}
	}
}
