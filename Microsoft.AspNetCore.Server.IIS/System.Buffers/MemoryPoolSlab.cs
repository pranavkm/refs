using System.Runtime.CompilerServices;

namespace System.Buffers
{
	/// <summary>
	/// Slab tracking object used by the byte buffer memory pool. A slab is a large allocation which is divided into smaller blocks. The
	/// individual blocks are then treated as independent array segments.
	/// </summary>
	internal class MemoryPoolSlab : IDisposable
	{
		/// <summary>
		/// True as long as the blocks from this slab are to be considered returnable to the pool. In order to shrink the
		/// memory pool size an entire slab must be removed. That is done by (1) setting IsActive to false and removing the
		/// slab from the pool's _slabs collection, (2) as each block currently in use is Return()ed to the pool it will
		/// be allowed to be garbage collected rather than re-pooled, and (3) when all block tracking objects are garbage
		/// collected and the slab is no longer references the slab will be garbage collected
		/// </summary>
		public bool IsActive
		{
			get
			{
				throw null;
			}
		}

		public byte[] PinnedArray
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public static MemoryPoolSlab Create(int length)
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}
	}
}
