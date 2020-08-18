using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// Dispatches external actions to be executed on the context of a <see cref="T:Microsoft.AspNetCore.Components.RenderTree.Renderer" />.
	/// </summary>
	public abstract class Dispatcher
	{
		/// <summary>
		/// Provides notifications of unhandled exceptions that occur within the dispatcher.
		/// </summary>
		internal event UnhandledExceptionEventHandler? UnhandledException
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			add
			{
				throw null;
			}
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			remove
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a default instance of <see cref="T:Microsoft.AspNetCore.Components.Dispatcher" />.
		/// </summary>
		/// <returns>A <see cref="T:Microsoft.AspNetCore.Components.Dispatcher" /> instance.</returns>
		public static Dispatcher CreateDefault()
		{
			throw null;
		}

		/// <summary>
		/// Validates that the currently executing code is running inside the dispatcher.
		/// </summary>
		public void AssertAccess()
		{
			throw null;
		}

		/// <summary>
		/// Returns a value that determines whether using the dispatcher to invoke a work item is required
		/// from the current context.
		/// </summary>
		/// <returns><c>true</c> if invoking is required, otherwise <c>false</c>.</returns>
		public abstract bool CheckAccess();

		/// <summary>
		/// Invokes the given <see cref="T:System.Action" /> in the context of the associated <see cref="T:Microsoft.AspNetCore.Components.RenderTree.Renderer" />.
		/// </summary>
		/// <param name="workItem">The action to execute.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that will be completed when the action has finished executing.</returns>
		public abstract Task InvokeAsync(Action workItem);

		/// <summary>
		/// Invokes the given <see cref="T:System.Func`1" /> in the context of the associated <see cref="T:Microsoft.AspNetCore.Components.RenderTree.Renderer" />.
		/// </summary>
		/// <param name="workItem">The asynchronous action to execute.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task" /> that will be completed when the action has finished executing.</returns>
		public abstract Task InvokeAsync(Func<Task> workItem);

		/// <summary>
		/// Invokes the given <see cref="T:System.Func`1" /> in the context of the associated <see cref="T:Microsoft.AspNetCore.Components.RenderTree.Renderer" />.
		/// </summary>
		/// <param name="workItem">The function to execute.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task`1" /> that will be completed when the function has finished executing.</returns>
		public abstract Task<TResult> InvokeAsync<TResult>(Func<TResult> workItem);

		/// <summary>
		/// Invokes the given <see cref="T:System.Func`1" /> in the context of the associated <see cref="T:Microsoft.AspNetCore.Components.RenderTree.Renderer" />.
		/// </summary>
		/// <param name="workItem">The asynchronous function to execute.</param>
		/// <returns>A <see cref="T:System.Threading.Tasks.Task`1" /> that will be completed when the function has finished executing.</returns>
		public abstract Task<TResult> InvokeAsync<TResult>(Func<Task<TResult>> workItem);

		/// <summary>
		/// Called to notify listeners of an unhandled exception.
		/// </summary>
		/// <param name="e">The <see cref="T:System.UnhandledExceptionEventArgs" />.</param>
		protected void OnUnhandledException(UnhandledExceptionEventArgs e)
		{
			throw null;
		}

		protected Dispatcher()
		{
			throw null;
		}
	}
}
