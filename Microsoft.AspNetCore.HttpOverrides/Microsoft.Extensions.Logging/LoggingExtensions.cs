using System;

namespace Microsoft.Extensions.Logging
{
	internal static class LoggingExtensions
	{
		public static void NoCertificate(this ILogger logger, Exception exception)
		{
			throw null;
		}
	}
}
