using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2
{
	internal static class Bitshifter
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ReadUInt24BigEndian(ReadOnlySpan<byte> source)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteUInt24BigEndian(Span<byte> destination, uint value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static uint ReadUInt31BigEndian(ReadOnlySpan<byte> source)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteUInt31BigEndian(Span<byte> destination, uint value)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteUInt31BigEndian(Span<byte> destination, uint value, bool preserveHighestBit)
		{
			throw null;
		}
	}
}
