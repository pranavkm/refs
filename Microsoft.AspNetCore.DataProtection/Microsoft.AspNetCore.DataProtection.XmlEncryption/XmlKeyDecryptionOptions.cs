using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Microsoft.AspNetCore.DataProtection.XmlEncryption
{
	/// <summary>
	/// Specifies settings for how to decrypt XML keys.
	/// </summary>
	internal class XmlKeyDecryptionOptions
	{
		public int KeyDecryptionCertificateCount
		{
			get
			{
				throw null;
			}
		}

		public bool TryGetKeyDecryptionCertificates(X509Certificate2 certInfo, out IReadOnlyList<X509Certificate2> keyDecryptionCerts)
		{
			throw null;
		}

		public void AddKeyDecryptionCertificate(X509Certificate2 certificate)
		{
			throw null;
		}

		public XmlKeyDecryptionOptions()
		{
			throw null;
		}
	}
}
