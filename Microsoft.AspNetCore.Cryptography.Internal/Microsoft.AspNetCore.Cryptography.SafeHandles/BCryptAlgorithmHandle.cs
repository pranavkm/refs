using Microsoft.AspNetCore.Cryptography.Cng;

namespace Microsoft.AspNetCore.Cryptography.SafeHandles
{
	/// <summary>
	/// Represents a handle to a BCrypt algorithm provider from which keys and hashes can be created.
	/// </summary>
	internal sealed class BCryptAlgorithmHandle : BCryptHandle
	{
		/// <summary>
		/// Creates an unkeyed hash handle from this hash algorithm.
		/// </summary>
		public BCryptHashHandle CreateHash()
		{
			throw null;
		}

		/// <summary>
		/// Creates an HMAC hash handle from this hash algorithm.
		/// </summary>
		public unsafe BCryptHashHandle CreateHmac(byte* pbKey, uint cbKey)
		{
			throw null;
		}

		/// <summary>
		/// Imports a key into a symmetric encryption or KDF algorithm.
		/// </summary>
		public unsafe BCryptKeyHandle GenerateSymmetricKey(byte* pbSecret, uint cbSecret)
		{
			throw null;
		}

		/// <summary>
		/// Gets the name of this BCrypt algorithm.
		/// </summary>
		public string GetAlgorithmName()
		{
			throw null;
		}

		/// <summary>
		/// Gets the cipher block length (in bytes) of this block cipher algorithm.
		/// </summary>
		public uint GetCipherBlockLength()
		{
			throw null;
		}

		/// <summary>
		/// Gets the hash block length (in bytes) of this hash algorithm.
		/// </summary>
		public uint GetHashBlockLength()
		{
			throw null;
		}

		/// <summary>
		/// Gets the key lengths (in bits) supported by this algorithm.
		/// </summary>
		public BCRYPT_KEY_LENGTHS_STRUCT GetSupportedKeyLengths()
		{
			throw null;
		}

		/// <summary>
		/// Gets the digest length (in bytes) of this hash algorithm provider.
		/// </summary>
		public uint GetHashDigestLength()
		{
			throw null;
		}

		public static BCryptAlgorithmHandle OpenAlgorithmHandle(string algorithmId, string implementation = null, bool hmac = false)
		{
			throw null;
		}

		protected override bool ReleaseHandle()
		{
			throw null;
		}

		public void SetChainingMode(string chainingMode)
		{
			throw null;
		}
	}
}
