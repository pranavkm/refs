using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Infrastructure
{
	internal static class HttpCharacters
	{
		internal static void Initialize()
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool ContainsInvalidAuthorityChar(Span<byte> s)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfInvalidHostChar(string s)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfInvalidTokenChar(string s)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfInvalidTokenChar(ReadOnlySpan<byte> span)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfInvalidFieldValueChar(string s)
		{
			throw null;
		}
	}
}
