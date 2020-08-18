namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2
{
	internal enum KeepAliveState
	{
		None,
		SendPing,
		PingSent,
		Timeout
	}
}
