using System.Security.Cryptography.X509Certificates;

namespace Microsoft.AspNetCore.Server.Kestrel.Https
{
	public static class CertificateLoader
	{
		public static X509Certificate2 LoadFromStoreCert(string subject, string storeName, StoreLocation storeLocation, bool allowInvalid)
		{
			throw null;
		}

		internal static bool IsCertificateAllowedForServerAuth(X509Certificate2 certificate)
		{
			throw null;
		}

		internal static bool DoesCertificateHaveAnAccessiblePrivateKey(X509Certificate2 certificate)
		{
			throw null;
		}
	}
}
