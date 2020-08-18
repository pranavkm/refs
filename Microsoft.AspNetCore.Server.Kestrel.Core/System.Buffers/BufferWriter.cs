using System.Runtime.CompilerServices;

namespace System.Buffers
{
	/// <summary>
	/// A fast access struct that wraps <see cref="T:System.Buffers.IBufferWriter`1" />.
	/// </summary>
	/// <typeparam name="T">The type of element to be written.</typeparam>
	internal ref struct BufferWriter<T> where T : IBufferWriter<byte>
	{
		/// <summary>
		/// The underlying <see cref="T:System.Buffers.IBufferWriter`1" />.
		/// </summary>
		private T _output;

		/// <summary>
		/// The result of the last call to <see cref="M:System.Buffers.IBufferWriter`1.GetSpan(System.Int32)" />, less any bytes already "consumed" with <see cref="M:System.Buffers.BufferWriter`1.Advance(System.Int32)" />.
		/// Backing field for the <see cref="P:System.Buffers.BufferWriter`1.Span" /> property.
		/// </summary>
		private Span<byte> _span;

		/// <summary>
		/// The number of uncommitted bytes (all the calls to <see cref="M:System.Buffers.BufferWriter`1.Advance(System.Int32)" /> since the last call to <see cref="M:System.Buffers.BufferWriter`1.Commit" />).
		/// </summary>
		private int _buffered;

		/// <summary>
		/// The total number of bytes written with this writer.
		/// Backing field for the <see cref="P:System.Buffers.BufferWriter`1.BytesCommitted" /> property.
		/// </summary>
		private long _bytesCommitted;

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
		/// Initializes a new instance of the <see cref="T:System.Buffers.BufferWriter`1" /> struct.
		/// </summary>
		/// <param name="output">The <see cref="T:System.Buffers.IBufferWriter`1" /> to be wrapped.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public BufferWriter(T output)
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
		/// Copies the caller's buffer into this writer and calls <see cref="M:System.Buffers.BufferWriter`1.Advance(System.Int32)" /> with the length of the source buffer.
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
	}
}
