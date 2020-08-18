namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	public enum HttpVersion : sbyte
	{
		Unknown = -1,
		Http10,
		Http11,
		Http2,
		Http3
	}
}
