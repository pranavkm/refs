using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace System.Buffers
{
	/// <summary>
	/// Block tracking object used by the byte buffer memory pool. A slab is a large allocation which is divided into smaller blocks. The
	/// individual blocks are then treated as independent array segments.
	/// </summary>
	internal sealed class DiagnosticPoolBlock : MemoryManager<byte>
	{
		public override Memory<byte> Memory
		{
			get
			{
				throw null;
			}
		}

		public StackTrace Leaser
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// This object cannot be instantiated outside of the static Create method
		/// </summary>
		internal DiagnosticPoolBlock(DiagnosticMemoryPool pool, IMemoryOwner<byte> memoryOwner)
		{
			throw null;
		}

		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		public override Span<byte> GetSpan()
		{
			throw null;
		}

		public override MemoryHandle Pin(int byteOffset = 0)
		{
			throw null;
		}

		protected override bool TryGetArray(out ArraySegment<byte> segment)
		{
			throw null;
		}

		public override void Unpin()
		{
			throw null;
		}

		public void Track()
		{
			throw null;
		}
	}
}
