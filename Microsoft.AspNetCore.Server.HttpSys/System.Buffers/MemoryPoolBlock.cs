using System.Runtime.CompilerServices;

namespace System.Buffers
{
	/// <summary>
	/// Block tracking object used by the byte buffer memory pool. A slab is a large allocation which is divided into smaller blocks. The
	/// individual blocks are then treated as independent array segments.
	/// </summary>
	internal sealed class MemoryPoolBlock : IMemoryOwner<byte>, IDisposable
	{
		/// <summary>
		/// Back-reference to the memory pool which this block was allocated from. It may only be returned to this pool.
		/// </summary>
		public SlabMemoryPool Pool
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Back-reference to the slab from which this block was taken, or null if it is one-time-use memory.
		/// </summary>
		public MemoryPoolSlab Slab
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public Memory<byte> Memory
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// This object cannot be instantiated outside of the static Create method
		/// </summary>
		internal MemoryPoolBlock(SlabMemoryPool pool, MemoryPoolSlab slab, int offset, int length)
		{
			throw null;
		}

		~MemoryPoolBlock()
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}

		public void Lease()
		{
			throw null;
		}
	}
}
