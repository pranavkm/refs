using Microsoft.Extensions.Primitives;

namespace Microsoft.AspNetCore.Http
{
	internal static class ParsingHelpers
	{
		public static StringValues GetHeader(IHeaderDictionary headers, string key)
		{
			throw null;
		}

		public static StringValues GetHeaderSplit(IHeaderDictionary headers, string key)
		{
			throw null;
		}

		public static StringValues GetHeaderUnmodified(IHeaderDictionary headers, string key)
		{
			throw null;
		}

		public static void SetHeaderJoined(IHeaderDictionary headers, string key, StringValues value)
		{
			throw null;
		}

		public static void SetHeaderUnmodified(IHeaderDictionary headers, string key, StringValues? values)
		{
			throw null;
		}

		public static void AppendHeaderJoined(IHeaderDictionary headers, string key, params string[] values)
		{
			throw null;
		}

		public static void AppendHeaderUnmodified(IHeaderDictionary headers, string key, StringValues values)
		{
			throw null;
		}
	}
}
