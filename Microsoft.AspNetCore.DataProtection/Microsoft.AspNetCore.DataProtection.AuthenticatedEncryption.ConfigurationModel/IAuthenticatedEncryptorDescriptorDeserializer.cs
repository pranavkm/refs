using System.Xml.Linq;

namespace Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel
{
	/// <summary>
	/// The basic interface for deserializing an XML element into an <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor" />.
	/// </summary>
	public interface IAuthenticatedEncryptorDescriptorDeserializer
	{
		/// <summary>
		/// Deserializes the specified XML element.
		/// </summary>
		/// <param name="element">The element to deserialize.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.IAuthenticatedEncryptorDescriptor" /> represented by <paramref name="element" />.</returns>
		IAuthenticatedEncryptorDescriptor ImportFromXml(XElement element);
	}
}
