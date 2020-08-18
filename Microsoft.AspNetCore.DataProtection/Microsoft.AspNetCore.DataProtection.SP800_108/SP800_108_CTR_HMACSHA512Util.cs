namespace Microsoft.AspNetCore.DataProtection.SP800_108
{
	/// <summary>
	/// Provides an implementation of the SP800-108-CTR-HMACSHA512 key derivation function.
	/// This class assumes at least Windows 7 / Server 2008 R2.
	/// </summary>
	/// <remarks>
	/// More info at http://csrc.nist.gov/publications/nistpubs/800-108/sp800-108.pdf, Sec. 5.1.
	/// </remarks>
	internal static class SP800_108_CTR_HMACSHA512Util
	{
		public static ISP800_108_CTR_HMACSHA512Provider CreateEmptyProvider()
		{
			throw null;
		}

		public unsafe static ISP800_108_CTR_HMACSHA512Provider CreateProvider(byte* pbKdk, uint cbKdk)
		{
			throw null;
		}

		public static ISP800_108_CTR_HMACSHA512Provider CreateProvider(Secret kdk)
		{
			throw null;
		}
	}
}
