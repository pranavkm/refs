using System.Runtime.CompilerServices;

namespace System.Threading.Tasks
{
	/// <summary>
	/// Provides support for efficiently using Tasks to implement the APM (Begin/End) pattern.
	/// </summary>
	internal static class TaskToApm
	{
		/// <summary>Provides a simple IAsyncResult that wraps a Task.</summary>
		/// <remarks>
		/// We could use the Task as the IAsyncResult if the Task's AsyncState is the same as the object state,
		/// but that's very rare, in particular in a situation where someone cares about allocation, and always
		/// using TaskAsyncResult simplifies things and enables additional optimizations.
		/// </remarks>
		internal sealed class TaskAsyncResult : IAsyncResult
		{
			/// <summary>The wrapped Task.</summary>
			internal readonly Task _task;

			/// <summary>Gets a user-defined object that qualifies or contains information about an asynchronous operation.</summary>
			public object? AsyncState
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			/// <summary>Gets a value that indicates whether the asynchronous operation completed synchronously.</summary>
			/// <remarks>This is set lazily based on whether the <see cref="F:System.Threading.Tasks.TaskToApm.TaskAsyncResult._task" /> has completed by the time this object is created.</remarks>
			public bool CompletedSynchronously
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			/// <summary>Gets a value that indicates whether the asynchronous operation has completed.</summary>
			public bool IsCompleted
			{
				get
				{
					throw null;
				}
			}

			/// <summary>Gets a <see cref="T:System.Threading.WaitHandle" /> that is used to wait for an asynchronous operation to complete.</summary>
			public WaitHandle AsyncWaitHandle
			{
				[System.Runtime.CompilerServices.NullableContext(1)]
				get
				{
					throw null;
				}
			}

			/// <summary>Initializes the IAsyncResult with the Task to wrap and the associated object state.</summary>
			/// <param name="task">The Task to wrap.</param>
			/// <param name="state">The new AsyncState value.</param>
			/// <param name="callback">Callback to invoke when the wrapped task completes.</param>
			internal TaskAsyncResult(Task task, object? state, AsyncCallback? callback)
			{
				throw null;
			}
		}

		/// <summary>
		/// Marshals the Task as an IAsyncResult, using the supplied callback and state
		/// to implement the APM pattern.
		/// </summary>
		/// <param name="task">The Task to be marshaled.</param>
		/// <param name="callback">The callback to be invoked upon completion.</param>
		/// <param name="state">The state to be stored in the IAsyncResult.</param>
		/// <returns>An IAsyncResult to represent the task's asynchronous operation.</returns>
		public static IAsyncResult Begin(Task task, AsyncCallback? callback, object? state)
		{
			throw null;
		}

		/// <summary>Processes an IAsyncResult returned by Begin.</summary>
		/// <param name="asyncResult">The IAsyncResult to unwrap.</param>
		public static void End(IAsyncResult asyncResult)
		{
			throw null;
		}

		/// <summary>Processes an IAsyncResult returned by Begin.</summary>
		/// <param name="asyncResult">The IAsyncResult to unwrap.</param>
		public static TResult End<TResult>(IAsyncResult asyncResult)
		{
			throw null;
		}
	}
}
