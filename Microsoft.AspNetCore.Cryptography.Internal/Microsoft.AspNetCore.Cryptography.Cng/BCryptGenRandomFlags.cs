using System;

namespace Microsoft.AspNetCore.Cryptography.Cng
{
	[Flags]
	internal enum BCryptGenRandomFlags
	{
		BCRYPT_RNG_USE_ENTROPY_IN_BUFFER = 0x1,
		BCRYPT_USE_SYSTEM_PREFERRED_RNG = 0x2
	}
}
