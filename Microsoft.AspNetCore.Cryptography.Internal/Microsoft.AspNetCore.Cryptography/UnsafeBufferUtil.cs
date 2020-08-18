using Microsoft.AspNetCore.Cryptography.SafeHandles;
using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Cryptography
{
	internal static class UnsafeBufferUtil
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void BlockCopy(void* from, void* to, int byteCount)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void BlockCopy(void* from, void* to, uint byteCount)
		{
			throw null;
		}

		public unsafe static void BlockCopy(LocalAllocHandle from, void* to, uint byteCount)
		{
			throw null;
		}

		public unsafe static void BlockCopy(void* from, LocalAllocHandle to, uint byteCount)
		{
			throw null;
		}

		public static void BlockCopy(LocalAllocHandle from, LocalAllocHandle to, IntPtr length)
		{
			throw null;
		}

		/// <summary>
		/// Securely clears a memory buffer.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void SecureZeroMemory(byte* buffer, int byteCount)
		{
			throw null;
		}

		/// <summary>
		/// Securely clears a memory buffer.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void SecureZeroMemory(byte* buffer, uint byteCount)
		{
			throw null;
		}

		/// <summary>
		/// Securely clears a memory buffer.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static void SecureZeroMemory(byte* buffer, ulong byteCount)
		{
			throw null;
		}

		/// <summary>
		/// Securely clears a memory buffer.
		/// </summary>
		public unsafe static void SecureZeroMemory(byte* buffer, IntPtr length)
		{
			throw null;
		}
	}
}
