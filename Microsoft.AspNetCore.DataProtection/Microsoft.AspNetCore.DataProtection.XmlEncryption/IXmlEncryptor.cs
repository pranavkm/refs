using System.Xml.Linq;

namespace Microsoft.AspNetCore.DataProtection.XmlEncryption
{
	/// <summary>
	/// The basic interface for encrypting XML elements.
	/// </summary>
	public interface IXmlEncryptor
	{
		/// <summary>
		/// Encrypts the specified <see cref="T:System.Xml.Linq.XElement" />.
		/// </summary>
		/// <param name="plaintextElement">The plaintext to encrypt.</param>
		/// <returns>
		/// An <see cref="T:Microsoft.AspNetCore.DataProtection.XmlEncryption.EncryptedXmlInfo" /> that contains the encrypted value of
		/// <paramref name="plaintextElement" /> along with information about how to
		/// decrypt it.
		/// </returns>
		/// <remarks>
		/// Implementations of this method must not mutate the <see cref="T:System.Xml.Linq.XElement" />
		/// instance provided by <paramref name="plaintextElement" />.
		/// </remarks>
		EncryptedXmlInfo Encrypt(XElement plaintextElement);
	}
}
