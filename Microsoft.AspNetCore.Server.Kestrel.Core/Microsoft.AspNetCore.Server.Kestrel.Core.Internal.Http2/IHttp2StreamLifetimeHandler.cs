namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2
{
	internal interface IHttp2StreamLifetimeHandler
	{
		void OnStreamCompleted(Http2Stream stream);

		void DecrementActiveClientStreamCount();
	}
}
