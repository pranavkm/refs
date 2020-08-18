using System.Buffers;
using System.Runtime.CompilerServices;

namespace System.IO.Pipelines
{
	internal sealed class BufferSegment : ReadOnlySequenceSegment<byte>
	{
		/// <summary>
		/// The End represents the offset into AvailableMemory where the range of "active" bytes ends. At the point when the block is leased
		/// the End is guaranteed to be equal to Start. The value of Start may be assigned anywhere between 0 and
		/// Buffer.Length, and must be equal to or less than End.
		/// </summary>
		public int End
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Reference to the next block of data when the overall "active" bytes spans multiple blocks. At the point when the block is
		/// leased Next is guaranteed to be null. Start, End, and Next are used together in order to create a linked-list of discontiguous
		/// working memory. The "active" memory is grown when bytes are copied in, End is increased, and Next is assigned. The "active"
		/// memory is shrunk when bytes are consumed, Start is increased, and blocks are returned to the pool.
		/// </summary>
		public BufferSegment NextSegment
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		internal object MemoryOwner
		{
			get
			{
				throw null;
			}
		}

		public Memory<byte> AvailableMemory
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public int Length
		{
			get
			{
				throw null;
			}
		}

		public int WritableBytes
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				throw null;
			}
		}

		public void SetOwnedMemory(IMemoryOwner<byte> memoryOwner)
		{
			throw null;
		}

		public void SetOwnedMemory(byte[] arrayPoolBuffer)
		{
			throw null;
		}

		public void ResetMemory()
		{
			throw null;
		}

		public void SetNext(BufferSegment segment)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static long GetLength(BufferSegment startSegment, int startIndex, BufferSegment endSegment, int endIndex)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static long GetLength(long startPosition, BufferSegment endSegment, int endIndex)
		{
			throw null;
		}

		public BufferSegment()
		{
			throw null;
		}
	}
}
