using Microsoft.Extensions.Logging;

namespace Microsoft.AspNetCore.HttpsPolicy
{
	internal static class HttpsLoggingExtensions
	{
		public static void RedirectingToHttps(this ILogger logger, string redirect)
		{
			throw null;
		}

		public static void PortLoadedFromConfig(this ILogger logger, int port)
		{
			throw null;
		}

		public static void FailedToDeterminePort(this ILogger logger)
		{
			throw null;
		}

		public static void FailedMultiplePorts(this ILogger logger)
		{
			throw null;
		}

		public static void PortFromServer(this ILogger logger, int port)
		{
			throw null;
		}
	}
}
