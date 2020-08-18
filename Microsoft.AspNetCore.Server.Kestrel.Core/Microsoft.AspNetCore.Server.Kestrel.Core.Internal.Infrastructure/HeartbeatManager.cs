using System;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
	internal class HeartbeatManager : IHeartbeatHandler, ISystemClock
	{
		public DateTimeOffset UtcNow
		{
			get
			{
				throw null;
			}
		}

		public long UtcNowTicks
		{
			get
			{
				throw null;
			}
		}

		public DateTimeOffset UtcNowUnsynchronized
		{
			get
			{
				throw null;
			}
		}

		public HeartbeatManager(ConnectionManager connectionManager)
		{
			throw null;
		}

		public void OnHeartbeat(DateTimeOffset now)
		{
			throw null;
		}
	}
}
