using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.DataProtection
{
	internal static class BitHelpers
	{
		/// <summary>
		/// Writes an unsigned 32-bit value to a memory address, big-endian.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void WriteTo(void* ptr, uint value)
		{
			throw null;
		}

		/// <summary>
		/// Writes an unsigned 32-bit value to a memory address, big-endian.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void WriteTo(ref byte* ptr, uint value)
		{
			throw null;
		}

		/// <summary>
		/// Writes a signed 32-bit value to a memory address, big-endian.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteTo(byte[] buffer, ref int idx, int value)
		{
			throw null;
		}

		/// <summary>
		/// Writes a signed 32-bit value to a memory address, big-endian.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void WriteTo(byte[] buffer, ref int idx, uint value)
		{
			throw null;
		}
	}
}
