namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
	internal enum TimeoutReason
	{
		None,
		KeepAlive,
		RequestHeaders,
		ReadDataRate,
		WriteDataRate,
		RequestBodyDrain,
		TimeoutFeature
	}
}
