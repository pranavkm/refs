using Microsoft.Extensions.Logging;
using System;

namespace Microsoft.Extensions.StackTrace.Sources
{
	internal static class LoggerExtensions
	{
		public static void FailedToReadStackTraceInfo(this ILogger logger, Exception exception)
		{
			throw null;
		}
	}
}
