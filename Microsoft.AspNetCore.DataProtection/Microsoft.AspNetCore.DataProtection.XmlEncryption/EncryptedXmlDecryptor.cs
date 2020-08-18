using System;
using System.Security.Cryptography.Xml;
using System.Xml;
using System.Xml.Linq;

namespace Microsoft.AspNetCore.DataProtection.XmlEncryption
{
	/// <summary>
	/// An <see cref="T:Microsoft.AspNetCore.DataProtection.XmlEncryption.IXmlDecryptor" /> that decrypts XML elements by using the <see cref="T:System.Security.Cryptography.Xml.EncryptedXml" /> class.
	/// </summary>
	public sealed class EncryptedXmlDecryptor : IInternalEncryptedXmlDecryptor, IXmlDecryptor
	{
		/// <summary>
		/// Can decrypt the XML key data from an <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" /> that is not in stored in <see cref="T:System.Security.Cryptography.X509Certificates.X509Store" />.
		/// </summary>
		private class EncryptedXmlWithCertificateKeys : EncryptedXml
		{
			public EncryptedXmlWithCertificateKeys(XmlKeyDecryptionOptions options, XmlDocument document)
			{
				throw null;
			}

			public override byte[] DecryptEncryptedKey(EncryptedKey encryptedKey)
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new instance of an <see cref="T:Microsoft.AspNetCore.DataProtection.XmlEncryption.EncryptedXmlDecryptor" />.
		/// </summary>
		public EncryptedXmlDecryptor()
		{
			throw null;
		}

		/// <summary>
		/// Creates a new instance of an <see cref="T:Microsoft.AspNetCore.DataProtection.XmlEncryption.EncryptedXmlDecryptor" />.
		/// </summary>
		/// <param name="services">An optional <see cref="T:System.IServiceProvider" /> to provide ancillary services.</param>
		public EncryptedXmlDecryptor(IServiceProvider services)
		{
			throw null;
		}

		/// <summary>
		/// Decrypts the specified XML element.
		/// </summary>
		/// <param name="encryptedElement">An encrypted XML element.</param>
		/// <returns>The decrypted form of <paramref name="encryptedElement" />.</returns>
		public XElement Decrypt(XElement encryptedElement)
		{
			throw null;
		}

		void IInternalEncryptedXmlDecryptor.PerformPreDecryptionSetup(EncryptedXml encryptedXml)
		{
			throw null;
		}
	}
}
