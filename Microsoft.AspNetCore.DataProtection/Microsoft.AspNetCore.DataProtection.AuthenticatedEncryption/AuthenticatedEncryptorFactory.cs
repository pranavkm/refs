using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.Extensions.Logging;

namespace Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption
{
	/// <summary>
	/// An <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptorFactory" /> to create an <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptor" />
	/// based on the <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel.AuthenticatedEncryptorConfiguration" />.
	/// </summary>
	public sealed class AuthenticatedEncryptorFactory : IAuthenticatedEncryptorFactory
	{
		public AuthenticatedEncryptorFactory(ILoggerFactory loggerFactory)
		{
			throw null;
		}

		public IAuthenticatedEncryptor CreateEncryptorInstance(IKey key)
		{
			throw null;
		}

		internal IAuthenticatedEncryptor CreateAuthenticatedEncryptorInstance(ISecret secret, AuthenticatedEncryptorConfiguration authenticatedConfiguration)
		{
			throw null;
		}

		internal static bool IsGcmAlgorithm(EncryptionAlgorithm algorithm)
		{
			throw null;
		}
	}
}
