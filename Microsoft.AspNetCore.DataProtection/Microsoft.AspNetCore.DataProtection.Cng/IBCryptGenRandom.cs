namespace Microsoft.AspNetCore.DataProtection.Cng
{
	internal interface IBCryptGenRandom
	{
		unsafe void GenRandom(byte* pbBuffer, uint cbBuffer);
	}
}
