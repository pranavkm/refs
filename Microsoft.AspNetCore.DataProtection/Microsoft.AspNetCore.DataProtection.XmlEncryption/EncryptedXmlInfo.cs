using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Microsoft.AspNetCore.DataProtection.XmlEncryption
{
	/// <summary>
	/// Wraps an <see cref="T:System.Xml.Linq.XElement" /> that contains a blob of encrypted XML
	/// and information about the class which can be used to decrypt it.
	/// </summary>
	public sealed class EncryptedXmlInfo
	{
		/// <summary>
		/// The class whose <see cref="M:Microsoft.AspNetCore.DataProtection.XmlEncryption.IXmlDecryptor.Decrypt(System.Xml.Linq.XElement)" /> method can be used to
		/// decrypt the value stored in <see cref="P:Microsoft.AspNetCore.DataProtection.XmlEncryption.EncryptedXmlInfo.EncryptedElement" />.
		/// </summary>
		public Type DecryptorType
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// A piece of encrypted XML.
		/// </summary>
		public XElement EncryptedElement
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates an instance of an <see cref="T:Microsoft.AspNetCore.DataProtection.XmlEncryption.EncryptedXmlInfo" />.
		/// </summary>
		/// <param name="encryptedElement">A piece of encrypted XML.</param>
		/// <param name="decryptorType">The class whose <see cref="M:Microsoft.AspNetCore.DataProtection.XmlEncryption.IXmlDecryptor.Decrypt(System.Xml.Linq.XElement)" />
		/// method can be used to decrypt <paramref name="encryptedElement" />.</param>
		public EncryptedXmlInfo(XElement encryptedElement, Type decryptorType)
		{
			throw null;
		}
	}
}
