using Microsoft.AspNetCore.DataProtection.Internal;
using System.Xml.Linq;

namespace Microsoft.AspNetCore.DataProtection.XmlEncryption
{
	internal static class XmlEncryptionExtensions
	{
		public static XElement DecryptElement(this XElement element, IActivator activator)
		{
			throw null;
		}

		public static XElement EncryptIfNecessary(this IXmlEncryptor encryptor, XElement element)
		{
			throw null;
		}

		/// <summary>
		/// Converts an <see cref="T:System.Xml.Linq.XElement" /> to a <see cref="T:Microsoft.AspNetCore.DataProtection.Secret" /> so that it can be kept in memory
		/// securely or run through the DPAPI routines.
		/// </summary>
		public static Secret ToSecret(this XElement element)
		{
			throw null;
		}

		/// <summary>
		/// Converts a <see cref="T:Microsoft.AspNetCore.DataProtection.Secret" /> back into an <see cref="T:System.Xml.Linq.XElement" />.
		/// </summary>
		public static XElement ToXElement(this Secret secret)
		{
			throw null;
		}
	}
}
