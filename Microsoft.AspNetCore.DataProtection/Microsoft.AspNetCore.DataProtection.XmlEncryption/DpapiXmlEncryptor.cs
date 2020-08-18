using Microsoft.Extensions.Logging;
using System.Xml.Linq;

namespace Microsoft.AspNetCore.DataProtection.XmlEncryption
{
	/// <summary>
	/// An <see cref="T:Microsoft.AspNetCore.DataProtection.XmlEncryption.IXmlEncryptor" /> that encrypts XML by using Windows DPAPI.
	/// </summary>
	/// <remarks>
	/// This API is only supported on Windows platforms.
	/// </remarks>
	public sealed class DpapiXmlEncryptor : IXmlEncryptor
	{
		/// <summary>
		/// Creates a <see cref="T:Microsoft.AspNetCore.DataProtection.XmlEncryption.DpapiXmlEncryptor" /> given a protection scope and an <see cref="T:System.IServiceProvider" />.
		/// </summary>
		/// <param name="protectToLocalMachine">'true' if the data should be decipherable by anybody on the local machine,
		/// 'false' if the data should only be decipherable by the current Windows user account.</param>
		/// <param name="loggerFactory">The <see cref="T:Microsoft.Extensions.Logging.ILoggerFactory" />.</param>
		public DpapiXmlEncryptor(bool protectToLocalMachine, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		/// <summary>
		/// Encrypts the specified <see cref="T:System.Xml.Linq.XElement" />.
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
	}
}
