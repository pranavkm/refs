using System.Runtime.CompilerServices;

namespace System.Buffers
{
	internal ref struct SequenceReader<T> where T : unmanaged, IEquatable<T>
	{
		/// <summary>
		/// A value indicating whether we're using <see cref="F:System.Buffers.SequenceReader`1.sequence" /> (as opposed to <see cref="F:System.Buffers.SequenceReader`1.memory" />.
		/// </summary>
		private bool usingSequence;

		/// <summary>
		/// Backing for the entire sequence when we're not using <see cref="F:System.Buffers.SequenceReader`1.memory" />.
		/// </summary>
		private ReadOnlySequence<T> sequence;

		/// <summary>
		/// The position at the start of the <see cref="P:System.Buffers.SequenceReader`1.CurrentSpan" />.
		/// </summary>
		private SequencePosition currentPosition;

		/// <summary>
		/// The position at the end of the <see cref="P:System.Buffers.SequenceReader`1.CurrentSpan" />.
		/// </summary>
		private SequencePosition nextPosition;

		/// <summary>
		/// Backing for the entire sequence when we're not using <see cref="F:System.Buffers.SequenceReader`1.sequence" />.
		/// </summary>
		private ReadOnlyMemory<T> memory;

		/// <summary>
		/// A value indicating whether there is unread data remaining.
		/// </summary>
		private bool moreData;

		/// <summary>
		/// The total number of elements in the sequence.
		/// </summary>
		private long length;

		/// <summary>
		/// Gets a value indicating whether there is no more data in the <see cref="P:System.Buffers.SequenceReader`1.Sequence" />.
		/// </summary>
		public bool End
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the underlying <see cref="T:System.Buffers.ReadOnlySequence`1" /> for the reader.
		/// </summary>
		public ReadOnlySequence<T> Sequence
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the current position in the <see cref="P:System.Buffers.SequenceReader`1.Sequence" />.
		/// </summary>
		public SequencePosition Position
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the current segment in the <see cref="P:System.Buffers.SequenceReader`1.Sequence" /> as a span.
		/// </summary>
		public ReadOnlySpan<T> CurrentSpan
		{
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the index in the <see cref="P:System.Buffers.SequenceReader`1.CurrentSpan" />.
		/// </summary>
		public int CurrentSpanIndex
		{
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the unread portion of the <see cref="P:System.Buffers.SequenceReader`1.CurrentSpan" />.
		/// </summary>
		public ReadOnlySpan<T> UnreadSpan
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the total number of <typeparamref name="T" />'s processed by the reader.
		/// </summary>
		public long Consumed
		{
			[CompilerGenerated]
			readonly get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets remaining <typeparamref name="T" />'s in the reader's <see cref="P:System.Buffers.SequenceReader`1.Sequence" />.
		/// </summary>
		public long Remaining
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets count of <typeparamref name="T" /> in the reader's <see cref="P:System.Buffers.SequenceReader`1.Sequence" />.
		/// </summary>
		public long Length
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.Buffers.SequenceReader`1" /> struct
		/// over the given <see cref="T:System.Buffers.ReadOnlySequence`1" />.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public SequenceReader(in ReadOnlySequence<T> sequence)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.Buffers.SequenceReader`1" /> struct
		/// over the given <see cref="T:System.ReadOnlyMemory`1" />.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public SequenceReader(ReadOnlyMemory<T> memory)
		{
			throw null;
		}

		/// <summary>
		/// Peeks at the next value without advancing the reader.
		/// </summary>
		/// <param name="value">The next value or default if at the end.</param>
		/// <returns>False if at the end of the reader.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryPeek(out T value)
		{
			throw null;
		}

		/// <summary>
		/// Read the next value and advance the reader.
		/// </summary>
		/// <param name="value">The next value or default if at the end.</param>
		/// <returns>False if at the end of the reader.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryRead(out T value)
		{
			throw null;
		}

		/// <summary>
		/// Move the reader back the specified number of items.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Rewind(long count)
		{
			throw null;
		}

		/// <summary>
		/// Move the reader ahead the specified number of items.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Advance(long count)
		{
			throw null;
		}

		/// <summary>
		/// Unchecked helper to avoid unnecessary checks where you know count is valid.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void AdvanceCurrentSpan(long count)
		{
			throw null;
		}

		/// <summary>
		/// Only call this helper if you know that you are advancing in the current span
		/// with valid count and there is no need to fetch the next one.
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void AdvanceWithinSpan(long count)
		{
			throw null;
		}

		/// <summary>
		/// Move the reader ahead the specified number of items
		/// if there are enough elements remaining in the sequence.
		/// </summary>
		/// <returns><c>true</c> if there were enough elements to advance; otherwise <c>false</c>.</returns>
		internal bool TryAdvance(long count)
		{
			throw null;
		}

		/// <summary>
		/// Copies data from the current <see cref="P:System.Buffers.SequenceReader`1.Position" /> to the given <paramref name="destination" /> span.
		/// </summary>
		/// <param name="destination">Destination to copy to.</param>
		/// <returns>True if there is enough data to copy to the <paramref name="destination" />.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool TryCopyTo(Span<T> destination)
		{
			throw null;
		}

		internal bool TryCopyMultisegment(Span<T> destination)
		{
			throw null;
		}
	}
}
