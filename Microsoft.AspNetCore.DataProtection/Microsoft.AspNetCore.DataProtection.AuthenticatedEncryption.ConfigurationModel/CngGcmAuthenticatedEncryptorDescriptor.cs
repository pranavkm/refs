using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel
{
	/// <summary>
	/// A descriptor which can create an authenticated encryption system based upon the
	/// configuration provided by an <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.CngGcmAuthenticatedEncryptorConfiguration" /> object.
	/// </summary>
	public sealed class CngGcmAuthenticatedEncryptorDescriptor : IAuthenticatedEncryptorDescriptor
	{
		internal ISecret MasterKey
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		internal CngGcmAuthenticatedEncryptorConfiguration Configuration
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public CngGcmAuthenticatedEncryptorDescriptor(CngGcmAuthenticatedEncryptorConfiguration configuration, ISecret masterKey)
		{
			throw null;
		}

		public XmlSerializedDescriptorInfo ExportToXml()
		{
			throw null;
		}
	}
}
