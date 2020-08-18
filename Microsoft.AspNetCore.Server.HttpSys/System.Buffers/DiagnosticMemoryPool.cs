using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace System.Buffers
{
	/// <summary>
	/// Used to allocate and distribute re-usable blocks of memory.
	/// </summary>
	internal class DiagnosticMemoryPool : MemoryPool<byte>
	{
		public bool IsDisposed
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public override int MaxBufferSize
		{
			get
			{
				throw null;
			}
		}

		public DiagnosticMemoryPool(MemoryPool<byte> pool, bool allowLateReturn = false, bool rentTracking = false)
		{
			throw null;
		}

		public override IMemoryOwner<byte> Rent(int size = -1)
		{
			throw null;
		}

		internal void Return(DiagnosticPoolBlock block)
		{
			throw null;
		}

		internal void ReportException(Exception exception)
		{
			throw null;
		}

		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CWhenAllBlocksReturnedAsync_003Ed__22))]
		[DebuggerStepThrough]
		public Task WhenAllBlocksReturnedAsync(TimeSpan timeout)
		{
			throw null;
		}
	}
}
