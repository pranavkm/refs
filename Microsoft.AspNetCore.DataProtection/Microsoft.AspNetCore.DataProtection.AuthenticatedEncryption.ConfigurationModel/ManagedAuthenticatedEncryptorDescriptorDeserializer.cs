using System.Xml.Linq;

namespace Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel
{
	/// <summary>
	/// A class that can deserialize an <see cref="T:System.Xml.Linq.XElement" /> that represents the serialized version
	/// of an <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.ManagedAuthenticatedEncryptorDescriptor" />.
	/// </summary>
	public sealed class ManagedAuthenticatedEncryptorDescriptorDeserializer : IAuthenticatedEncryptorDescriptorDeserializer
	{
		/// <summary>
		/// Imports the <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.ManagedAuthenticatedEncryptorDescriptor" /> from serialized XML.
		/// </summary>
		public IAuthenticatedEncryptorDescriptor ImportFromXml(XElement element)
		{
			throw null;
		}

		public ManagedAuthenticatedEncryptorDescriptorDeserializer()
		{
			throw null;
		}
	}
}
