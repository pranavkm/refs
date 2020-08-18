using Microsoft.Extensions.Logging;
using System.Security.Cryptography.X509Certificates;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal
{
	internal static class LoggerExtensions
	{
		public static void LocatedDevelopmentCertificate(this ILogger<KestrelServer> logger, X509Certificate2 certificate)
		{
			throw null;
		}

		public static void UnableToLocateDevelopmentCertificate(this ILogger<KestrelServer> logger)
		{
			throw null;
		}

		public static void FailedToLocateDevelopmentCertificateFile(this ILogger<KestrelServer> logger, string certificatePath)
		{
			throw null;
		}

		public static void FailedToLoadDevelopmentCertificate(this ILogger<KestrelServer> logger, string certificatePath)
		{
			throw null;
		}

		public static void BadDeveloperCertificateState(this ILogger<KestrelServer> logger)
		{
			throw null;
		}

		public static void DeveloperCertificateFirstRun(this ILogger<KestrelServer> logger, string message)
		{
			throw null;
		}

		public static void FailedToLoadCertificate(this ILogger<KestrelServer> logger, string certificatePath)
		{
			throw null;
		}

		public static void FailedToLoadCertificateKey(this ILogger<KestrelServer> logger, string certificateKeyPath)
		{
			throw null;
		}
	}
}
