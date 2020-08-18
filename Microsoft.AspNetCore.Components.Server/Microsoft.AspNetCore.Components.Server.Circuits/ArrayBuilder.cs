using System;
using System.Buffers;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Server.Circuits
{
	/// <summary>
	/// Implements a list that uses an array of objects to store the elements.
	///
	/// This differs from a <see cref="T:System.Collections.Generic.List`1" /> in that
	/// it not only grows as required but also shrinks if cleared with significant
	/// excess capacity. This makes it useful for component rendering, because
	/// components can be long-lived and re-render frequently, with the rendered size
	/// varying dramatically depending on the user's navigation in the app.
	/// </summary>
	internal class ArrayBuilder<T> : IDisposable
	{
		protected T[] _items;

		protected int _itemsInUse;

		/// <summary>
		/// Gets the number of items.
		/// </summary>
		public int Count
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the underlying buffer.
		/// </summary>
		public T[] Buffer
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Constructs a new instance of <see cref="T:Microsoft.AspNetCore.Components.Server.Circuits.ArrayBuilder`1" />.
		/// </summary>
		public ArrayBuilder(int minCapacity = 32, ArrayPool<T> arrayPool = null)
		{
			throw null;
		}

		/// <summary>
		/// Appends a new item, automatically resizing the underlying array if necessary.
		/// </summary>
		/// <param name="item">The item to append.</param>
		/// <returns>The index of the appended item.</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int Append(in T item)
		{
			throw null;
		}

		internal int Append(T[] source, int startIndex, int length)
		{
			throw null;
		}

		/// <summary>
		/// Sets the supplied value at the specified index. The index must be within
		/// range for the array.
		/// </summary>
		/// <param name="index">The index.</param>
		/// <param name="value">The value.</param>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Overwrite(int index, in T value)
		{
			throw null;
		}

		/// <summary>
		/// Removes the last item.
		/// </summary>
		public void RemoveLast()
		{
			throw null;
		}

		/// <summary>
		/// Inserts the item at the specified index, moving the contents of the subsequent entries along by one.
		/// </summary>
		/// <param name="index">The index at which the value is to be inserted.</param>
		/// <param name="value">The value to insert.</param>
		public void InsertExpensive(int index, T value)
		{
			throw null;
		}

		/// <summary>
		/// Marks the array as empty, also shrinking the underlying storage if it was
		/// not being used to near its full capacity.
		/// </summary>
		public void Clear()
		{
			throw null;
		}

		protected void GrowBuffer(int desiredCapacity)
		{
			throw null;
		}

		public void Dispose()
		{
			throw null;
		}
	}
}
