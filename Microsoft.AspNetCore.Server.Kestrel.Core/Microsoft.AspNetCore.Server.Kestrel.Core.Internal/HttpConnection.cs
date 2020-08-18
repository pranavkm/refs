using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal
{
	internal class HttpConnection : ITimeoutHandler
	{
		private enum ProtocolSelectionState
		{
			Initializing,
			Selected,
			Aborted
		}

		public HttpConnection(HttpConnectionContext context)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CProcessRequestsAsync_003Ed__12<>))]
		[DebuggerStepThrough]
		public Task ProcessRequestsAsync<TContext>(IHttpApplication<TContext> httpApplication)
		{
			throw null;
		}

		internal void Initialize(IRequestProcessor requestProcessor)
		{
			throw null;
		}

		public void OnTimeout(TimeoutReason reason)
		{
			throw null;
		}
	}
}
