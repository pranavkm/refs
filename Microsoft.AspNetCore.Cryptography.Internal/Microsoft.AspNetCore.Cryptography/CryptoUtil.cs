using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.AspNetCore.Cryptography
{
	internal static class CryptoUtil
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Assert([DoesNotReturnIf(false)] bool condition, string message)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AssertSafeHandleIsValid(SafeHandle safeHandle)
		{
			throw null;
		}

		public static void AssertPlatformIsWindows()
		{
			throw null;
		}

		public static void AssertPlatformIsWindows8OrLater()
		{
			throw null;
		}

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

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public unsafe static bool TimeConstantBuffersAreEqual(byte* bufA, byte* bufB, uint count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public static bool TimeConstantBuffersAreEqual(byte[] bufA, int offsetA, int countA, byte[] bufB, int offsetB, int countB)
		{
			throw null;
		}
	}
}
