namespace Microsoft.AspNetCore.Cryptography.KeyDerivation.PBKDF2
{
	/// <summary>
	/// Implements Pbkdf2 using <see cref="T:System.Security.Cryptography.Rfc2898DeriveBytes" />.
	/// </summary>
	internal sealed class NetCorePbkdf2Provider : IPbkdf2Provider
	{
		public byte[] DeriveKey(string password, byte[] salt, KeyDerivationPrf prf, int iterationCount, int numBytesRequested)
		{
			throw null;
		}

		public NetCorePbkdf2Provider()
		{
			throw null;
		}
	}
}
