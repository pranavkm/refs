namespace Microsoft.AspNetCore.DataProtection.Cng
{
	internal sealed class BCryptGenRandomImpl : IBCryptGenRandom
	{
		public static readonly BCryptGenRandomImpl Instance;

		public unsafe void GenRandom(byte* pbBuffer, uint cbBuffer)
		{
			throw null;
		}
	}
}
