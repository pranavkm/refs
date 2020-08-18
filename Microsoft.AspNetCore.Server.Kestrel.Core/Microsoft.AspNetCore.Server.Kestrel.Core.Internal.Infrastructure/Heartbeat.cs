using System;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
	internal class Heartbeat : IDisposable
	{
		public static readonly TimeSpan Interval;

		public Heartbeat(IHeartbeatHandler[] callbacks, ISystemClock systemClock, IDebugger debugger, IKestrelTrace trace)
		{
			throw null;
		}

		public void Start()
		{
			throw null;
		}

		internal void OnHeartbeat()
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}
	}
}
