using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Certificates
{
	internal class CertificateConfigLoader : ICertificateConfigLoader
	{
		public IHostEnvironment HostEnvironment
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public ILogger<KestrelServer> Logger
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public bool IsTestMock
		{
			get
			{
				throw null;
			}
		}

		public CertificateConfigLoader(IHostEnvironment hostEnvironment, ILogger<KestrelServer> logger)
		{
			throw null;
		}

		public X509Certificate2 LoadCertificate(CertificateConfig certInfo, string endpointName)
		{
			throw null;
		}
	}
}
