using System.Security.Cryptography.X509Certificates;

namespace Microsoft.AspNetCore.DataProtection.XmlEncryption
{
	/// <summary>
	/// A default implementation of <see cref="T:Microsoft.AspNetCore.DataProtection.XmlEncryption.ICertificateResolver" /> that looks in the current user
	/// and local machine certificate stores.
	/// </summary>
	public class CertificateResolver : ICertificateResolver
	{
		/// <summary>
		/// Locates an <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> given its thumbprint.
		/// </summary>
		/// <param name="thumbprint">The thumbprint (as a hex string) of the certificate to resolve.</param>
		/// <returns>The resolved <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />, or null if the certificate cannot be found.</returns>
		public virtual X509Certificate2 ResolveCertificate(string thumbprint)
		{
			throw null;
		}

		public CertificateResolver()
		{
			throw null;
		}
	}
}
