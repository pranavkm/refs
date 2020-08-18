using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Microsoft.AspNetCore.Certificates.Generation
{
	internal class WindowsCertificateManager : CertificateManager
	{
		public WindowsCertificateManager()
		{
			throw null;
		}

		internal WindowsCertificateManager(string subject, int version)
		{
			throw null;
		}

		protected override bool IsExportable(X509Certificate2 c)
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

		protected override X509Certificate2 SaveCertificateCore(X509Certificate2 certificate)
		{
			throw null;
		}

		protected override void TrustCertificateCore(X509Certificate2 certificate)
		{
			throw null;
		}

		protected override void RemoveCertificateFromTrustedRoots(X509Certificate2 certificate)
		{
			throw null;
		}

		public override bool IsTrusted(X509Certificate2 certificate)
		{
			throw null;
		}

		protected override IList<X509Certificate2> GetCertificatesToRemove(StoreName storeName, StoreLocation storeLocation)
		{
			throw null;
		}
	}
}
