namespace System.Buffers
{
	internal class MemoryPoolThrowHelper
	{
		internal enum ExceptionArgument
		{
			size,
			offset,
			length,
			MemoryPoolBlock,
			MemoryPool
		}

		public static void ThrowArgumentOutOfRangeException(int sourceLength, int offset)
		{
			throw null;
		}

		public static void ThrowInvalidOperationException_PinCountZero(DiagnosticPoolBlock block)
		{
			throw null;
		}

		public static void ThrowInvalidOperationException_ReturningPinnedBlock(DiagnosticPoolBlock block)
		{
			throw null;
		}

		public static void ThrowInvalidOperationException_DoubleDispose()
		{
			throw null;
		}

		public static void ThrowInvalidOperationException_BlockDoubleDispose(DiagnosticPoolBlock block)
		{
			throw null;
		}

		public static void ThrowInvalidOperationException_BlockReturnedToDisposedPool(DiagnosticPoolBlock block)
		{
			throw null;
		}

		public static void ThrowInvalidOperationException_BlockIsBackedByDisposedSlab(DiagnosticPoolBlock block)
		{
			throw null;
		}

		public static void ThrowInvalidOperationException_DisposingPoolWithActiveBlocks(int returned, int total, DiagnosticPoolBlock[] blocks)
		{
			throw null;
		}

		public static void ThrowInvalidOperationException_BlocksWereNotReturnedInTime(int returned, int total, DiagnosticPoolBlock[] blocks)
		{
			throw null;
		}

		public static void ThrowArgumentOutOfRangeException_BufferRequestTooLarge(int maxSize)
		{
			throw null;
		}

		public static void ThrowObjectDisposedException(ExceptionArgument argument)
		{
			throw null;
		}

		public MemoryPoolThrowHelper()
		{
			throw null;
		}
	}
}
