using System;

namespace Microsoft.AspNetCore.Server.Kestrel.Core
{
	[Flags]
	public enum HttpProtocols
	{
		None = 0x0,
		Http1 = 0x1,
		Http2 = 0x2,
		Http1AndHttp2 = 0x3,
		Http3 = 0x4,
		Http1AndHttp2AndHttp3 = 0x7
	}
}
