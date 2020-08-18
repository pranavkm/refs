using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Routing.Matching
{
	internal static class Ascii
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AsciiIgnoreCaseEquals(ReadOnlySpan<char> a, ReadOnlySpan<char> b, int length)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool AsciiIgnoreCaseEquals(char charA, char charB)
		{
			throw null;
		}

		public static bool IsAscii(string text)
		{
			throw null;
		}
	}
}
