namespace Microsoft.AspNetCore.Components.RenderTree
{
	/// <summary>
	/// Types in the Microsoft.AspNetCore.Components.RenderTree are not recommended for use outside
	/// of the Blazor framework. These types will change in future release.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public readonly struct ArrayRange<T>
	{
		/// <summary>
		/// Gets the underlying array instance.
		/// </summary>
		public readonly T[] Array;

		/// <summary>
		/// Gets the number of items in the array that are considered to be in use.
		/// </summary>
		public readonly int Count;

		/// <summary>
		/// Constructs an instance of <see cref="T:Microsoft.AspNetCore.Components.RenderTree.ArrayRange`1" />.
		/// </summary>
		/// <param name="array">The array.</param>
		/// <param name="count">The number of items in the array that are in use.</param>
		public ArrayRange(T[] array, int count)
		{
			throw null;
		}

		/// <summary>
		/// Creates a shallow clone of the instance.
		/// </summary>
		/// <returns></returns>
		public ArrayRange<T> Clone()
		{
			throw null;
		}
	}
}
