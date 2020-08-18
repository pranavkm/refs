using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using Microsoft.AspNetCore.DataProtection.Cng;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.Extensions.Logging;

namespace Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption
{
	/// <summary>
	/// An <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptorFactory" /> for <see cref="T:Microsoft.AspNetCore.DataProtection.Cng.GcmAuthenticatedEncryptor" />.
	/// </summary>
	public sealed class CngGcmAuthenticatedEncryptorFactory : IAuthenticatedEncryptorFactory
	{
		public CngGcmAuthenticatedEncryptorFactory(ILoggerFactory loggerFactory)
		{
			throw null;
		}

		public IAuthenticatedEncryptor CreateEncryptorInstance(IKey key)
		{
			throw null;
		}

		internal GcmAuthenticatedEncryptor CreateAuthenticatedEncryptorInstance(ISecret secret, CngGcmAuthenticatedEncryptorConfiguration configuration)
		{
			throw null;
		}
	}
}
