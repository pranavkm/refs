namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
	internal interface ITimeoutHandler
	{
		void OnTimeout(TimeoutReason reason);
	}
}
