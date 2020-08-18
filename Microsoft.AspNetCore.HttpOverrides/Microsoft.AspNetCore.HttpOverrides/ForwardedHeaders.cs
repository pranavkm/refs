using System;

namespace Microsoft.AspNetCore.HttpOverrides
{
	[Flags]
	public enum ForwardedHeaders
	{
		None = 0x0,
		XForwardedFor = 0x1,
		XForwardedHost = 0x2,
		XForwardedProto = 0x4,
		All = 0x7
	}
}
