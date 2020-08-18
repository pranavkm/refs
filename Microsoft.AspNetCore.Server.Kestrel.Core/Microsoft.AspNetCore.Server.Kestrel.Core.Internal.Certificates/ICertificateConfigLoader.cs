using System.Security.Cryptography.X509Certificates;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Certificates
{
	internal interface ICertificateConfigLoader
	{
		bool IsTestMock
		{
			get;
		}

		X509Certificate2 LoadCertificate(CertificateConfig certInfo, string endpointName);
	}
}
