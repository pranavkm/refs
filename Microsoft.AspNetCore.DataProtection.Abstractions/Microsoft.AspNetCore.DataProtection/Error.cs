using System;
using System.Security.Cryptography;

namespace Microsoft.AspNetCore.DataProtection
{
	internal static class Error
	{
		public static CryptographicException CryptCommon_GenericError(Exception? inner = null)
		{
			throw null;
		}

		public static CryptographicException CryptCommon_PayloadInvalid()
		{
			throw null;
		}
	}
}
