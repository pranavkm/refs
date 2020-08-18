using Microsoft.JSInterop;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components.Web.Virtualization
{
	internal class VirtualizeJsInterop : IAsyncDisposable
	{
		public VirtualizeJsInterop(IVirtualizeJsCallbacks owner, IJSRuntime jsRuntime)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CInitializeAsync_003Ed__5))]
		[DebuggerStepThrough]
		public ValueTask InitializeAsync(ElementReference spacerBefore, ElementReference spacerAfter)
		{
			throw null;
		}

		[JSInvokable]
		public void OnSpacerBeforeVisible(float spacerSize, float containerSize)
		{
			throw null;
		}

		[JSInvokable]
		public void OnSpacerAfterVisible(float spacerSize, float containerSize)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CDisposeAsync_003Ed__8))]
		[DebuggerStepThrough]
		public ValueTask DisposeAsync()
		{
			throw null;
		}
	}
}
