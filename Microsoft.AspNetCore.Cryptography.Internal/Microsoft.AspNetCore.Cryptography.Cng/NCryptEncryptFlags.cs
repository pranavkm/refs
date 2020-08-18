using System;

namespace Microsoft.AspNetCore.Cryptography.Cng
{
	[Flags]
	internal enum NCryptEncryptFlags
	{
		NCRYPT_NO_PADDING_FLAG = 0x1,
		NCRYPT_PAD_PKCS1_FLAG = 0x2,
		NCRYPT_PAD_OAEP_FLAG = 0x4,
		NCRYPT_PAD_PSS_FLAG = 0x8,
		NCRYPT_SILENT_FLAG = 0x40
	}
}
