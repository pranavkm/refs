using System;
using System.Xml.Linq;

namespace Microsoft.AspNetCore.DataProtection.XmlEncryption
{
	/// <summary>
	/// An <see cref="T:Microsoft.AspNetCore.DataProtection.XmlEncryption.IXmlDecryptor" /> that decrypts XML elements that were encrypted with <see cref="T:Microsoft.AspNetCore.DataProtection.XmlEncryption.DpapiXmlEncryptor" />.
	/// </summary>
	public sealed class DpapiXmlDecryptor : IXmlDecryptor
	{
		/// <summary>
		/// Creates a new instance of a <see cref="T:Microsoft.AspNetCore.DataProtection.XmlEncryption.DpapiXmlDecryptor" />.
		/// </summary>
		public DpapiXmlDecryptor()
		{
			throw null;
		}

		/// <summary>
		/// Creates a new instance of a <see cref="T:Microsoft.AspNetCore.DataProtection.XmlEncryption.DpapiXmlDecryptor" />.
		/// </summary>
		/// <param name="services">An optional <see cref="T:System.IServiceProvider" /> to provide ancillary services.</param>
		public DpapiXmlDecryptor(IServiceProvider services)
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
	}
}
