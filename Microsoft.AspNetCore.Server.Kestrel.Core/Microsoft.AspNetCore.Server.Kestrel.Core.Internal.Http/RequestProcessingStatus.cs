namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	internal enum RequestProcessingStatus
	{
		RequestPending,
		ParsingRequestLine,
		ParsingHeaders,
		AppStarted,
		HeadersCommitted,
		HeadersFlushed,
		ResponseCompleted
	}
}
