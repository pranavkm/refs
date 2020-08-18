using Microsoft.Extensions.Logging;
using System;

namespace Microsoft.AspNetCore.Antiforgery
{
	internal static class AntiforgeryLoggerExtensions
	{
		public static void ValidationFailed(this ILogger logger, string message)
		{
			throw null;
		}

		public static void ValidatedAntiforgeryToken(this ILogger logger)
		{
			throw null;
		}

		public static void MissingCookieToken(this ILogger logger, string? cookieName)
		{
			throw null;
		}

		public static void MissingRequestToken(this ILogger logger, string formFieldName, string? headerName)
		{
			throw null;
		}

		public static void NewCookieToken(this ILogger logger)
		{
			throw null;
		}

		public static void ReusedCookieToken(this ILogger logger)
		{
			throw null;
		}

		public static void TokenDeserializeException(this ILogger logger, Exception exception)
		{
			throw null;
		}

		public static void ResponseCacheHeadersOverridenToNoCache(this ILogger logger)
		{
			throw null;
		}

		public static void FailedToDeserialzeTokens(this ILogger logger, Exception exception)
		{
			throw null;
		}
	}
}
