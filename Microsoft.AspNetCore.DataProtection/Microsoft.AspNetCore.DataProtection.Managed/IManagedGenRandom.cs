namespace Microsoft.AspNetCore.DataProtection.Managed
{
	internal interface IManagedGenRandom
	{
		byte[] GenRandom(int numBytes);
	}
}
