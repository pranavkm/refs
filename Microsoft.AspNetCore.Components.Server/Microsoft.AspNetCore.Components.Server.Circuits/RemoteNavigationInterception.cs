using Microsoft.AspNetCore.Components.Routing;
using Microsoft.JSInterop;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Components.Server.Circuits
{
	internal sealed class RemoteNavigationInterception : INavigationInterception
	{
		public bool HasAttachedJSRuntime
		{
			get
			{
				throw null;
			}
		}

		public void AttachJSRuntime(IJSRuntime jsRuntime)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CEnableNavigationInterceptionAsync_003Ed__4))]
		[DebuggerStepThrough]
		public Task EnableNavigationInterceptionAsync()
		{
			throw null;
		}

		public RemoteNavigationInterception()
		{
			throw null;
		}
	}
}
