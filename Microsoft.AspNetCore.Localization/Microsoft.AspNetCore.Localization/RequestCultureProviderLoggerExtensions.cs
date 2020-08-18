using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Primitives;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Localization
{
	internal static class RequestCultureProviderLoggerExtensions
	{
		public static void UnsupportedCultures(this ILogger logger, string requestCultureProvider, IList<StringSegment> cultures)
		{
			throw null;
		}

		public static void UnsupportedUICultures(this ILogger logger, string requestCultureProvider, IList<StringSegment> uiCultures)
		{
			throw null;
		}
	}
}
