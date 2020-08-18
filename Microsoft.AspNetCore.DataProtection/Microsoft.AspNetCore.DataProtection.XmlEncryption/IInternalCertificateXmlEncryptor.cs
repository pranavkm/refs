using System.Security.Cryptography.Xml;
using System.Xml;

namespace Microsoft.AspNetCore.DataProtection.XmlEncryption
{
	/// <summary>
	/// Internal implementation details of <see cref="T:Microsoft.AspNetCore.DataProtection.XmlEncryption.CertificateXmlEncryptor" /> for unit testing.
	/// </summary>
	internal interface IInternalCertificateXmlEncryptor
	{
		EncryptedData PerformEncryption(EncryptedXml encryptedXml, XmlElement elementToEncrypt);
	}
}
