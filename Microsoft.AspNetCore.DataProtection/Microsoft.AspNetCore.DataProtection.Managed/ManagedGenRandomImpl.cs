namespace Microsoft.AspNetCore.DataProtection.Managed
{
	internal sealed class ManagedGenRandomImpl : IManagedGenRandom
	{
		public static readonly ManagedGenRandomImpl Instance;

		public byte[] GenRandom(int numBytes)
		{
			throw null;
		}
	}
}
