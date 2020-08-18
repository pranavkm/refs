using System;

namespace Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.Internal
{
	internal static class BufferExtensions
	{
		public static ArraySegment<byte> GetArray(this Memory<byte> memory)
		{
			throw null;
		}

		public static ArraySegment<byte> GetArray(this ReadOnlyMemory<byte> memory)
		{
			throw null;
		}
	}
}
