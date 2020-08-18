using System;
using System.Buffers;
using System.Runtime.CompilerServices;

namespace MessagePack
{
	/// <summary>
	/// A fast access struct that wraps <see cref="T:System.Buffers.IBufferWriter`1" />.
	/// </summary>
	internal ref struct BufferWriter
	{
		/// <summary>
		/// The underlying <see cref="T:System.Buffers.IBufferWriter`1" />.
		/// </summary>
		private IBufferWriter<byte> _output;

		/// <summary>
		/// The result of the last call to <see cref="M:System.Buffers.IBufferWriter`1.GetSpan(System.Int32)" />, less any bytes already "consumed" with <see cref="M:MessagePack.BufferWriter.Advance(System.Int32)" />.
		/// Backing field for the <see cref="P:MessagePack.BufferWriter.Span" /> property.
		/// </summary>
		private Span<byte> _span;

		/// <summary>
		/// The result of the last call to <see cref="M:System.Buffers.IBufferWriter`1.GetMemory(System.Int32)" />, less any bytes already "consumed" with <see cref="M:MessagePack.BufferWriter.Advance(System.Int32)" />.
		/// </summary>
		private ArraySegment<byte> _segment;

		/// <summary>
		/// The number of uncommitted bytes (all the calls to <see cref="M:MessagePack.BufferWriter.Advance(System.Int32)" /> since the last call to <see cref="M:MessagePack.BufferWriter.Commit" />).
		/// </summary>
		private int _buffered;

		/// <summary>
		/// The total number of bytes written with this writer.
		/// Backing field for the <see cref="P:MessagePack.BufferWriter.BytesCommitted" /> property.
		/// </summary>
		private long _bytesCommitted;

		private SequencePool _sequencePool;

		private SequencePool.Rental _rental;

		/// <summary>
		/// Gets the result of the last call to <see cref="M:System.Buffers.IBufferWriter`1.GetSpan(System.Int32)" />.
		/// </summary>
		public Span<byte> Span
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the total number of bytes written with this writer.
		/// </summary>
		public long BytesCommitted
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the <see cref="T:System.Buffers.IBufferWriter`1" /> underlying this instance.
		/// </summary>
		internal IBufferWriter<byte> UnderlyingWriter
		{
			get
			{
				throw null;
			}
		}

		internal SequencePool.Rental SequenceRental
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:MessagePack.BufferWriter" /> struct.
		/// </summary>
		/// <param name="output">The <see cref="T:System.Buffers.IBufferWriter`1" /> to be wrapped.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public BufferWriter(IBufferWriter<byte> output)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:MessagePack.BufferWriter" /> struct.
		/// </summary>
		/// <param name="sequencePool">The pool from which to draw an <see cref="T:System.Buffers.IBufferWriter`1" /> if required..</param>
		/// <param name="array">An array to start with so we can avoid accessing the <paramref name="sequencePool" /> if possible.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal BufferWriter(SequencePool sequencePool, byte[] array)
		{
			throw null;
		}

		public Span<byte> GetSpan(int sizeHint)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ref byte GetPointer(int sizeHint)
		{
			throw null;
		}

		/// <summary>
		/// Calls <see cref="M:System.Buffers.IBufferWriter`1.Advance(System.Int32)" /> on the underlying writer
		/// with the number of uncommitted bytes.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Commit()
		{
			throw null;
		}

		/// <summary>
		/// Used to indicate that part of the buffer has been written to.
		/// </summary>
		/// <param name="count">The number of bytes written to.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Advance(int count)
		{
			throw null;
		}

		/// <summary>
		/// Copies the caller's buffer into this writer and calls <see cref="M:MessagePack.BufferWriter.Advance(System.Int32)" /> with the length of the source buffer.
		/// </summary>
		/// <param name="source">The buffer to copy in.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Write(ReadOnlySpan<byte> source)
		{
			throw null;
		}

		/// <summary>
		/// Acquires a new buffer if necessary to ensure that some given number of bytes can be written to a single buffer.
		/// </summary>
		/// <param name="count">The number of bytes that must be allocated in a single buffer.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Ensure(int count = 1)
		{
			throw null;
		}

		/// <summary>
		/// Gets the span to the bytes written if they were never committed to the underlying buffer writer.
		/// </summary>
		/// <param name="span"></param>
		/// <returns></returns>
		internal bool TryGetUncommittedSpan(out ReadOnlySpan<byte> span)
		{
			throw null;
		}
	}
}
