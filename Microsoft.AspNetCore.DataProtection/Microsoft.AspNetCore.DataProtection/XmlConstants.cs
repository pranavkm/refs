using System.Xml.Linq;

namespace Microsoft.AspNetCore.DataProtection
{
	/// <summary>
	/// Contains XLinq constants.
	/// </summary>
	internal static class XmlConstants
	{
		/// <summary>
		/// Represents the type of decryptor that can be used when reading 'encryptedSecret' elements.
		/// </summary>
		internal static readonly XName DecryptorTypeAttributeName;

		/// <summary>
		/// Elements with this attribute will be read with the specified deserializer type.
		/// </summary>
		internal static readonly XName DeserializerTypeAttributeName;

		/// <summary>
		/// Elements with this name will be automatically decrypted when read by the XML key manager.
		/// </summary>
		internal static readonly XName EncryptedSecretElementName;

		/// <summary>
		/// Elements where this attribute has a value of 'true' should be encrypted before storage.
		/// </summary>
		internal static readonly XName RequiresEncryptionAttributeName;
	}
}
