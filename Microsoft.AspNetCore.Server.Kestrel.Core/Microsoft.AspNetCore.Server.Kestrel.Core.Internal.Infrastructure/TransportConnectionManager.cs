using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
	internal class TransportConnectionManager
	{
		public TransportConnectionManager(ConnectionManager connectionManager)
		{
			throw null;
		}

		public void AddConnection(long id, KestrelConnection connection)
		{
			throw null;
		}

		public void RemoveConnection(long id)
		{
			throw null;
		}

		public void StopTracking(long id)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CCloseAllConnectionsAsync_003Ed__6))]
		[DebuggerStepThrough]
		public Task<bool> CloseAllConnectionsAsync(CancellationToken token)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CAbortAllConnectionsAsync_003Ed__7))]
		[DebuggerStepThrough]
		public Task<bool> AbortAllConnectionsAsync()
		{
			throw null;
		}
	}
}
