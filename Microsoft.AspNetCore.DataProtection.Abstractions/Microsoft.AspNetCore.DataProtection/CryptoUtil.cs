using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.DataProtection
{
	internal static class CryptoUtil
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static Exception Fail(string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static T Fail<T>(string message) where T : class
		{
			throw null;
		}
	}
}
