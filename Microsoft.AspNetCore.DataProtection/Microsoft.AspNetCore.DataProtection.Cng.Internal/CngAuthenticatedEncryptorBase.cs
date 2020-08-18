using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption;
using System;

namespace Microsoft.AspNetCore.DataProtection.Cng.Internal
{
	/// <summary>
	/// Base class used for all CNG-related authentication encryption operations.
	/// </summary>
	internal abstract class CngAuthenticatedEncryptorBase : IOptimizedAuthenticatedEncryptor, IAuthenticatedEncryptor, IDisposable
	{
		public byte[] Decrypt(ArraySegment<byte> ciphertext, ArraySegment<byte> additionalAuthenticatedData)
		{
			throw null;
		}

		protected unsafe abstract byte[] DecryptImpl(byte* pbCiphertext, uint cbCiphertext, byte* pbAdditionalAuthenticatedData, uint cbAdditionalAuthenticatedData);

		public abstract void Dispose();

		public byte[] Encrypt(ArraySegment<byte> plaintext, ArraySegment<byte> additionalAuthenticatedData)
		{
			throw null;
		}

		public byte[] Encrypt(ArraySegment<byte> plaintext, ArraySegment<byte> additionalAuthenticatedData, uint preBufferSize, uint postBufferSize)
		{
			throw null;
		}

		protected unsafe abstract byte[] EncryptImpl(byte* pbPlaintext, uint cbPlaintext, byte* pbAdditionalAuthenticatedData, uint cbAdditionalAuthenticatedData, uint cbPreBuffer, uint cbPostBuffer);

		protected CngAuthenticatedEncryptorBase()
		{
			throw null;
		}
	}
}
