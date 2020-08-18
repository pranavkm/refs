using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	internal class HubFilterFactory : IHubFilter
	{
		public HubFilterFactory([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type filterType)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CInvokeMethodAsync_003Ed__3))]
		[DebuggerStepThrough]
		public ValueTask<object?> InvokeMethodAsync(HubInvocationContext invocationContext, Func<HubInvocationContext, ValueTask<object?>> next)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003COnConnectedAsync_003Ed__4))]
		[DebuggerStepThrough]
		public Task OnConnectedAsync(HubLifetimeContext context, Func<HubLifetimeContext, Task> next)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003COnDisconnectedAsync_003Ed__5))]
		[DebuggerStepThrough]
		public Task OnDisconnectedAsync(HubLifetimeContext context, Exception? exception, Func<HubLifetimeContext, Exception?, Task> next)
		{
			throw null;
		}
	}
}
