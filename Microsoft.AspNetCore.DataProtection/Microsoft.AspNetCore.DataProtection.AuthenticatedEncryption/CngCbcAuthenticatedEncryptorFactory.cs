using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using Microsoft.AspNetCore.DataProtection.Cng;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.Extensions.Logging;

namespace Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption
{
	/// <summary>
	/// An <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptorFactory" /> for <see cref="T:Microsoft.AspNetCore.DataProtection.Cng.CbcAuthenticatedEncryptor" />.
	/// </summary>
	public sealed class CngCbcAuthenticatedEncryptorFactory : IAuthenticatedEncryptorFactory
	{
		public CngCbcAuthenticatedEncryptorFactory(ILoggerFactory loggerFactory)
		{
			throw null;
		}

		public IAuthenticatedEncryptor CreateEncryptorInstance(IKey key)
		{
			throw null;
		}

		internal CbcAuthenticatedEncryptor CreateAuthenticatedEncryptorInstance(ISecret secret, CngCbcAuthenticatedEncryptorConfiguration configuration)
		{
			throw null;
		}
	}
}
