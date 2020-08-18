using System;
using System.Security.Cryptography;

namespace Microsoft.AspNetCore.DataProtection.SP800_108
{
	internal static class ManagedSP800_108_CTR_HMACSHA512
	{
		public static void DeriveKeys(byte[] kdk, ArraySegment<byte> label, ArraySegment<byte> context, Func<byte[], HashAlgorithm> prfFactory, ArraySegment<byte> output)
		{
			throw null;
		}

		public static void DeriveKeysWithContextHeader(byte[] kdk, ArraySegment<byte> label, byte[] contextHeader, ArraySegment<byte> context, Func<byte[], HashAlgorithm> prfFactory, ArraySegment<byte> output)
		{
			throw null;
		}
	}
}
