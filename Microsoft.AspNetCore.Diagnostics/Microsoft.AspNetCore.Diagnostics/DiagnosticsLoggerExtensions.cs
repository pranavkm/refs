using Microsoft.Extensions.Logging;
using System;

namespace Microsoft.AspNetCore.Diagnostics
{
	internal static class DiagnosticsLoggerExtensions
	{
		public static void UnhandledException(this ILogger logger, Exception exception)
		{
			throw null;
		}

		public static void ResponseStartedErrorHandler(this ILogger logger)
		{
			throw null;
		}

		public static void ErrorHandlerException(this ILogger logger, Exception exception)
		{
			throw null;
		}

		public static void ResponseStartedErrorPageMiddleware(this ILogger logger)
		{
			throw null;
		}

		public static void DisplayErrorPageException(this ILogger logger, Exception exception)
		{
			throw null;
		}
	}
}
