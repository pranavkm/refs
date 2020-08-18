using Microsoft.AspNetCore.Cryptography.SafeHandles;
using Microsoft.AspNetCore.DataProtection.Cng.Internal;

namespace Microsoft.AspNetCore.DataProtection.Cng
{
	internal sealed class GcmAuthenticatedEncryptor : CngAuthenticatedEncryptorBase
	{
		public GcmAuthenticatedEncryptor(Secret keyDerivationKey, BCryptAlgorithmHandle symmetricAlgorithmHandle, uint symmetricAlgorithmKeySizeInBytes, IBCryptGenRandom genRandom = null)
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
