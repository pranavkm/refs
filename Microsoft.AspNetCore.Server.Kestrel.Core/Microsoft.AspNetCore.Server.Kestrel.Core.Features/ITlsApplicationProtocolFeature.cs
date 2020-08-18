using System;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Features
{
	public interface ITlsApplicationProtocolFeature
	{
		ReadOnlyMemory<byte> ApplicationProtocol
		{
			get;
		}
	}
}
