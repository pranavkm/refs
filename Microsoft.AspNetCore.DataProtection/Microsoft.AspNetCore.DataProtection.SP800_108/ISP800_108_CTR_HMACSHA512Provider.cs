using System;

namespace Microsoft.AspNetCore.DataProtection.SP800_108
{
	internal interface ISP800_108_CTR_HMACSHA512Provider : IDisposable
	{
		unsafe void DeriveKey(byte* pbLabel, uint cbLabel, byte* pbContext, uint cbContext, byte* pbDerivedKey, uint cbDerivedKey);
	}
}
