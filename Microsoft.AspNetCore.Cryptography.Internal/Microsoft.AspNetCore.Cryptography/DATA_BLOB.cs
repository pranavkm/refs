namespace Microsoft.AspNetCore.Cryptography
{
	internal struct DATA_BLOB
	{
		public uint cbData;

		public unsafe byte* pbData;
	}
}
