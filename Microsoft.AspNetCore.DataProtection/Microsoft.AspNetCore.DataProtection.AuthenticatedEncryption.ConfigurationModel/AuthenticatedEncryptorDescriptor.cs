using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel
{
	/// <summary>
	/// A descriptor which can create an authenticated encryption system based upon the
	/// configuration provided by an <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.AuthenticatedEncryptorConfiguration" /> object.
	/// </summary>
	public sealed class AuthenticatedEncryptorDescriptor : IAuthenticatedEncryptorDescriptor
	{
		internal ISecret MasterKey
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal AuthenticatedEncryptorConfiguration Configuration
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public AuthenticatedEncryptorDescriptor(AuthenticatedEncryptorConfiguration configuration, ISecret masterKey)
		{
			throw null;
		}

		public XmlSerializedDescriptorInfo ExportToXml()
		{
			throw null;
		}
	}
}
