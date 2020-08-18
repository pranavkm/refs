using System;

namespace Microsoft.AspNetCore.Connections
{
	[Flags]
	public enum TransferFormat
	{
		Binary = 0x1,
		Text = 0x2
	}
}
