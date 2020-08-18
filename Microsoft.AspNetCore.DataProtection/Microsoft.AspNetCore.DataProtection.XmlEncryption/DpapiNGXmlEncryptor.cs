using Microsoft.Extensions.Logging;
using System.Xml.Linq;

namespace Microsoft.AspNetCore.DataProtection.XmlEncryption
{
	/// <summary>
	/// A class that can encrypt XML elements using Windows DPAPI:NG.
	/// </summary>
	/// <remarks>
	/// This API is only supported on Windows 8 / Windows Server 2012 and higher.
	/// </remarks>
	public sealed class DpapiNGXmlEncryptor : IXmlEncryptor
	{
		/// <summary>
		/// Creates a new instance of a <see cref="T:Microsoft.AspNetCore.DataProtection.XmlEncryption.DpapiNGXmlEncryptor" />.
		/// </summary>
		/// <param name="protectionDescriptorRule">The rule string from which to create the protection descriptor.</param>
		/// <param name="flags">Flags controlling the creation of the protection descriptor.</param>
		/// <param name="loggerFactory">The <see cref="T:Microsoft.Extensions.Logging.ILoggerFactory" />.</param>
		public DpapiNGXmlEncryptor(string protectionDescriptorRule, DpapiNGProtectionDescriptorFlags flags, ILoggerFactory loggerFactory)
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

		/// <summary>
		/// Creates a rule string tied to the current Windows user and which is transferrable
		/// across machines (backed up in AD).
		/// </summary>
		internal static string GetDefaultProtectionDescriptorString()
		{
			throw null;
		}
	}
}
