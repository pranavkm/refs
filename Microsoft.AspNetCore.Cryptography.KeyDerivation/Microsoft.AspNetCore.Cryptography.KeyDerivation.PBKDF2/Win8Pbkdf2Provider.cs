using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Cryptography.KeyDerivation.PBKDF2
{
	/// <summary>
	/// A PBKDF2 provider which utilizes the Win8 API BCryptKeyDerivation.
	/// </summary>
	internal sealed class Win8Pbkdf2Provider : IPbkdf2Provider
	{
		public byte[] DeriveKey(string password, byte[] salt, KeyDerivationPrf prf, int iterationCount, int numBytesRequested)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint GetTotalByteLengthIncludingNullTerminator(string input)
		{
			throw null;
		}

		public Win8Pbkdf2Provider()
		{
			throw null;
		}
	}
}
