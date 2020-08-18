using Microsoft.Extensions.Logging;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Xml;
using System.Xml.Linq;

namespace Microsoft.AspNetCore.DataProtection.XmlEncryption
{
	/// <summary>
	/// An <see cref="T:Microsoft.AspNetCore.DataProtection.XmlEncryption.IXmlEncryptor" /> that can perform XML encryption by using an X.509 certificate.
	/// </summary>
	public sealed class CertificateXmlEncryptor : IInternalCertificateXmlEncryptor, IXmlEncryptor
	{
		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.DataProtection.XmlEncryption.CertificateXmlEncryptor" /> given a certificate's thumbprint, an
		/// <see cref="T:Microsoft.AspNetCore.DataProtection.XmlEncryption.ICertificateResolver" /> that can be used to resolve the certificate, and
		/// an <see cref="T:System.IServiceProvider" />.
		/// </summary>
		public CertificateXmlEncryptor(string thumbprint, ICertificateResolver certificateResolver, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.DataProtection.XmlEncryption.CertificateXmlEncryptor" /> given an <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> instance
		/// and an <see cref="T:System.IServiceProvider" />.
		/// </summary>
		public CertificateXmlEncryptor(X509Certificate2 certificate, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		internal CertificateXmlEncryptor(ILoggerFactory loggerFactory, IInternalCertificateXmlEncryptor encryptor)
		{
			throw null;
		}

		/// <summary>
		/// Encrypts the specified <see cref="T:System.Xml.Linq.XElement" /> with an X.509 certificate.
		/// </summary>
		/// <param name="plaintextElement">The plaintext to encrypt.</param>
		/// <returns>
		/// An <see cref="T:Microsoft.AspNetCore.DataProtection.XmlEncryption.EncryptedXmlInfo" /> that contains the encrypted value of
		/// <paramref name="plaintextElement" /> along with information about how to
		/// decrypt it.
		/// </returns>
		public EncryptedXmlInfo Encrypt(XElement plaintextElement)
		{
			throw null;
		}

		EncryptedData IInternalCertificateXmlEncryptor.PerformEncryption(EncryptedXml encryptedXml, XmlElement elementToEncrypt)
		{
			throw null;
		}
	}
}
