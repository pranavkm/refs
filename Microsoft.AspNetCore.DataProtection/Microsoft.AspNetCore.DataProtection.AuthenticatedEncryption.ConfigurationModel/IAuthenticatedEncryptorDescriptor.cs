namespace Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel
{
	/// <summary>
	/// A self-contained descriptor that wraps all information (including secret key
	/// material) necessary to create an instance of an <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptor" />.
	/// </summary>
	public interface IAuthenticatedEncryptorDescriptor
	{
		/// <summary>
		/// Exports the current descriptor to XML.
		/// </summary>
		/// <returns>
		/// An <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.XmlSerializedDescriptorInfo" /> wrapping the <see cref="T:System.Xml.Linq.XElement" /> which represents the serialized
		/// current descriptor object. The deserializer type must be assignable to <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptorDeserializer" />.
		/// </returns>
		/// <remarks>
		/// If an element contains sensitive information (such as key material), the
		/// element should be marked via the <see cref="M:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.XmlExtensions.MarkAsRequiresEncryption(System.Xml.Linq.XElement)" />
		/// extension method, and the caller should encrypt the element before persisting
		/// the XML to storage.
		/// </remarks>
		XmlSerializedDescriptorInfo ExportToXml();
	}
}
