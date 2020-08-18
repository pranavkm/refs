namespace Microsoft.AspNetCore.Cryptography.Cng
{
	internal struct BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO
	{
		public uint cbSize;

		public uint dwInfoVersion;

		public unsafe byte* pbNonce;

		public uint cbNonce;

		public unsafe byte* pbAuthData;

		public uint cbAuthData;

		public unsafe byte* pbTag;

		public uint cbTag;

		public unsafe byte* pbMacContext;

		public uint cbMacContext;

		public uint cbAAD;

		public ulong cbData;

		public uint dwFlags;

		public static void Init(out BCRYPT_AUTHENTICATED_CIPHER_MODE_INFO info)
		{
			throw null;
		}
	}
}
