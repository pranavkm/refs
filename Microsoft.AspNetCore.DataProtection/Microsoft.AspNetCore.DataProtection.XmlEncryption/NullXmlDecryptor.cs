using System.Xml.Linq;

namespace Microsoft.AspNetCore.DataProtection.XmlEncryption
{
	/// <summary>
	/// An <see cref="T:Microsoft.AspNetCore.DataProtection.XmlEncryption.IXmlDecryptor" /> that decrypts XML elements with a null decryptor.
	/// </summary>
	public sealed class NullXmlDecryptor : IXmlDecryptor
	{
		/// <summary>
		/// Decrypts the specified XML element.
		/// </summary>
		/// <param name="encryptedElement">An encrypted XML element.</param>
		/// <returns>The decrypted form of <paramref name="encryptedElement" />.</returns>
		public XElement Decrypt(XElement encryptedElement)
		{
			throw null;
		}

		public NullXmlDecryptor()
		{
			throw null;
		}
	}
}
