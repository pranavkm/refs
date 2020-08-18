using System.Buffers;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal
{
	internal static class MemoryPoolExtensions
	{
		/// <summary>
		/// Computes a minimum segment size
		/// </summary>
		/// <param name="pool"></param>
		/// <returns></returns>
		public static int GetMinimumSegmentSize(this MemoryPool<byte> pool)
		{
			throw null;
		}

		public static int GetMinimumAllocSize(this MemoryPool<byte> pool)
		{
			throw null;
		}
	}
}
