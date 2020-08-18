using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components.Rendering
{
	[DebuggerDisplay("{_state,nq}")]
	internal class RendererSynchronizationContext : SynchronizationContext
	{
		private class State
		{
			public bool IsBusy;

			public object Lock;

			public Task Task;

			public override string ToString()
			{
				throw null;
			}

			public State()
			{
				throw null;
			}
		}

		private class WorkItem
		{
			public RendererSynchronizationContext SynchronizationContext;

			public ExecutionContext ExecutionContext;

			public SendOrPostCallback Callback;

			public object State;

			public WorkItem()
			{
				throw null;
			}
		}

		private class RendererSynchronizationTaskCompletionSource<TCallback, TResult> : TaskCompletionSource<TResult>
		{
			public TCallback Callback
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public RendererSynchronizationTaskCompletionSource(TCallback callback)
			{
				throw null;
			}
		}

		public event UnhandledExceptionEventHandler UnhandledException
		{
			[CompilerGenerated]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			remove
			{
				throw null;
			}
		}

		public RendererSynchronizationContext()
		{
			throw null;
		}

		public Task InvokeAsync(Action action)
		{
			throw null;
		}

		public Task InvokeAsync(Func<Task> asyncAction)
		{
			throw null;
		}

		public Task<TResult> InvokeAsync<TResult>(Func<TResult> function)
		{
			throw null;
		}

		public Task<TResult> InvokeAsync<TResult>(Func<Task<TResult>> asyncFunction)
		{
			throw null;
		}

		public override void Post(SendOrPostCallback d, object state)
		{
			throw null;
		}

		public override void Send(SendOrPostCallback d, object state)
		{
			throw null;
		}

		public override SynchronizationContext CreateCopy()
		{
			throw null;
		}
	}
}
