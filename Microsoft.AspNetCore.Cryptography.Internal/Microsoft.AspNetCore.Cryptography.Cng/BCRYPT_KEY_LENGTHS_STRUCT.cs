namespace Microsoft.AspNetCore.Cryptography.Cng
{
	internal struct BCRYPT_KEY_LENGTHS_STRUCT
	{
		internal uint dwMinLength;

		internal uint dwMaxLength;

		internal uint dwIncrement;

		public void EnsureValidKeyLength(uint keyLengthInBits)
		{
			throw null;
		}
	}
}
