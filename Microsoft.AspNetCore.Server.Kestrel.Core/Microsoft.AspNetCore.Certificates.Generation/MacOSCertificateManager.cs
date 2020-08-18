using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Microsoft.AspNetCore.Certificates.Generation
{
	internal class MacOSCertificateManager : CertificateManager
	{
		public const string InvalidCertificateState = "The ASP.NET Core developer certificate is in an invalid state. To fix this issue, run the following commands 'dotnet dev-certs https --clean' and 'dotnet dev-certs https' to remove all existing ASP.NET Core development certificates and create a new untrusted developer certificate. On macOS or Windows, use 'dotnet dev-certs https --trust' to trust the new certificate.";

		public const string KeyNotAccessibleWithoutUserInteraction = "The application is trying to access the ASP.NET Core developer certificate key. A prompt might appear to ask for permission to access the key. When that happens, select 'Always Allow' to grant 'dotnet' access to the certificate key in the future.";

		public MacOSCertificateManager()
		{
			throw null;
		}

		internal MacOSCertificateManager(string subject, int version)
		{
			throw null;
		}

		protected override void TrustCertificateCore(X509Certificate2 publicCertificate)
		{
			throw null;
		}

		internal override CheckCertificateStateResult CheckCertificateState(X509Certificate2 candidate, bool interactive)
		{
			throw null;
		}

		internal override void CorrectCertificateState(X509Certificate2 candidate)
		{
			throw null;
		}

		public override bool IsTrusted(X509Certificate2 certificate)
		{
			throw null;
		}

		protected override void RemoveCertificateFromTrustedRoots(X509Certificate2 certificate)
		{
			throw null;
		}

		protected override bool IsExportable(X509Certificate2 c)
		{
			throw null;
		}

		protected override X509Certificate2 SaveCertificateCore(X509Certificate2 certificate)
		{
			throw null;
		}

		protected override IList<X509Certificate2> GetCertificatesToRemove(StoreName storeName, StoreLocation storeLocation)
		{
			throw null;
		}
	}
}
