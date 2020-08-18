namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2
{
	internal enum Http2ErrorCode : uint
	{
		NO_ERROR,
		PROTOCOL_ERROR,
		INTERNAL_ERROR,
		FLOW_CONTROL_ERROR,
		SETTINGS_TIMEOUT,
		STREAM_CLOSED,
		FRAME_SIZE_ERROR,
		REFUSED_STREAM,
		CANCEL,
		COMPRESSION_ERROR,
		CONNECT_ERROR,
		ENHANCE_YOUR_CALM,
		INADEQUATE_SECURITY,
		HTTP_1_1_REQUIRED
	}
}
