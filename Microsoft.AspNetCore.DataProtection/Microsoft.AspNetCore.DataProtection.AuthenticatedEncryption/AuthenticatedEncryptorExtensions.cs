using System;

namespace Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption
{
	internal static class AuthenticatedEncryptorExtensions
	{
		public static byte[] Encrypt(this IAuthenticatedEncryptor encryptor, ArraySegment<byte> plaintext, ArraySegment<byte> additionalAuthenticatedData, uint preBufferSize, uint postBufferSize)
		{
			throw null;
		}

		/// <summary>
		/// Performs a self-test of this encryptor by running a sample payload through an
		/// encrypt-then-decrypt operation. Throws if the operation fails.
		/// </summary>
		public static void PerformSelfTest(this IAuthenticatedEncryptor encryptor)
		{
			throw null;
		}
	}
}
