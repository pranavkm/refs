using System.Xml.Linq;

namespace Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel
{
	/// <summary>
	/// A class that can deserialize an <see cref="T:System.Xml.Linq.XElement" /> that represents the serialized version
	/// of an <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.CngCbcAuthenticatedEncryptorDescriptor" />.
	/// </summary>
	public sealed class CngCbcAuthenticatedEncryptorDescriptorDeserializer : IAuthenticatedEncryptorDescriptorDeserializer
	{
		/// <summary>
		/// Imports the <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.CngCbcAuthenticatedEncryptorDescriptor" /> from serialized XML.
		/// </summary>
		public IAuthenticatedEncryptorDescriptor ImportFromXml(XElement element)
		{
			throw null;
		}

		public CngCbcAuthenticatedEncryptorDescriptorDeserializer()
		{
			throw null;
		}
	}
}
