namespace Microsoft.Extensions.Logging
{
	internal static class LoggingExtensions
	{
		public static void AuthenticationSchemeAuthenticated(this ILogger logger, string authenticationScheme)
		{
			throw null;
		}

		public static void AuthenticationSchemeNotAuthenticated(this ILogger logger, string authenticationScheme)
		{
			throw null;
		}

		public static void AuthenticationSchemeNotAuthenticatedWithFailure(this ILogger logger, string authenticationScheme, string failureMessage)
		{
			throw null;
		}

		public static void AuthenticationSchemeChallenged(this ILogger logger, string authenticationScheme)
		{
			throw null;
		}

		public static void AuthenticationSchemeForbidden(this ILogger logger, string authenticationScheme)
		{
			throw null;
		}

		public static void RemoteAuthenticationError(this ILogger logger, string errorMessage)
		{
			throw null;
		}

		public static void SignInHandled(this ILogger logger)
		{
			throw null;
		}

		public static void SignInSkipped(this ILogger logger)
		{
			throw null;
		}

		public static void CorrelationPropertyNotFound(this ILogger logger, string correlationPrefix)
		{
			throw null;
		}

		public static void CorrelationCookieNotFound(this ILogger logger, string cookieName)
		{
			throw null;
		}

		public static void UnexpectedCorrelationCookieValue(this ILogger logger, string cookieName, string cookieValue)
		{
			throw null;
		}

		public static void AccessDeniedError(this ILogger logger)
		{
			throw null;
		}

		public static void AccessDeniedContextHandled(this ILogger logger)
		{
			throw null;
		}

		public static void AccessDeniedContextSkipped(this ILogger logger)
		{
			throw null;
		}
	}
}
