using System;
using System.Buffers;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Nerdbank.Streams
{
	/// <summary>
	/// Manages a sequence of elements, readily castable as a <see cref="T:System.Buffers.ReadOnlySequence`1" />.
	/// </summary>
	/// <typeparam name="T">The type of element stored by the sequence.</typeparam>
	/// <remarks>
	/// Instance members are not thread-safe.
	/// </remarks>
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	internal class Sequence<T> : IBufferWriter<T>, IDisposable
	{
		private class SequenceSegment : ReadOnlySequenceSegment<T>
		{
			/// <summary>
			/// Gets the position within <see cref="P:System.Buffers.ReadOnlySequenceSegment`1.Memory" /> where the data starts.
			/// </summary>
			/// <remarks>This may be nonzero as a result of calling <see cref="M:Nerdbank.Streams.Sequence`1.AdvanceTo(System.SequencePosition)" />.</remarks>
			internal int Start
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			/// <summary>
			/// Gets the position within <see cref="P:System.Buffers.ReadOnlySequenceSegment`1.Memory" /> where the data ends.
			/// </summary>
			internal int End
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			/// <summary>
			/// Gets the tail of memory that has not yet been committed.
			/// </summary>
			internal Memory<T> RemainingMemory
			{
				get
				{
					throw null;
				}
			}

			/// <summary>
			/// Gets the tail of memory that has not yet been committed.
			/// </summary>
			internal Span<T> RemainingSpan
			{
				get
				{
					throw null;
				}
			}

			/// <summary>
			/// Gets the tracker for the underlying array for this segment, which can be used to recycle the array when we're disposed of.
			/// Will be <c>null</c> if using an array pool, in which case the memory is held by <see cref="F:Nerdbank.Streams.Sequence`1.SequenceSegment.array" />.
			/// </summary>
			internal IMemoryOwner<T> MemoryOwner
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			/// <summary>
			/// Gets the full memory owned by the <see cref="P:Nerdbank.Streams.Sequence`1.SequenceSegment.MemoryOwner" />.
			/// </summary>
			internal Memory<T> AvailableMemory
			{
				get
				{
					throw null;
				}
			}

			/// <summary>
			/// Gets the number of elements that are committed in this segment.
			/// </summary>
			internal int Length
			{
				get
				{
					throw null;
				}
			}

			/// <summary>
			/// Gets the amount of writable bytes in this segment.
			/// It is the amount of bytes between <see cref="P:Nerdbank.Streams.Sequence`1.SequenceSegment.Length" /> and <see cref="P:Nerdbank.Streams.Sequence`1.SequenceSegment.End" />.
			/// </summary>
			internal int WritableBytes
			{
				get
				{
					throw null;
				}
			}

			/// <summary>
			/// Gets or sets the next segment in the singly linked list of segments.
			/// </summary>
			internal new SequenceSegment Next
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
			/// Assigns this (recyclable) segment a new area in memory.
			/// </summary>
			/// <param name="memoryOwner">The memory and a means to recycle it.</param>
			internal void Assign(IMemoryOwner<T> memoryOwner)
			{
				throw null;
			}

			/// <summary>
			/// Assigns this (recyclable) segment a new area in memory.
			/// </summary>
			/// <param name="array">An array drawn from an <see cref="T:System.Buffers.ArrayPool`1" />.</param>
			internal void Assign(T[] array)
			{
				throw null;
			}

			/// <summary>
			/// Clears all fields in preparation to recycle this instance.
			/// </summary>
			internal void ResetMemory(ArrayPool<T> arrayPool)
			{
				throw null;
			}

			/// <summary>
			/// Adds a new segment after this one.
			/// </summary>
			/// <param name="segment">The next segment in the linked list.</param>
			internal void SetNext(SequenceSegment segment)
			{
				throw null;
			}

			/// <summary>
			/// Commits more elements as written in this segment.
			/// </summary>
			/// <param name="count">The number of elements written.</param>
			internal void Advance(int count)
			{
				throw null;
			}

			/// <summary>
			/// Removes some elements from the start of this segment.
			/// </summary>
			/// <param name="offset">The number of elements to ignore from the start of the underlying array.</param>
			internal void AdvanceTo(int offset)
			{
				throw null;
			}

			public SequenceSegment()
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the minimum length for any array allocated as a segment in the sequence.
		/// Any non-positive value allows the pool to determine the length of the array.
		/// </summary>
		/// <value>The default value is 0.</value>
		/// <remarks>
		/// <para>
		/// Each time <see cref="M:Nerdbank.Streams.Sequence`1.GetSpan(System.Int32)" /> or <see cref="M:Nerdbank.Streams.Sequence`1.GetMemory(System.Int32)" /> is called,
		/// previously allocated memory is used if it is large enough to satisfy the length demand.
		/// If new memory must be allocated, the argument to one of these methods typically dictate
		/// the length of array to allocate. When the caller uses very small values (just enough for its immediate need)
		/// but the high level scenario can predict that a large amount of memory will be ultimately required,
		/// it can be advisable to set this property to a value such that just a few larger arrays are allocated
		/// instead of many small ones.
		/// </para>
		/// <para>
		/// The <see cref="T:System.Buffers.MemoryPool`1" /> in use may itself have a minimum array length as well,
		/// in which case the higher of the two minimums dictate the minimum array size that will be allocated.
		/// </para>
		/// </remarks>
		public int MinimumSpanLength
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
		/// Gets this sequence expressed as a <see cref="T:System.Buffers.ReadOnlySequence`1" />.
		/// </summary>
		/// <returns>A read only sequence representing the data in this object.</returns>
		public ReadOnlySequence<T> AsReadOnlySequence
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the length of the sequence.
		/// </summary>
		public long Length
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Nerdbank.Streams.Sequence`1" /> class
		/// that uses a private <see cref="T:System.Buffers.ArrayPool`1" /> for recycling arrays.
		/// </summary>
		public Sequence()
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Nerdbank.Streams.Sequence`1" /> class.
		/// </summary>
		/// <param name="memoryPool">The pool to use for recycling backing arrays.</param>
		public Sequence(MemoryPool<T> memoryPool)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Nerdbank.Streams.Sequence`1" /> class.
		/// </summary>
		/// <param name="arrayPool">The pool to use for recycling backing arrays.</param>
		public Sequence(ArrayPool<T> arrayPool)
		{
			throw null;
		}

		/// <summary>
		/// Expresses this sequence as a <see cref="T:System.Buffers.ReadOnlySequence`1" />.
		/// </summary>
		/// <param name="sequence">The sequence to convert.</param>
		public static implicit operator ReadOnlySequence<T>(Sequence<T> sequence)
		{
			throw null;
		}

		/// <summary>
		/// Removes all elements from the sequence from its beginning to the specified position,
		/// considering that data to have been fully processed.
		/// </summary>
		/// <param name="position">
		/// The position of the first element that has not yet been processed.
		/// This is typically <see cref="P:System.Buffers.ReadOnlySequence`1.End" /> after reading all elements from that instance.
		/// </param>
		public void AdvanceTo(SequencePosition position)
		{
			throw null;
		}

		/// <summary>
		/// Advances the sequence to include the specified number of elements initialized into memory
		/// returned by a prior call to <see cref="M:Nerdbank.Streams.Sequence`1.GetMemory(System.Int32)" />.
		/// </summary>
		/// <param name="count">The number of elements written into memory.</param>
		public void Advance(int count)
		{
			throw null;
		}

		/// <summary>
		/// Gets writable memory that can be initialized and added to the sequence via a subsequent call to <see cref="M:Nerdbank.Streams.Sequence`1.Advance(System.Int32)" />.
		/// </summary>
		/// <param name="sizeHint">The size of the memory required, or 0 to just get a convenient (non-empty) buffer.</param>
		/// <returns>The requested memory.</returns>
		public Memory<T> GetMemory(int sizeHint)
		{
			throw null;
		}

		/// <summary>
		/// Gets writable memory that can be initialized and added to the sequence via a subsequent call to <see cref="M:Nerdbank.Streams.Sequence`1.Advance(System.Int32)" />.
		/// </summary>
		/// <param name="sizeHint">The size of the memory required, or 0 to just get a convenient (non-empty) buffer.</param>
		/// <returns>The requested memory.</returns>
		public Span<T> GetSpan(int sizeHint)
		{
			throw null;
		}

		/// <summary>
		/// Clears the entire sequence, recycles associated memory into pools,
		/// and resets this instance for reuse.
		/// This invalidates any <see cref="T:System.Buffers.ReadOnlySequence`1" /> previously produced by this instance.
		/// </summary>
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void Dispose()
		{
			throw null;
		}

		/// <summary>
		/// Clears the entire sequence and recycles associated memory into pools.
		/// This invalidates any <see cref="T:System.Buffers.ReadOnlySequence`1" /> previously produced by this instance.
		/// </summary>
		public void Reset()
		{
			throw null;
		}
	}
}
