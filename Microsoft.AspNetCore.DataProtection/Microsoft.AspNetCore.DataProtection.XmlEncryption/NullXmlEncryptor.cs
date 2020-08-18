using System;
using System.Xml.Linq;

namespace Microsoft.AspNetCore.DataProtection.XmlEncryption
{
	/// <summary>
	/// An <see cref="T:Microsoft.AspNetCore.DataProtection.XmlEncryption.IXmlEncryptor" /> that encrypts XML elements with a null encryptor.
	/// </summary>
	public sealed class NullXmlEncryptor : IXmlEncryptor
	{
		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.DataProtection.XmlEncryption.NullXmlEncryptor" />.
		/// </summary>
		public NullXmlEncryptor()
		{
			throw null;
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.DataProtection.XmlEncryption.NullXmlEncryptor" />.
		/// </summary>
		/// <param name="services">An optional <see cref="T:System.IServiceProvider" /> to provide ancillary services.</param>
		public NullXmlEncryptor(IServiceProvider services)
		{
			throw null;
		}

		/// <summary>
		/// Encrypts the specified <see cref="T:System.Xml.Linq.XElement" /> with a null encryptor, i.e.,
		/// by returning the original value of <paramref name="plaintextElement" /> unencrypted.
		/// </summary>
		/// <param name="plaintextElement">The plaintext to echo back.</param>
		/// <returns>
		/// An <see cref="T:Microsoft.AspNetCore.DataProtection.XmlEncryption.EncryptedXmlInfo" /> that contains the null-encrypted value of
		/// <paramref name="plaintextElement" /> along with information about how to
		/// decrypt it.
		/// </returns>
		public EncryptedXmlInfo Encrypt(XElement plaintextElement)
		{
			throw null;
		}
	}
}
