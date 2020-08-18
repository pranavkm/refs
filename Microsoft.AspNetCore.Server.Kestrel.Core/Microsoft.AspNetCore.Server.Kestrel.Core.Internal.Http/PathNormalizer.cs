using System;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http
{
	internal static class PathNormalizer
	{
		public static string DecodePath(Span<byte> path, bool pathEncoded, string rawTarget, int queryLength)
		{
			throw null;
		}

		public static int RemoveDotSegments(Span<byte> input)
		{
			throw null;
		}

		public unsafe static int RemoveDotSegments(byte* start, byte* end)
		{
			throw null;
		}

		public unsafe static bool ContainsDotSegments(byte* start, byte* end)
		{
			throw null;
		}
	}
}
