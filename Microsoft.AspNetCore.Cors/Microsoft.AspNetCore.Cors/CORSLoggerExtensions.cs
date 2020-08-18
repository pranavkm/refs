using Microsoft.Extensions.Logging;
using System;

namespace Microsoft.AspNetCore.Cors
{
	internal static class CORSLoggerExtensions
	{
		public static void IsPreflightRequest(this ILogger logger)
		{
			throw null;
		}

		public static void RequestHasOriginHeader(this ILogger logger, string origin)
		{
			throw null;
		}

		public static void RequestDoesNotHaveOriginHeader(this ILogger logger)
		{
			throw null;
		}

		public static void PolicySuccess(this ILogger logger)
		{
			throw null;
		}

		public static void PolicyFailure(this ILogger logger)
		{
			throw null;
		}

		public static void OriginNotAllowed(this ILogger logger, string origin)
		{
			throw null;
		}

		public static void AccessControlMethodNotAllowed(this ILogger logger, string accessControlMethod)
		{
			throw null;
		}

		public static void RequestHeaderNotAllowed(this ILogger logger, string requestHeader)
		{
			throw null;
		}

		public static void FailedToSetCorsHeaders(this ILogger logger, Exception exception)
		{
			throw null;
		}

		public static void NoCorsPolicyFound(this ILogger logger)
		{
			throw null;
		}

		public static void IsNotPreflightRequest(this ILogger logger)
		{
			throw null;
		}
	}
}
