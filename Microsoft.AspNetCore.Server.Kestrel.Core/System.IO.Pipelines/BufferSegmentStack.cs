namespace System.IO.Pipelines
{
	internal struct BufferSegmentStack
	{
		/// <summary>
		/// A simple struct we wrap reference types inside when storing in arrays to
		/// bypass the CLR's covariant checks when writing to arrays.
		/// </summary>
		/// <remarks>
		/// We use <see cref="T:System.IO.Pipelines.BufferSegmentStack.SegmentAsValueType" /> as a wrapper to avoid paying the cost of covariant checks whenever
		/// the underlying array that the <see cref="T:System.IO.Pipelines.BufferSegmentStack" /> class uses is written to. 
		/// We've recognized this as a perf win in ETL traces for these stack frames:
		/// clr!JIT_Stelem_Ref
		///   clr!ArrayStoreCheck
		///     clr!ObjIsInstanceOf
		/// </remarks>
		private readonly struct SegmentAsValueType
		{
			private readonly BufferSegment _value;

			public static implicit operator SegmentAsValueType(BufferSegment s)
			{
				throw null;
			}

			public static implicit operator BufferSegment(SegmentAsValueType s)
			{
				throw null;
			}
		}

		private SegmentAsValueType[] _array;

		private int _size;

		public int Count
		{
			get
			{
				throw null;
			}
		}

		public BufferSegmentStack(int size)
		{
			throw null;
		}

		public bool TryPop(out BufferSegment result)
		{
			throw null;
		}

		public void Push(BufferSegment item)
		{
			throw null;
		}
	}
}
