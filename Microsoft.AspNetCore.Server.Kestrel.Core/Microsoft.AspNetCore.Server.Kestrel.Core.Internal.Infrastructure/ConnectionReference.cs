using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
	internal class ConnectionReference
	{
		public string ConnectionId
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public ConnectionReference(long id, KestrelConnection connection, TransportConnectionManager transportConnectionManager)
		{
			throw null;
		}

		public bool TryGetConnection(out KestrelConnection connection)
		{
			throw null;
		}

		public void StopTrasnsportTracking()
		{
			throw null;
		}
	}
}
