using System;

namespace Microsoft.AspNetCore.DataProtection.SP800_108
{
	internal sealed class Win8SP800_108_CTR_HMACSHA512Provider : ISP800_108_CTR_HMACSHA512Provider, IDisposable
	{
		public unsafe Win8SP800_108_CTR_HMACSHA512Provider(byte* pbKdk, uint cbKdk)
		{
			throw null;
		}

		public unsafe void DeriveKey(byte* pbLabel, uint cbLabel, byte* pbContext, uint cbContext, byte* pbDerivedKey, uint cbDerivedKey)
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}
	}
}
