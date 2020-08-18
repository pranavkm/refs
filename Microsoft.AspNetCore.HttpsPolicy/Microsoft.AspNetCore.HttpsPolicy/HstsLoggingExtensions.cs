using Microsoft.Extensions.Logging;

namespace Microsoft.AspNetCore.HttpsPolicy
{
	internal static class HstsLoggingExtensions
	{
		public static void SkippingInsecure(this ILogger logger)
		{
			throw null;
		}

		public static void SkippingExcludedHost(this ILogger logger, string host)
		{
			throw null;
		}

		public static void AddingHstsHeader(this ILogger logger)
		{
			throw null;
		}
	}
}
