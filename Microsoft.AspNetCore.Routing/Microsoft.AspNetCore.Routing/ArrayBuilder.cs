namespace Microsoft.AspNetCore.Routing
{
	/// <summary>
	/// Helper type for avoiding allocations while building arrays.
	/// </summary>
	/// <typeparam name="T">The element type.</typeparam>
	internal struct ArrayBuilder<T>
	{
		private const int DefaultCapacity = 4;

		private const int MaxCoreClrArrayLength = 2146435071;

		private T[] _array;

		private int _count;

		/// <summary>
		/// Gets the number of items this instance can store without re-allocating,
		/// or 0 if the backing array is <c>null</c>.
		/// </summary>
		public int Capacity
		{
			get
			{
				throw null;
			}
		}

		/// <summary>Gets the current underlying array.</summary>
		public T[] Buffer
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the number of items in the array currently in use.
		/// </summary>
		public int Count
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the item at a certain index in the array.
		/// </summary>
		/// <param name="index">The index into the array.</param>
		public T this[int index]
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes the <see cref="T:Microsoft.AspNetCore.Routing.ArrayBuilder`1" /> with a specified capacity.
		/// </summary>
		/// <param name="capacity">The capacity of the array to allocate.</param>
		public ArrayBuilder(int capacity)
		{
			throw null;
		}

		/// <summary>
		/// Adds an item to the backing array, resizing it if necessary.
		/// </summary>
		/// <param name="item">The item to add.</param>
		public void Add(T item)
		{
			throw null;
		}

		/// <summary>
		/// Gets the first item in this builder.
		/// </summary>
		public T First()
		{
			throw null;
		}

		/// <summary>
		/// Gets the last item in this builder.
		/// </summary>
		public T Last()
		{
			throw null;
		}

		/// <summary>
		/// Creates an array from the contents of this builder.
		/// </summary>
		/// <remarks>
		/// Do not call this method twice on the same builder.
		/// </remarks>
		public T[] ToArray()
		{
			throw null;
		}

		/// <summary>
		/// Adds an item to the backing array, without checking if there is room.
		/// </summary>
		/// <param name="item">The item to add.</param>
		/// <remarks>
		/// Use this method if you know there is enough space in the <see cref="T:Microsoft.AspNetCore.Routing.ArrayBuilder`1" />
		/// for another item, and you are writing performance-sensitive code.
		/// </remarks>
		public void UncheckedAdd(T item)
		{
			throw null;
		}
	}
}
