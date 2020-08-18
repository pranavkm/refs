using System;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
	internal interface IHeartbeatHandler
	{
		void OnHeartbeat(DateTimeOffset now);
	}
}
