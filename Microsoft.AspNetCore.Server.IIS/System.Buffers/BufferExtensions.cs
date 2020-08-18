using System.IO.Pipelines;
using System.Runtime.CompilerServices;

namespace System.Buffers
{
	internal static class BufferExtensions
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReadOnlySpan<byte> ToSpan(this in ReadOnlySequence<byte> buffer)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CopyTo(this in ReadOnlySequence<byte> buffer, PipeWriter pipeWriter)
		{
			throw null;
		}

		public static ArraySegment<byte> GetArray(this Memory<byte> buffer)
		{
			throw null;
		}

		public static ArraySegment<byte> GetArray(this ReadOnlyMemory<byte> memory)
		{
			throw null;
		}

		/// <summary>
		/// Returns position of first occurrence of item in the <see cref="T:System.Buffers.ReadOnlySequence`1" />
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static SequencePosition? PositionOfAny<T>(this in ReadOnlySequence<T> source, T value0, T value1) where T : IEquatable<T>
		{
			throw null;
		}

		internal static void WriteAscii(this ref BufferWriter<PipeWriter> buffer, string data)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void WriteNumeric(this ref BufferWriter<PipeWriter> buffer, ulong number)
		{
			throw null;
		}
	}
}
