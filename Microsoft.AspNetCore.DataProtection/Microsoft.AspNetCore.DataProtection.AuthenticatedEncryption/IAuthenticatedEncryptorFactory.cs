using Microsoft.AspNetCore.DataProtection.KeyManagement;

namespace Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption
{
	public interface IAuthenticatedEncryptorFactory
	{
		/// <summary>
		/// Creates an <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptor" /> instance based on the given <see cref="P:Microsoft.AspNetCore.DataProtection.KeyManagement.IKey.Descriptor" />.
		/// </summary>
		/// <returns>An <see cref="T:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptor" /> instance.</returns>
		/// <remarks>
		/// For a given <see cref="P:Microsoft.AspNetCore.DataProtection.KeyManagement.IKey.Descriptor" />, any two instances returned by this method should
		/// be considered equivalent, e.g., the payload returned by one's <see cref="M:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptor.Encrypt(System.ArraySegment{System.Byte},System.ArraySegment{System.Byte})" />
		/// method should be consumable by the other's <see cref="M:Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.IAuthenticatedEncryptor.Decrypt(System.ArraySegment{System.Byte},System.ArraySegment{System.Byte})" /> method.
		/// </remarks>
		IAuthenticatedEncryptor CreateEncryptorInstance(IKey key);
	}
}
