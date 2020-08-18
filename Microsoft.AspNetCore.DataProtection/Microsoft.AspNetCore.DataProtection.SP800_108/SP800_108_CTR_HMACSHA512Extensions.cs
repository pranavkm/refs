namespace Microsoft.AspNetCore.DataProtection.SP800_108
{
	internal static class SP800_108_CTR_HMACSHA512Extensions
	{
		public unsafe static void DeriveKeyWithContextHeader(this ISP800_108_CTR_HMACSHA512Provider provider, byte* pbLabel, uint cbLabel, byte[] contextHeader, byte* pbContext, uint cbContext, byte* pbDerivedKey, uint cbDerivedKey)
		{
			throw null;
		}
	}
}
