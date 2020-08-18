namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2
{
	internal enum Http2FrameType : byte
	{
		DATA,
		HEADERS,
		PRIORITY,
		RST_STREAM,
		SETTINGS,
		PUSH_PROMISE,
		PING,
		GOAWAY,
		WINDOW_UPDATE,
		CONTINUATION
	}
}
