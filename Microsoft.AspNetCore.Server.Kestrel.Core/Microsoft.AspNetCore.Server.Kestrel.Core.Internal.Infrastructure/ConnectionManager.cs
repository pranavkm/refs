using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
	internal class ConnectionManager
	{
		/// <summary>
		/// Connections that have been switched to a different protocol.
		/// </summary>
		public ResourceCounter UpgradedConnectionCount
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public ConnectionManager(IKestrelTrace trace, long? upgradedConnectionLimit)
		{
			throw null;
		}

		public ConnectionManager(IKestrelTrace trace, ResourceCounter upgradedConnections)
		{
			throw null;
		}

		public void AddConnection(long id, ConnectionReference connectionReference)
		{
			throw null;
		}

		public void RemoveConnection(long id)
		{
			throw null;
		}

		public void Walk(Action<KestrelConnection> callback)
		{
			throw null;
		}
	}
}
