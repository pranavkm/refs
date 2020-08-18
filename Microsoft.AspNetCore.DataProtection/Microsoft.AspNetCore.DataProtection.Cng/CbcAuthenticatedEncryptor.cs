using Microsoft.AspNetCore.Cryptography.SafeHandles;
using Microsoft.AspNetCore.DataProtection.Cng.Internal;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.DataProtection.Cng
{
	internal sealed class CbcAuthenticatedEncryptor : CngAuthenticatedEncryptorBase
	{
		[System.Runtime.CompilerServices.NullableContext(1)]
		public CbcAuthenticatedEncryptor(Secret keyDerivationKey, BCryptAlgorithmHandle symmetricAlgorithmHandle, uint symmetricAlgorithmKeySizeInBytes, BCryptAlgorithmHandle hmacAlgorithmHandle, IBCryptGenRandom genRandom = null)
		{
			throw null;
		}

		protected unsafe override byte[] DecryptImpl(byte* pbCiphertext, uint cbCiphertext, byte* pbAdditionalAuthenticatedData, uint cbAdditionalAuthenticatedData)
		{
			throw null;
		}

		public override void Dispose()
		{
			throw null;
		}

		protected unsafe override byte[] EncryptImpl(byte* pbPlaintext, uint cbPlaintext, byte* pbAdditionalAuthenticatedData, uint cbAdditionalAuthenticatedData, uint cbPreBuffer, uint cbPostBuffer)
		{
			throw null;
		}
	}
}
