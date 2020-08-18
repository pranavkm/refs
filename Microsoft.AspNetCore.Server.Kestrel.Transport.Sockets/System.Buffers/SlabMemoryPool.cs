using System.Runtime.CompilerServices;

namespace System.Buffers
{
	/// <summary>
	/// Used to allocate and distribute re-usable blocks of memory.
	/// </summary>
	internal sealed class SlabMemoryPool : MemoryPool<byte>
	{
		/// <summary>
		/// Max allocation block size for pooled blocks,
		/// larger values can be leased but they will be disposed after use rather than returned to the pool.
		/// </summary>
		public override int MaxBufferSize
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The size of a block. 4096 is chosen because most operating systems use 4k pages.
		/// </summary>
		public static int BlockSize
		{
			get
			{
				throw null;
			}
		}

		public override IMemoryOwner<byte> Rent(int size = -1)
		{
			throw null;
		}

		/// <summary>
		/// Called to return a block to the pool. Once Return has been called the memory no longer belongs to the caller, and
		/// Very Bad Things will happen if the memory is read of modified subsequently. If a caller fails to call Return and the
		/// block tracking object is garbage collected, the block tracking object's finalizer will automatically re-create and return
		/// a new tracking object into the pool. This will only happen if there is a bug in the server, however it is necessary to avoid
		/// leaving "dead zones" in the slab due to lost block tracking objects.
		/// </summary>
		/// <param name="block">The block to return. It must have been acquired by calling Lease on the same memory pool instance.</param>
		internal void Return(MemoryPoolBlock block)
		{
			throw null;
		}

		internal void RefreshBlock(MemoryPoolSlab slab, int offset, int length)
		{
			throw null;
		}

		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		public SlabMemoryPool()
		{
			throw null;
		}
	}
}
