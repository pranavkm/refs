using System;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components.Rendering
{
	internal class RendererSynchronizationContextDispatcher : Dispatcher
	{
		public RendererSynchronizationContextDispatcher()
		{
			throw null;
		}

		public override bool CheckAccess()
		{
			throw null;
		}

		public override Task InvokeAsync(Action workItem)
		{
			throw null;
		}

		public override Task InvokeAsync(Func<Task> workItem)
		{
			throw null;
		}

		public override Task<TResult> InvokeAsync<TResult>(Func<TResult> workItem)
		{
			throw null;
		}

		public override Task<TResult> InvokeAsync<TResult>(Func<Task<TResult>> workItem)
		{
			throw null;
		}
	}
}
