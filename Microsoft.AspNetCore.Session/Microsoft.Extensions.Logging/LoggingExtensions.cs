using System;

namespace Microsoft.Extensions.Logging
{
	internal static class LoggingExtensions
	{
		public static void ErrorClosingTheSession(this ILogger logger, Exception exception)
		{
			throw null;
		}

		public static void AccessingExpiredSession(this ILogger logger, string sessionKey)
		{
			throw null;
		}

		public static void SessionStarted(this ILogger logger, string sessionKey, string sessionId)
		{
			throw null;
		}

		public static void SessionLoaded(this ILogger logger, string sessionKey, string sessionId, int count)
		{
			throw null;
		}

		public static void SessionStored(this ILogger logger, string sessionKey, string sessionId, int count)
		{
			throw null;
		}

		public static void SessionCacheReadException(this ILogger logger, string sessionKey, Exception exception)
		{
			throw null;
		}

		public static void ErrorUnprotectingSessionCookie(this ILogger logger, Exception exception)
		{
			throw null;
		}

		public static void SessionLoadingTimeout(this ILogger logger)
		{
			throw null;
		}

		public static void SessionCommitTimeout(this ILogger logger)
		{
			throw null;
		}

		public static void SessionCommitCanceled(this ILogger logger)
		{
			throw null;
		}

		public static void SessionRefreshTimeout(this ILogger logger)
		{
			throw null;
		}

		public static void SessionRefreshCanceled(this ILogger logger)
		{
			throw null;
		}
	}
}
