namespace Microsoft.AspNetCore.Cryptography.KeyDerivation.PBKDF2
{
	/// <summary>
	/// A PBKDF2 provider which utilizes the Win7 API BCryptDeriveKeyPBKDF2.
	/// </summary>
	internal sealed class Win7Pbkdf2Provider : IPbkdf2Provider
	{
		public byte[] DeriveKey(string password, byte[] salt, KeyDerivationPrf prf, int iterationCount, int numBytesRequested)
		{
			throw null;
		}

		public Win7Pbkdf2Provider()
		{
			throw null;
		}
	}
}
