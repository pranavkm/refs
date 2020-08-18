using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure;
using System;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal
{
	internal class ConnectionDispatcher<T> where T : BaseConnectionContext
	{
		public ConnectionDispatcher(ServiceContext serviceContext, Func<T, Task> connectionDelegate, TransportConnectionManager transportConnectionManager)
		{
			throw null;
		}

		public Task StartAcceptingConnections(IConnectionListener<T> listener)
		{
			throw null;
		}
	}
}
