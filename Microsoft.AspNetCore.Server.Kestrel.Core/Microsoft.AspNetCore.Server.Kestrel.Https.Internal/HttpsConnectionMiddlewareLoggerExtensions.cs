using Microsoft.Extensions.Logging;
using System;
using System.Security.Authentication;

namespace Microsoft.AspNetCore.Server.Kestrel.Https.Internal
{
	internal static class HttpsConnectionMiddlewareLoggerExtensions
	{
		public static void AuthenticationFailed(this ILogger<HttpsConnectionMiddleware> logger, Exception exception)
		{
			throw null;
		}

		public static void AuthenticationTimedOut(this ILogger<HttpsConnectionMiddleware> logger)
		{
			throw null;
		}

		public static void HttpsConnectionEstablished(this ILogger<HttpsConnectionMiddleware> logger, string connectionId, SslProtocols sslProtocol)
		{
			throw null;
		}

		public static void Http2DefaultCiphersInsufficient(this ILogger<HttpsConnectionMiddleware> logger)
		{
			throw null;
		}
	}
}
