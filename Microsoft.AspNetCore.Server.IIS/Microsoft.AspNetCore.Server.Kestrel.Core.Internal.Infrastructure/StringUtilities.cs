using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
	internal static class StringUtilities
	{
		public static string GetAsciiOrUTF8StringNonNullCharacters(this ReadOnlySpan<byte> span, Encoding defaultEncoding)
		{
			throw null;
		}

		public static string GetLatin1StringNonNullCharacters(this ReadOnlySpan<byte> span)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool TryGetAsciiString(byte* input, char* output, int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool TryGetLatin1String(byte* input, char* output, int count)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveOptimization)]
		public static bool BytesOrdinalEqualsStringAndAscii(string previousValue, ReadOnlySpan<byte> newValue)
		{
			throw null;
		}

		/// <summary>
		/// A faster version of String.Concat(<paramref name="str" />, <paramref name="separator" />, <paramref name="number" />.ToString("X8"))
		/// </summary>
		/// <param name="str"></param>
		/// <param name="separator"></param>
		/// <param name="number"></param>
		/// <returns></returns>
		public static string ConcatAsHexSuffix(string str, char separator, uint number)
		{
			throw null;
		}
	}
}
