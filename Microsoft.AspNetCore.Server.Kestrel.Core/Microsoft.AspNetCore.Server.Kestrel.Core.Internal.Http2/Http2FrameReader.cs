using System.Buffers;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2
{
	internal static class Http2FrameReader
	{
		public const int HeaderLength = 9;

		public const int SettingSize = 6;

		public static bool TryReadFrame(ref ReadOnlySequence<byte> buffer, Http2Frame frame, uint maxFrameSize, out ReadOnlySequence<byte> framePayload)
		{
			throw null;
		}

		public static int GetPayloadFieldsLength(Http2Frame frame)
		{
			throw null;
		}

		public static IList<Http2PeerSetting> ReadSettings(in ReadOnlySequence<byte> payload)
		{
			throw null;
		}
	}
}
