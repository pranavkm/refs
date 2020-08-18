using System;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	[Flags]
	internal enum ConnectionOptions
	{
		None = 0x0,
		Close = 0x1,
		KeepAlive = 0x2,
		Upgrade = 0x4
	}
}
