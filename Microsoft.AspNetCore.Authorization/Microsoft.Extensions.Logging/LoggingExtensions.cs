using Microsoft.AspNetCore.Authorization;

namespace Microsoft.Extensions.Logging
{
	internal static class LoggingExtensions
	{
		public static void UserAuthorizationSucceeded(this ILogger logger)
		{
			throw null;
		}

		public static void UserAuthorizationFailed(this ILogger logger, AuthorizationFailure failure)
		{
			throw null;
		}
	}
}
