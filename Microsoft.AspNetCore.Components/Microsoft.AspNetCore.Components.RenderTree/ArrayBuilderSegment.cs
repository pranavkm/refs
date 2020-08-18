using System.Collections;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Components.RenderTree
{
	/// <summary>
	/// Types in the Microsoft.AspNetCore.Components.RenderTree are not recommended for use outside
	/// of the Blazor framework. These types will change in future release.
	/// </summary>
	/// <typeparam name="T">The type of the elements in the array</typeparam>
	public readonly struct ArrayBuilderSegment<T> : IEnumerable<T>, IEnumerable
	{
		private readonly ArrayBuilder<T>? _builder;

		private readonly int _offset;

		private readonly int _count;

		/// <summary>
		/// Gets the current underlying array holding the segment's elements.
		/// </summary>
		public T[] Array
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the offset into the underlying array holding the segment's elements.
		/// </summary>
		public int Offset
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the number of items in the segment.
		/// </summary>
		public int Count
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the specified item from the segment.
		/// </summary>
		/// <param name="index">The index into the segment.</param>
		/// <returns>The array entry at the specified index within the segment.</returns>
		public T this[int index]
		{
			get
			{
				throw null;
			}
		}

		internal ArrayBuilderSegment(ArrayBuilder<T> builder, int offset, int count)
		{
			throw null;
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			throw null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw null;
		}
	}
}
