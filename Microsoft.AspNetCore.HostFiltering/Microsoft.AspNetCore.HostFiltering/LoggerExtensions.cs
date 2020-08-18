using Microsoft.Extensions.Logging;

namespace Microsoft.AspNetCore.HostFiltering
{
	internal static class LoggerExtensions
	{
		public static void WildcardDetected(this ILogger logger)
		{
			throw null;
		}

		public static void AllowedHosts(this ILogger logger, string allowedHosts)
		{
			throw null;
		}

		public static void AllHostsAllowed(this ILogger logger)
		{
			throw null;
		}

		public static void RequestRejectedMissingHost(this ILogger logger, string protocol)
		{
			throw null;
		}

		public static void RequestAllowedMissingHost(this ILogger logger, string protocol)
		{
			throw null;
		}

		public static void AllowedHostMatched(this ILogger logger, string host)
		{
			throw null;
		}

		public static void NoAllowedHostMatched(this ILogger logger, string host)
		{
			throw null;
		}
	}
}
