namespace Microsoft.AspNetCore.Cryptography.KeyDerivation.PBKDF2
{
	/// <summary>
	/// A PBKDF2 provider which utilizes the managed hash algorithm classes as PRFs.
	/// This isn't the preferred provider since the implementation is slow, but it is provided as a fallback.
	/// </summary>
	internal sealed class ManagedPbkdf2Provider : IPbkdf2Provider
	{
		public byte[] DeriveKey(string password, byte[] salt, KeyDerivationPrf prf, int iterationCount, int numBytesRequested)
		{
			throw null;
		}

		public ManagedPbkdf2Provider()
		{
			throw null;
		}
	}
}
