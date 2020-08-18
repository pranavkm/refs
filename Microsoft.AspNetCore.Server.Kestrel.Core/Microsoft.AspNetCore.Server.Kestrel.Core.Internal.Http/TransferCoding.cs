using System;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	[Flags]
	internal enum TransferCoding
	{
		None = 0x0,
		Chunked = 0x1,
		Other = 0x2
	}
}
