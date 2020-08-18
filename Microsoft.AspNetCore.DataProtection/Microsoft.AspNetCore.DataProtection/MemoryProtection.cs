using System.Runtime.InteropServices;

namespace Microsoft.AspNetCore.DataProtection
{
	/// <summary>
	/// Wrappers around CryptProtectMemory / CryptUnprotectMemory.
	/// </summary>
	internal static class MemoryProtection
	{
		public static void CryptProtectMemory(SafeHandle pBuffer, uint byteCount)
		{
			throw null;
		}

		public unsafe static void CryptUnprotectMemory(byte* pBuffer, uint byteCount)
		{
			throw null;
		}

		public static void CryptUnprotectMemory(SafeHandle pBuffer, uint byteCount)
		{
			throw null;
		}
	}
}
