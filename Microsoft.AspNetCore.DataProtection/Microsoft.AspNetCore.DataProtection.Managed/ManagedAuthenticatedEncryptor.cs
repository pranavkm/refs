using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using System;
using System.Security.Cryptography;

namespace Microsoft.AspNetCore.DataProtection.Managed
{
	internal sealed class ManagedAuthenticatedEncryptor : IAuthenticatedEncryptor, IDisposable
	{
		public ManagedAuthenticatedEncryptor(Secret keyDerivationKey, Func<SymmetricAlgorithm> symmetricAlgorithmFactory, int symmetricAlgorithmKeySizeInBytes, Func<KeyedHashAlgorithm> validationAlgorithmFactory, IManagedGenRandom genRandom = null)
		{
			throw null;
		}

		public byte[] Decrypt(ArraySegment<byte> protectedPayload, ArraySegment<byte> additionalAuthenticatedData)
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}

		public byte[] Encrypt(ArraySegment<byte> plaintext, ArraySegment<byte> additionalAuthenticatedData)
		{
			throw null;
		}
	}
}
